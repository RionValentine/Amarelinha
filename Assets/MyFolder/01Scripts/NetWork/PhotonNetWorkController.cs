using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class PhotonNetWorkController : MonoBehaviourPunCallbacks {

    public LobbyGame auxLobbyGame;
    public GameObject CameraChar;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public override void OnConnected()
    {
        Debug.Log("OnConnected");
    }

    public override void OnConnectedToMaster()
    {
       
        Debug.Log("OnConnectedToMaster");
        PhotonNetwork.JoinLobby();
        auxLobbyGame.SalaOn();
    }


    public override void OnJoinedLobby()
    {
        Debug.Log("OnJoinedLobby");
    }

    public void BotaoCriarSala ()
    {
        if (auxLobbyGame.nameSala.text != "")
        {
            if (auxLobbyGame.nameSala.text.Length <= 20)
            {
                Debug.Log("OnCreatedRoom");
                string roomName = auxLobbyGame.nameSala.text;
                RoomOptions roomOption = new RoomOptions()
                {
                    IsOpen = true,
                    IsVisible = true,
                    MaxPlayers = 6
                };
                Debug.Log("Criou a sala");
                PhotonNetwork.JoinOrCreateRoom(roomName, roomOption, TypedLobby.Default);
            }
            else
            {
                Debug.Log("Nome excede o numero maximo de caracteres");
            }

        }
        else
        {
            Debug.Log(" Esta Vazio insira um nome pra Sala");
        }
    }


    public override void OnCreatedRoom()
    {
    
    }

    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        Debug.Log("OnJoinRandomFailed");
       string roomTemp = "Room " + Random.Range(1000, 10000);
       PhotonNetwork.CreateRoom(roomTemp);
    }

    public override void OnJoinedRoom()
    {
        Debug.Log("OnJoinedRoom");
        auxLobbyGame.SelectCharOn();
    }

    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        Debug.Log("OnPlayerEnteredRoom");
        //auxLobbyGame.SelectCharOn();
    }

    public void SelectChar(GameObject soldier)
    {
     PhotonNetwork.Instantiate(soldier.name, soldier.transform.position, soldier.transform.rotation, 0);
     PhotonNetwork.LoadLevel("Arena01");
    }

    public override void OnDisconnected(DisconnectCause cause)
    {
        Debug.Log("OnDisconnected: " + cause.ToString());
    }

    public void Disconectar()
    {
        Debug.Log("Disconectar");
        PhotonNetwork.Disconnect();
    }

    public void LoginGame()
    {
        if (auxLobbyGame.namelogin.text != "")
        {
            if (auxLobbyGame.namelogin.text.Length <= 15)
            {
                Debug.Log("LoginGame");
                PhotonNetwork.ConnectUsingSettings();
                PhotonNetwork.NickName = auxLobbyGame.namelogin.text;
            }
            else
            {
                Debug.Log("Nome excede o numero maximo de caracteres");
            }

        }
        else
        {
            Debug.Log(" Esta Vazio insira um nome pra o Personagem");
        }

    }

}
