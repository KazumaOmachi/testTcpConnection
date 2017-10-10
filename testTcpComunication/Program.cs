using System;

namespace testTcpComunication
{
	class MainClass
	{
		public static System.Net.Sockets.TcpListener listener;
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			string ipString = "127.0.0.1";
			System.Net.IPAddress ipAdd = System.Net.IPAddress.Parse(ipString);

			//Listenするポート番号
			int port = 2001;

			//TcpListenerオブジェクトを作成する
			listener = new System.Net.Sockets.TcpListener(ipAdd, port);

			//Listenを開始する
			listener.Start();

			System.Threading.ThreadPool.QueueUserWorkItem(acceptclient);

			while (true) { }

		}

		public static void acceptclient(object e)
		{
			System.Net.Sockets.TcpClient client = listener.AcceptTcpClient();
			System.Threading.ThreadPool.QueueUserWorkItem(acceptclient);

			System.Net.Sockets.NetworkStream ns = client.GetStream();
			Console.WriteLine("connect");

			byte[] readBytes = new byte[4];

			int resSize = ns.Read(readBytes, 0, readBytes.Length);
			int i = BitConverter.ToInt32(readBytes, 0);

			Console.WriteLine(readBytes + " : " + i);
		}
	}
}
