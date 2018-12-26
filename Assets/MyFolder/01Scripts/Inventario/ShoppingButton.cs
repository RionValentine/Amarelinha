using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShoppingButton : MonoBehaviour
{
    public string nomeItem;
    public int indiceItem;

    public int[] potencia1;
    public int[] potencia2;
    public int[] potencia3;

    public BancoDeDadosItens auxBancoDeDadosItens;
    public ShoppingSystem auxShoppingSystem;
    public CharBaseStatus auxCharBaseStatus;


    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void DiscricaoItem()
    {
        if(auxBancoDeDadosItens.Itens[indiceItem].potencial==0)
        {

        }
    }

    public void IndiceItemAtual()
    {
        auxShoppingSystem.DesenhaFormula(indiceItem);
    }
}
