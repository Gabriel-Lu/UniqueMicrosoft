using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleAppSocketClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //创建实例
            Socket socketClient = new Socket(SocketType.Stream, ProtocolType.Tcp);
            //这儿填你服务器ip
            IPAddress ip = IPAddress.Parse("192.168.43.70");
            IPEndPoint point = new IPEndPoint(ip, 2018);
            //进行连接
            socketClient.Connect(point);

            //不停的接收服务器端发送的消息
            Thread thread = new Thread(Recive);
            thread.IsBackground = true;
            thread.Start(socketClient);

            //不停的给服务器发送数据
            int i = 0;
            while (true)
            {
                Random r = new Random();
                
                
                i++;
                var buffter = Encoding.UTF8.GetBytes("{\"Humi\":\"" + r.Next(2, 80) + "\",\"Temp\":\"" + r.Next(50, 100) + "\",\"Light\":\"" + r.Next(80, 300) + "\"  }");
                var temp = socketClient.Send(buffter);
                Debug.WriteLine(buffter);
                Console.WriteLine("已发送:"+buffter);
                Thread.Sleep(1000);
            }
        }


        /// <summary>
        /// 接收消息
        /// </summary>
        /// <param name="o"></param>
        static void Recive(object o)
        {
            var send = o as Socket;
            while (true)
            {
                //获取发送过来的消息
                byte[] buffer = new byte[1024 * 1024 * 2];
                var effective = send.Receive(buffer);
                if (effective == 0)
                {
                    break;
                }
                var str = Encoding.UTF8.GetString(buffer, 0, effective);
                Console.WriteLine(str);
            }
        }
    }   

}
