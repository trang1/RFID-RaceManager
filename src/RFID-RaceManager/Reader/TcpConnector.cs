using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace Reader
{
    public class TcpConnector:IConnector
    {
        public event MessageReceivedEventHandler MessageReceived;

        TcpClient client;
        Stream streamToTran;
        private Thread waitThread;

        private bool bIsConnect = false;

        public bool Connect(IPAddress ipAddress, int nPort, out string strException)
        {
            strException = string.Empty;
            try
            {
                client = new TcpClient();
                client.Connect(ipAddress, nPort);
                streamToTran = client.GetStream();    // Get connected to a remote stream

                //Set up thread to receive data sent by server
                ThreadStart stThead = new ThreadStart(ReceivedData);
                waitThread = new Thread(stThead);
                waitThread.IsBackground = true;
                waitThread.Start();

                bIsConnect = true;
                return true;
            }
            catch (System.Exception ex)
            {
                strException = ex.Message;
                return false;
            }
        }

        private void ReceivedData()
        {
            while (true)
            {
                try
                {
                    byte[] btAryBuffer = new byte[4096];
                    int nLenRead = streamToTran.Read(btAryBuffer, 0, btAryBuffer.Length);
                    if (nLenRead == 0)
                    {
                        continue;
                    }

                    if (MessageReceived != null)
                    {
                        byte[] btAryReceiveData = new byte[nLenRead];

                        Array.Copy(btAryBuffer, btAryReceiveData, nLenRead);

                        MessageReceived(btAryReceiveData);
                    }
                }
                catch (System.Exception ex)
                {
                	
                }
            }
            
        }

        public bool SendMessage(byte[] btAryBuffer)
        {
            try
            {
                lock (streamToTran)
                {
                    streamToTran.Write(btAryBuffer, 0, btAryBuffer.Length);
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public void SignOut()
        {
            if (streamToTran != null)
                streamToTran.Dispose();
            if (client != null)
                client.Close();

            waitThread.Abort();
            bIsConnect = false;
        }

        public bool IsConnect()
        {
            return bIsConnect;
        }
    }
}
