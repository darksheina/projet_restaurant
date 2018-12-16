using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using Newtonsoft.Json;

namespace SocketHelper
{
    public delegate void ReceivedMessage(Message message);

    public class Server
    {
        private Thread t;
        private ThreadServer threadHandle;
        public Server(string serverIP, int port, ReceivedMessage onResponse)
        {
            threadHandle = new ThreadServer(serverIP, port, onResponse);
            t = new Thread(new ThreadStart(threadHandle.ThreadLoop));
        }

        public void Start()
        {
            t.Start();
        }

        public void Stop()
        {
            threadHandle.Close();
            t.Abort();
        }

        public class ThreadServer
        {
            IPAddress ip;
            TcpClient client;
            TcpListener server;
            ReceivedMessage callback;

            bool shouldClose = false;

            public void Close()
            {
                shouldClose = true;
                server.Stop();
            }

            public ThreadServer(string ipAdress, int port, ReceivedMessage onResponseMethod)
            {
                callback = onResponseMethod;
                ip = Dns.GetHostEntry(ipAdress).AddressList[0];
                server = new TcpListener(ip, port);
                client = default(TcpClient);
                try
                {
                    server.Start();
                    Console.WriteLine("Server started...");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    Console.Read();
                }
            }

            public void ThreadLoop()
            {
                while (!shouldClose)
                {
                    client = server.AcceptTcpClient();
                    byte[] receivedBuffer = new byte[10000];
                    NetworkStream stream = client.GetStream();
                    stream.Read(receivedBuffer, 0, receivedBuffer.Length);
                    StringBuilder msg = new StringBuilder();
                    foreach (byte b in receivedBuffer)
                    {
                        if (b.Equals(0))
                        {
                            break;
                        }
                        else
                        {
                            msg.Append(Convert.ToChar(b).ToString());
                        }
                    }
                    Console.WriteLine(msg.ToString());
                    Message m = JsonConvert.DeserializeObject<Message>(msg.ToString());
                    callback(m);
                }
            }
        }
    }
}
