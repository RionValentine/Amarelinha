using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{

    public int indiceMenuAtual;

    public GameObject CanvasGeral;
    public GameObject contentSlotsInventario;
    public GameObject RectSlotsInventario;
    public GameObject RectSlotsShopping;
    public GameObject contentTituloSelect;
    public GameObject contentStatus;
    public GameObject contenteDescricaoTitulo;
    public GameObject contentTalentos;
    public GameObject contentOpcoes;
    public GameObject contentQuest;
    public GameObject contentCraft;
    public GameObject contenteMenuRapido;

    public bool exibMenu;


    public GameObject contentCraftArma;
    public GameObject contentCraftArmadura;
    public GameObject contentCraftAcessorio;
    public GameObject contentCraftItensGerais;

    // Use this for initialization
    void Start () {
        indiceMenuAtual = 0;
        AlocarItens();
    }
	
	// Update is called once per frame
	void Update ()
    {
        ChamarMenuButton();
        ButtonController();
        InputController();
    }

public void InputController()
    {
        if (Input.GetButtonDown("Start"))
        {
          
            indiceMenuAtual = 1;
            exibMenu = !exibMenu;
        }
    }

    public void ButtonController()
    {
        if (exibMenu)
        {
            CanvasGeral.gameObject.SetActive(true);
        }
        else
        {
            CanvasGeral.gameObject.SetActive(false);
        }
    }

    public void ChamarMenuButton()
    {
        if (indiceMenuAtual == 0)
        {
            contentSlotsInventario.SetActive(false);
           // contentTituloSelect.SetActive(false);
           // contentStatus.SetActive(false);
           // contentTalentos.SetActive(false);
           // contentCraft.SetActive(false);
           // contentQuest.SetActive(false);
           // contentOpcoes.SetActive(false);
        }

        if (indiceMenuAtual == 1)
        {
            contentSlotsInventario.SetActive(true);
        }
        else
        {
            contentSlotsInventario.SetActive(false);
        }

        if (indiceMenuAtual == 2)
        {
           // contentTituloSelect.SetActive(true);
        }
        else
        {
          //  contentTituloSelect.SetActive(false);
        }

        if (indiceMenuAtual == 3)
        {
          //  contentStatus.SetActive(true);
        }
        else
        {
          //  contentStatus.SetActive(false);
        }

        if (indiceMenuAtual == 4)
        {
            contentTalentos.SetActive(true);
        }
        else
        {
          //  contentTalentos.SetActive(false);
        }

        if (indiceMenuAtual == 5)
        {
         //   contentCraft.SetActive(true);
        }
        else
        {
         //   contentCraft.SetActive(false);
        }

        if (indiceMenuAtual == 6)
        {
          //  contentQuest.SetActive(true);
        }
        else
        {
          //  contentQuest.SetActive(false);
        }

        if (indiceMenuAtual == 7)
        {
          //  contentOpcoes.SetActive(true);
        }
        else
        {
          //  contentOpcoes.SetActive(false);
        }

    }

    public void AlocarItens()
    {
        CanvasGeral = GameObject.Find("FundoGeralShopping"); ;

        contentSlotsInventario = GameObject.Find("PainelInventario");
        RectSlotsInventario = GameObject.Find("RectSlotsInventario");
        RectSlotsShopping = GameObject.Find("RectSlotsShopping");
        contentTituloSelect = GameObject.Find("PainelTitulo");
        contentStatus = GameObject.Find("PainelStatus");
        contenteDescricaoTitulo = GameObject.Find("contenteDescricaoTitulo");
        contentTalentos = GameObject.Find("PainelTalentos");
        contentOpcoes = GameObject.Find("PainelOpcoes");
        contentQuest = GameObject.Find("PainelQuest");
        contentCraft = GameObject.Find("PainelCraft");
        contenteMenuRapido = GameObject.Find("PainelMenuRapido");

        contentCraftArma = GameObject.Find("contentCraftArma");
        contentCraftArmadura = GameObject.Find("contentCraftArmadura");
        contentCraftAcessorio = GameObject.Find("contentCraftAcessorio");
        contentCraftItensGerais = GameObject.Find("contentCraftItensGerais");
    }

    public void IndiceMenuButton(int IndiceButton)
    {
        indiceMenuAtual = IndiceButton;
    }
}
