using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;
using Photon.Pun.UtilityScripts;
using Hashtable = ExitGames.Client.Photon.Hashtable;
using UnityEngine.SceneManagement;

public class NetWorkController : MonoBehaviourPunCallbacks {

    public GameObject CameraChar;
    public GameObject selecaoChar;
    public GameObject salaPainel;
    public InputField playerName;
    public InputField salaName;
    public Text nickName;


    Hashtable gameMode = new Hashtable();
    public byte gameMaxPlayer = 6;
    string gameModeKey;
    // Use this for initialization
    void Start ()
    {
        DontDestroyOnLoad(this.gameObject);
        //selecaoChar.gameObject.SetActive(false);
        // salaPainel.gameObject.SetActive(false);
       // PhotonNetwork.ConnectUsingSettings();        

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void login()
    {
        //
        if (playerName.text != "")
        {
            if(playerName.text.Length <= 10)
            {
                nickName.text = playerName.text;
                PhotonNetwork.NickName = playerName.text;
               // PhotonNetwork.ConnectUsingSettings();
                BuscarSalaPainel();
            }
            else
            {
                Debug.Log("Nome excede o numero maximo de caracteres");
            }

        }
        else
        {
            Debug.Log("Nome muito grande");
        }
    }

    public void BuscarSalaPainel()
    {
        salaPainel.SetActive(true);
    }

    /// ////////////////////////////////////////////////////////////////////
   
    public override void OnConnected()
    {
        Debug.Log("OnConnected");
    }
    
    public override void OnConnectedToMaster()
    {
        Debug.Log("OnConnectedToMaster");
        Debug.Log("Server: " + PhotonNetwork.CloudRegion + "  Ping " + PhotonNetwork.GetPing());
       // PhotonNetwork.JoinLobby();
    }


    public override void OnJoinedLobby()
    {
        Debug.Log("Room Name: " + PhotonNetwork.CurrentRoom.Name);
        Debug.Log("Room Name: " + PhotonNetwork.CurrentRoom.PlayerCount + " / " + PhotonNetwork.CurrentRoom.MaxPlayers);
        Debug.Log("OnJoinedLobby");
        
        //PhotonNetwork.JoinRandomRoom();
    }

    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        string roomTemp = "Room " + Random.Range(1000,10000);
        PhotonNetwork.CreateRoom(roomTemp);
    }

    public override void OnJoinedRoom()
    {     
        Debug.Log("OnJoinedRoom");
        Debug.Log("Room Name: " + PhotonNetwork.CurrentRoom.Name);
        Debug.Log("Room Name: " + PhotonNetwork.CurrentRoom.PlayerCount +" / " +PhotonNetwork.CurrentRoom.MaxPlayers );
    }

    public override void OnDisconnected(DisconnectCause cause)
    {
        Debug.Log("OnDisconnected" + cause);
    }


    public void BuscarPlayer()
    {

    }

    public void BotaoCriarSala()
    {
        if(salaName.text != "")
        {
            if(salaName.text.Length <= 10)
            {

                string nomeSalaTemp = salaName.text;
                RoomOptions roomOptions = new RoomOptions() { MaxPlayers = 6 };
                PhotonNetwork.JoinOrCreateRoom(nomeSalaTemp, roomOptions, TypedLobby.Default);

                Debug.Log("Criou a sala");

                selecaoChar.gameObject.SetActive(true);
                            
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


    public void SelectChar(GameObject soldier)
    {
       GameObject Player = PhotonNetwork.Instantiate(soldier.name, soldier.transform.position, soldier.transform.rotation, 0);
       SceneManager.LoadScene("Arena01");
    }
}