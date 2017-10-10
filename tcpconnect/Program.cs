using System;

namespace tcpconnect
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			//サーバーのIPアドレス（または、ホスト名）とポート番号
			string ipOrHost = "127.0.0.1";
			//string ipOrHost = "localhost";
			int port = 2001;

			//TcpClientを作成し、サーバーと接続する
			System.Net.Sockets.TcpClient tcp = new System.Net.Sockets.TcpClient(ipOrHost, port);
			System.Net.Sockets.NetworkStream ns = tcp.GetStream();

			//string sendMsg = "hohohohohoho";
			//byte[] sendBytes = enc.GetBytes(sendMsg + '\n');

			byte[]  sendBytes = BitConverter.GetBytes(5);
			System.Text.Encoding enc = System.Text.Encoding.UTF8;
			ns.Write(sendBytes, 0, sendBytes.Length);
			Console.WriteLine(sendBytes);

		}
	}
}
