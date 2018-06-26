using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhotonConnect : MonoBehaviour
{

	public string versionName = "0.1";

	public GameObject mainMenu;

	public Text status;

	// Monobehaviour functions
	#region
	private void Start()
	{
		connectToPhoton();
	}
	#endregion

	// Photon Network Functions
	#region
	private void connectToPhoton()
	{
		PhotonNetwork.ConnectUsingSettings(versionName);

		Debug.Log("Connecting ti photon...");

	}

	private void OnConnectedToMaster()
	{
		PhotonNetwork.JoinLobby(TypedLobby.Default);

		Debug.Log("We are connected to master");
	}

	private void OnJoinedLobby()
	{
		Debug.Log("On Joined Lobby");

		status.text = "Connected!";
	}

	private void OnDisconnectedFromPhoton()
	{
		Debug.Log("Disconnected from photon");

		status.text = "Disconnected!";
	}

	private void OnFailedToConnectToPhoton()
	{
		Debug.Log("Failed to connecto to photon");

		status.text = "Failed to connect!";
	}
	#endregion


}
