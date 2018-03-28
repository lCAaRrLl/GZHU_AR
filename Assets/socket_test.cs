using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net;
using System.Net.Sockets;

public class socket_test : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
        System.Console.WriteLine("Client Running ...");
        TcpClient client = new TcpClient();
        try
        {
            client.Connect("localhost", 9999);      // 与服务器连接
        }
        catch (System.Exception ex)
        {
            System.Console.WriteLine(ex.Message);
            Debug.Log("error");
            return;
        }
        // 打印连接到的服务端信息
        System.Console.WriteLine("Server Connected！{0} --> {1}",
            client.Client.LocalEndPoint, client.Client.RemoteEndPoint);

        // 按Q退出
    }

    // Update is called once per frame
    void Update () {
		
	}
}
class Client
{
    static void Main(string[] args)
    {

        System.Console.WriteLine("Client Running ...");
        TcpClient client = new TcpClient();
        try
        {
            client.Connect("localhost", 8500);      // 与服务器连接
        }
        catch (System.Exception ex)
        {
            System.Console.WriteLine(ex.Message);
            return;
        }
        // 打印连接到的服务端信息
        System.Console.WriteLine("Server Connected！{0} --> {1}",
            client.Client.LocalEndPoint, client.Client.RemoteEndPoint);

        // 按Q退出
    }
}