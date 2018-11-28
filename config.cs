using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace IP_Manager
{
	public partial class config : Form
	{
		private string m_old_name;

		public config( string _name = null )
		{
			InitializeComponent();

			m_old_name = null;

			if( _name != null )
			{
				RegistryKey item = Main.reg.CreateSubKey( _name );

				textBox_name.Text = _name;
				m_old_name = _name;

				string IP_TYPE = item.GetValue( "IP_TYPE", "AUTO" ).ToString();
				if( IP_TYPE == "AUTO" )
				{
					radioBtn_auto_ip.Checked = true;
				}
				else
				{
					radioBtn_fix_ip.Checked = true;
					textbox_ip.Text = item.GetValue( "IP", "" ).ToString();
					textbox_subnetmask.Text = item.GetValue( "SUBNET_MASK", "" ).ToString();
					textbox_gateway.Text = item.GetValue( "GATEWAY", "" ).ToString();
				}
				
				string DNS_TYPE = item.GetValue( "DNS_TYPE", "AUTO" ).ToString();
				if( DNS_TYPE == "AUTO" )
				{
					radioBtn_auto_dns.Checked = true;
				}
				else
				{
					radioBtn_fix_dns.Checked = true;
					textbox_dns1.Text = item.GetValue( "DNS1", "" ).ToString();
					textbox_dns2.Text = item.GetValue( "DNS2", "" ).ToString();
				}				
			}
		}

		private void btn_cancle_Click( object sender, EventArgs e )
		{
			this.Close();
		}

		private void btn_ok_Click( object sender, EventArgs e )
		{
			if( textBox_name.Text.Length < 1 )
			{
				MessageBox.Show( "이름을 입력해 주세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error );
				return;
			}

			if( m_old_name != null )
				Main.reg.DeleteSubKeyTree( m_old_name );

			RegistryKey item = Main.reg.CreateSubKey( textBox_name.Text );

			item.SetValue( "IP_TYPE", radioBtn_auto_ip.Checked ? "AUTO" : "FIX" );
			item.SetValue( "IP", textbox_ip.Text.Replace( " ", "" ) );
			item.SetValue( "SUBNET_MASK", textbox_subnetmask.Text.Replace( " ", "" ) );
			item.SetValue( "GATEWAY", textbox_gateway.Text.Replace( " ", "" ) );

			item.SetValue( "DNS_TYPE", radioBtn_auto_dns.Checked ? "AUTO" : "FIX" );
			item.SetValue( "DNS1", textbox_dns1.Text.Replace( " ", "" ) );
			item.SetValue( "DNS2", textbox_dns2.Text.Replace( " ", "" ) );

			this.Close();
		}

		private void radioBtn_auto_ip_CheckedChanged( object sender, EventArgs e )
		{
			textbox_ip.Text.Remove(0);
			textbox_subnetmask.Text.Remove( 0 );
			textbox_gateway.Text.Remove( 0 );

			textbox_ip.Enabled = false;
			textbox_subnetmask.Enabled = false;
			textbox_gateway.Enabled = false;

			radioBtn_auto_dns.Enabled = true;
		}

		private void radioBtn_fix_ip_CheckedChanged( object sender, EventArgs e )
		{
			textbox_ip.Enabled = true;
			textbox_subnetmask.Enabled = true;
			textbox_gateway.Enabled = true;

			radioBtn_auto_dns.Enabled = false;
			radioBtn_fix_dns.Checked = true;
		}

		private void radioBtn_auto_dns_CheckedChanged( object sender, EventArgs e )
		{
			textbox_dns1.Text.Remove( 0 );
			textbox_dns2.Text.Remove( 0 );

			textbox_dns1.Enabled = false;
			textbox_dns2.Enabled = false;
		}

		private void radioBtn_fix_dns_CheckedChanged( object sender, EventArgs e )
		{
			textbox_dns1.Enabled = true;
			textbox_dns2.Enabled = true;
		}
		
	}
}
