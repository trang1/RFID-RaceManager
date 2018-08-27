using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace CustomControl
{
    public partial class IpAddressTextBox : UserControl
    {
        public string IpAddressStr
        {
            get
            {
                string Ipstr = Ip1.Text + "." + Ip2.Text + "." + Ip3.Text + "." + Ip4.Text;
                try
                {
                    IPAddress.Parse(Ipstr);
                }
                catch
                {
                    return "";
                }
                this.IpAddress = Ipstr;

                return this.IpAddress;
            }
            set
            {
                string ipStr = value;
                if (string.IsNullOrEmpty(ipStr))
                {
                    Ip1.Text = "";
                    Ip2.Text = "";
                    Ip3.Text = "";
                    Ip4.Text = "";
                    IpAddress = "";
                }
                else
                {
                    try
                    {
                        IPAddress ipValue = IPAddress.Parse(ipStr);
                        string[] ips = ipStr.Split('.');
                        Ip1.Text = ips[0];
                        Ip2.Text = ips[1];
                        Ip3.Text = ips[2];
                        Ip4.Text = ips[3];
                        IpAddress = ipStr;
                    }
                    catch
                    {
                        Ip1.Text = "";
                        Ip2.Text = "";
                        Ip3.Text = "";
                        Ip4.Text = "";
                        IpAddress = "";
                    }
                }
            }
        }

        private string IpAddress;

        public IpAddressTextBox()
        {
            InitializeComponent();
        }

        private void Ip1_TextChanged(object sender, EventArgs e)
        {
            if (Ip1.Text.Length == 3 && Ip1.Text.Length > 0 && Ip1.SelectionLength == 0)
            {
                if (Convert.ToInt32(Ip1.Text) > 223)
                {
                    Ip1.Text = "223";
                }
                else if (Convert.ToInt32(Ip1.Text) < 1)
                {
                    Ip1.Text = "1";
                }
                else
                {
                    Ip2.Focus();
                    Ip2.Select(0, Ip2.Text.Length);
                }                
            }
        }

        private void Ip2_TextChanged(object sender, EventArgs e)
        {
            if (Ip2.Text.Length == 3 && Ip2.Text.Length > 0 && Ip2.SelectionLength == 0)
            {
                if (Convert.ToInt32(Ip2.Text) > 255)
                {
                    Ip2.Text = "255";
                }
                else
                {
                    Ip3.Focus();
                    Ip3.Select(0, Ip3.Text.Length);
                }                
            }
        }

        private void Ip3_TextChanged(object sender, EventArgs e)
        {
            if (Ip3.Text.Length == 3 && Ip3.Text.Length > 0 && Ip3.SelectionLength == 0)
            {
                if (Convert.ToInt32(Ip3.Text) > 255)
                {
                    Ip3.Text = "255";
                }
                else
                {
                    Ip4.Focus();
                    Ip4.Select(0, Ip4.Text.Length);
                }                
            }
        }

        private void Ip4_TextChanged(object sender, EventArgs e)
        {
            if (Ip4.Text.Length == 3 && Ip4.Text.Length > 0 && Ip4.SelectionLength == 0)
            {
                if (Convert.ToInt32(Ip4.Text) > 255)
                {
                    Ip4.Text = "255";
                }
            }
        }

        private bool CheckInput(string inputString)
        {
            bool flag = false;
            System.Text.RegularExpressions.Regex r = new System.Text.RegularExpressions.Regex(@"[0-9\s]+");
            System.Text.RegularExpressions.Match m = r.Match(inputString);
            if (m.Success && m.Value == inputString)
            {
                flag = true;
            }
            return flag;
        }

        private void Ip1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string inputStr = e.KeyChar.ToString();
                        
            if (e.KeyChar != (char)ConsoleKey.Backspace)
            {
                if (e.KeyChar == 46 && Ip1.Text.Length > 0 && Ip1.SelectionLength == 0)
                {
                    Ip2.Focus();
                    Ip2.Select(0, Ip2.Text.Length);
                }
                if (CheckInput(inputStr) == false)
                {
                    e.Handled = true;
                }                
            }
            
            base.OnKeyPress(e);
        }

        private void Ip2_KeyPress(object sender, KeyPressEventArgs e)
        {
            string inputStr = e.KeyChar.ToString();

            if (e.KeyChar != (char)ConsoleKey.Backspace)
            {
                if (e.KeyChar == 46 && Ip2.Text.Length > 0 && Ip2.SelectionLength == 0)
                {
                    Ip3.Focus();
                    Ip3.Select(0, Ip3.Text.Length);
                }
                if (CheckInput(inputStr) == false)
                {
                    e.Handled = true;
                }
            }

            base.OnKeyPress(e);
        }

        private void Ip3_KeyPress(object sender, KeyPressEventArgs e)
        {
            string inputStr = e.KeyChar.ToString();

            if (e.KeyChar != (char)ConsoleKey.Backspace)
            {
                if (e.KeyChar == 46 && Ip3.Text.Length > 0 && Ip3.SelectionLength == 0)
                {
                    Ip4.Focus();
                    Ip4.Select(0, Ip4.Text.Length);
                }
                if (CheckInput(inputStr) == false)
                {
                    e.Handled = true;
                }
            }

            base.OnKeyPress(e);
        }

        private void Ip4_KeyPress(object sender, KeyPressEventArgs e)
        {
            string inputStr = e.KeyChar.ToString();

            if (e.KeyChar != (char)ConsoleKey.Backspace)
            {
                if (CheckInput(inputStr) == false)
                {
                    e.Handled = true;
                }
            }

            base.OnKeyPress(e);
        }

    }
}
