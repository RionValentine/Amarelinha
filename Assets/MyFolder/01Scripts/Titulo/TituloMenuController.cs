using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TituloMenuController : MonoBehaviour {

    public bool loadOn;
    public bool OptionOn;
    public bool loginOn;
    public bool salaOn;

    public GameObject inicioPainel;
    public GameObject loadPainel;
    public GameObject OptionPainel;
    public GameObject loginPainel;
    public GameObject salaPainel;
    public GameObject charpainel;

    // Use this for initialization
    void Start () {
        loadPainel.SetActive(false);
        OptionPainel.SetActive(false);
        loginPainel.SetActive(false);
        salaPainel.SetActive(false);
        charpainel.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ControllerMenu()
    {
        
    }

    public void LoginOn()
    {
        loginPainel.SetActive(true);
        inicioPainel.SetActive(false);
    }



    public void VoltarOn()
    {
        inicioPainel.SetActive(true);
        loadPainel.SetActive(false);
        OptionPainel.SetActive(false);
        loginPainel.SetActive(false);
        salaPainel.SetActive(false);
        charpainel.SetActive(false);
    }

}
