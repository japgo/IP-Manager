
using System;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Diagnostics;
using System.Threading;
using System.Security.Principal;
using System.Net.NetworkInformation;

namespace IP_Manager
{
	public partial class Main : Form
	{
		public static Main instance;
		public static RegistryKey reg;

		public Main()
		{
			InitializeComponent();
			instance = this;
            
            // 레지스트에 접근하기 위해. 
            reg = Registry.LocalMachine.CreateSubKey( "Software" ).CreateSubKey( "IP_Manager" );
			this.display_ip_list();
		}

		private void display_ip_list()
		{
			this.checkedListBox.Items.Clear();

            //레지스트 내의 서브 키 목록을 가져 온다.
			foreach( string name in reg.GetSubKeyNames() )
			{
				this.checkedListBox.Items.Add( name );
			}
		}

		private void btn_add_Click( object sender, EventArgs e )
		{
			config add = new config();
			add.ShowDialog();
			this.display_ip_list();
		}

		private void btn_modify_Click( object sender, EventArgs e )
		{
			object item = this.checkedListBox.SelectedItem;

			if( item == null )
				return;

			config modify = new config( item.ToString() );
			modify.ShowDialog();
			this.display_ip_list();
		}

		private void btn_apply_Click( object sender, EventArgs e )
		{
			object sel_item = this.checkedListBox.SelectedItem;

			if( sel_item == null )
				return;

			if( comboBox1.SelectedItem == null )
				return;

			string network_name = comboBox1.SelectedItem.ToString();

			DialogResult dr = MessageBox.Show( string.Format( "'{0}' 설정을 {1}에 적용합니다.", sel_item.ToString(), network_name ),
				"적용", MessageBoxButtons.OKCancel, MessageBoxIcon.Information );

			if( dr != DialogResult.OK )
				return;

			RegistryKey reg_item = Main.reg.CreateSubKey( sel_item.ToString() );

			string IP_TYPE = reg_item.GetValue( "IP_TYPE", "AUTO" ).ToString();
			bool auto_ip = IP_TYPE == "AUTO" ? true : false;
			string ip = reg_item.GetValue( "IP", "" ).ToString();
			string subnet_mask = reg_item.GetValue( "SUBNET_MASK", "" ).ToString();
			string gateway = reg_item.GetValue( "GATEWAY", "" ).ToString();

			string DNS_TYPE = reg_item.GetValue( "DNS_TYPE", "AUTO" ).ToString();
			bool auto_dns = DNS_TYPE == "AUTO" ? true : false;
			string dns1 = reg_item.GetValue( "DNS1", "" ).ToString();
			string dns2 = reg_item.GetValue( "DNS2", "" ).ToString();

            // 명령 창 실행하기 위해 선언.
			ProcessStartInfo proinfo = new ProcessStartInfo();
			Process pro = new Process();


            proinfo.FileName = "cmd";
			proinfo.CreateNoWindow = true;
            proinfo.UseShellExecute = false;

            //proinfo.UseShellExecute = true;
            //proinfo.Verb = "runas"; // 관리자 권한으로 실행하기.

            proinfo.RedirectStandardOutput = true;
			proinfo.RedirectStandardInput = true;
			proinfo.RedirectStandardError = true;

			pro.StartInfo = proinfo;
			pro.Start();


			if( auto_ip == false )
			{
				string format = string.Format( "netsh -c int ip set address name=\"{2}\" source=static addr={0} mask={1} gwmetric=0 ", ip, subnet_mask, network_name );
				if( gateway != "..." )
				{
					format += string.Format( "gateway={0}", gateway );
				}
				format += Environment.NewLine;

				pro.StandardInput.Write( format );
			}
			else
			{
				pro.StandardInput.Write( string.Format( "netsh -c int ip set address name=\"{0}\" source=dhcp" + Environment.NewLine, network_name ) );
			}

			if( auto_dns == false )
			{
				if( dns1 != "..." )
				{
					pro.StandardInput.Write( string.Format( "netsh interface ip set dns \"{1}\" source=static address={0}" + Environment.NewLine,
					dns1, network_name ) );
				}
			}
			else
			{
				pro.StandardInput.Write( string.Format( "netsh interface ip set dns \"{0}\" source=dhcp" + Environment.NewLine, network_name ) );
			}

			pro.StandardInput.Close();

			string result = pro.StandardOutput.ReadToEnd(); // 명령 실행 후 결과 보여주기 위해 
			pro.WaitForExit(); // 명령이 정상적으로 종료 되길 기다린다.
			pro.Close(); // cmd 창 열었던 process를 닫는다.


			MessageBox.Show( result );
		}

		private void btn_delete_Click( object sender, EventArgs e )
		{
			object sel_item = this.checkedListBox.SelectedItem;

			if( sel_item == null )
				return;

			DialogResult dr = MessageBox.Show( string.Format( "'{0}' 설정을 삭제합니다.", sel_item.ToString() ),
				"삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Warning );

			if( dr != DialogResult.Yes )
				return;

			reg.DeleteSubKeyTree( sel_item.ToString() );
			this.display_ip_list();
		}

		private void Main_Load( object sender, EventArgs e )
		{
			NetworkInterface[] nicArray = NetworkInterface.GetAllNetworkInterfaces();
			foreach( NetworkInterface nic in nicArray )
			{
				comboBox1.Items.Add( nic.Name );
			}
			comboBox1.SelectedIndex = 0;
		}
	}
}

