using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ReaderMockUp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TcpListener _listener;
        bool _cancelled;
        public MainWindow()
        {
            InitializeComponent();

            IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
            cmbIps.ItemsSource = ipHostInfo.AddressList.Where(i => !i.IsIPv6LinkLocal).Select(i => i.ToString()).ToList();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (cmbIps.SelectedItem == null || string.IsNullOrEmpty(tbPort.Text))
                return;

            btnStart.IsEnabled = false;
            btnStop.IsEnabled = true;
            var tag = Convert.ToString(new Random().Next(1, 15), 16);

            _listener = new TcpListener(IPAddress.Parse(cmbIps.SelectedItem.ToString()), int.Parse(tbPort.Text));
            _listener.Start();
            var seconds = int.Parse(tbMps.Text);
            Task.Factory.StartNew(() =>
            {

                TcpClient client = _listener.AcceptTcpClient();
                while (!_cancelled)
                {
                    try
                    {
                        for (var i = 1; i < seconds; i++)
                        {
                            NetworkStream stream = client.GetStream();
                            //var ut = (long)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalMilliseconds; ;
                            //string response = "\xA0"+tag+"," + ut * 1000 + ",-52\r\n";
                            byte[] data = new byte[]
                            {
                                160, 11, 1, 137, 1,2,3,4,5,6,7,8,167
                            };

                            stream.Write(data, 0, data.Length);

                            //client.Close();
                        }
                        Thread.Sleep(1000);
                    }
                    catch (Exception)
                    {
                        break;
                    }
                }
                _listener.Stop();
            });
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            btnStart.IsEnabled = true;
            btnStop.IsEnabled = false;
            _cancelled = true;
        }
    }
}
