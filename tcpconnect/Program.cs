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
		}
	}
}
