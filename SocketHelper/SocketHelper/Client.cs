using Newtonsoft.Json;
using System.Net.Sockets;
using System.Text;

namespace SocketHelper
{
    public class Client
    {
        string serverIP;
        int port;

        public Client(string serverIP, int port)
        {
            this.serverIP = serverIP;
            this.port = port;
        }

        public void SentMessage(Message message)
        {
            string msgJson = JsonConvert.SerializeObject(message);
            TcpClient client = new TcpClient(serverIP, port);

            int byteCount = Encoding.ASCII.GetByteCount(msgJson);

            byte[] sendData = new byte[byteCount];

            sendData = Encoding.ASCII.GetBytes(msgJson);

            NetworkStream stream = client.GetStream();

            stream.Write(sendData, 0, sendData.Length);

            stream.Close();
            client.Close();
        }
    }
}
