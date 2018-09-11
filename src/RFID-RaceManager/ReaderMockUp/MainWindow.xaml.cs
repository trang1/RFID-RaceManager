using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace ReaderMockUp
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool _cancelled;
        private TcpListener _listener;

        public MainWindow()
        {
            InitializeComponent();

            var ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
            cmbIps.ItemsSource =
                ipHostInfo.AddressList.Where(i => !i.IsIPv6LinkLocal).Select(i => i.ToString()).ToList();
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
                var client = _listener.AcceptTcpClient();
                while (!_cancelled)
                {
                    try
                    {
                        for (var i = 1; i < seconds; i++)
                        {
                            var stream = client.GetStream();
                            //var ut = (long)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalMilliseconds; ;
                            //string response = "\xA0"+tag+"," + ut * 1000 + ",-52\r\n";
                            var data = new List<byte>
                            {
                                160,
                                19,
                                1,
                                137,
                                1,
                                2,
                                0,
                                0,
                                0,
                                0,
                                0,
                                0,
                                0,
                                0,
                                0,
                                0,
                                0,
                                0,
                                (byte) i,
                                8
                            };

                            data.Add(CheckSum(data.ToArray(), 0, data.Count));
                            stream.Write(data.ToArray(), 0, data.Count);

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

        public byte CheckSum(byte[] btAryBuffer, int nStartPos, int nLen)
        {
            byte btSum = 0x00;

            for (var nloop = nStartPos; nloop < nStartPos + nLen; nloop++)
            {
                btSum += btAryBuffer[nloop];
            }

            return Convert.ToByte((~btSum + 1) & 0xFF);
        }
    }
}