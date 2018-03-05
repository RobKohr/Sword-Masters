using System.Collections;
using UnityEngine;
using SocketIO;

public class Network : MonoBehaviour
{
	private SocketIOComponent socket;
	public GameObject playerPrefab;
	public void Start() 
	{
		GameObject go = GameObject.Find("Network");
		socket = go.GetComponent<SocketIOComponent>();

		socket.On("open", OnConnected);
		socket.On("spawn", OnSpawn);
		/*
		socket.On("boop", TestBoop);
		socket.On("error", TestError);
		socket.On("close", TestClose);
		*/
		//StartCoroutine("BeepBoop");
	}
	void OnConnected(SocketIOEvent e)
	{
		Debug.Log("connected");
		socket.Emit("move");
	}

	void OnSpawn(SocketIOEvent e)
	{
		Debug.Log("Spawn");
		Instantiate (playerPrefab);

		Debug.Log("created!");
	}
}
