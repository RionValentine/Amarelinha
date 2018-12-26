using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LobbyGame : MonoBehaviour {

    public GameObject painelLogin;
    public GameObject painelLobby;
    public GameObject painelSelecaoChar;

    public InputField nameSala;
    public InputField namelogin;
    public Text nickName;
    public Text statusGame;




    // Use this for initialization
    void Start ()
    {
        painelLogin.gameObject.SetActive(true);
        painelLobby.gameObject.SetActive(false);
        painelSelecaoChar.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update ()
    {
        //nickName.text = Photon.Pun.PhotonNetwork.NetworkClientState.ToString();
        //Debug.Log("Status da Conecção: " + Photon.Pun.PhotonNetwork.NetworkClientState);
    }


    public void LoginOn_Disconect()
    {
        painelLogin.gameObject.SetActive(true);
        painelLobby.gameObject.SetActive(false);
        painelSelecaoChar.gameObject.SetActive(false);
    }

    public void SalaOn()
    {
        nickName.text = namelogin.text;
        painelLogin.gameObject.SetActive(false);
        painelLobby.gameObject.SetActive(true);
        painelSelecaoChar.gameObject.SetActive(false);
    }

    public void SelectCharOn()
    {
        painelLogin.gameObject.SetActive(false);
        painelLobby.gameObject.SetActive(false);
        painelSelecaoChar.gameObject.SetActive(true);
    }

}
