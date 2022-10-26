using System.Net.Sockets;
using System.Text;

/*
 * 参考　https://t19488sns.com/socket/370/
 * 
 */

namespace MauiCtrl
{

    public class TcpCtrl
    {
	//**********************************************************************************
        public TcpClient connectTcp(string ipAdd, int port)
        {
            return new TcpClient(ipAdd, port);
        }

	//**********************************************************************************
        public NetworkStream getNetworkStream(TcpClient tcp)
        {
            return tcp.GetStream();
        }

        //**********************************************************************************
        public void Send_TCP(NetworkStream ns, string send_mess)
        {
            ns.ReadTimeout = 1000;
            ns.WriteTimeout = 1000;
            Encoding enc = Encoding.UTF8;
            byte[] sendBytes = enc.GetBytes(send_mess);
            ns.Write(sendBytes, 0, sendBytes.Length);
        }

	//**********************************************************************************
        public string Recieve_TCP(NetworkStream ns)
        {
            ns.ReadTimeout = 5000;
            ns.WriteTimeout = 5000;
            Encoding enc = Encoding.UTF8;
            string rcv = "";

            using (MemoryStream ms = new MemoryStream())
            {
                byte[] resBytes = new byte[1024];
                int resSize = 0;

                resSize = ns.Read(resBytes, 0, resBytes.Length);

                if (resSize == 0)
                    Console.WriteLine("サーバーが切断しました。");
                else
                {
                    ms.Write(resBytes, 0, resSize);

                    rcv = enc.GetString(ms.GetBuffer(), 0, (int)ms.Length);
                    ms.Close();
                }
            }
            return rcv;
        }
    }
}
