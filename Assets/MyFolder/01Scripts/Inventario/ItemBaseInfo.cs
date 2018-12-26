using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



[System.Serializable]
public class Item
{
    public string itemName;
    public TYPE_ITEM typeItem;

    public int indice;
    public int potencial;       
    public Sprite iconBase;
    public bool isStackable;

    public int valorMercado;

    public int amountMax;
    public int amountCurr;

    public float PontosVida;
    public float PontosEssencia;

    public float lifeValue;
    public float manaValue;

    public int danoFisicoBase;
    public int danoMagicoBase;
    public int defesaFisicaBase;
    public int defesaMagicaBase;
    public int criticoBase;
    public int tempoRecargaBase;
    public int velocidadeMovimentoBase;
    public int velocidadeAtaqueBase;

	public string Descricao { get; set; }

    public bool curaStatus;
    public bool causaStatus;

    public bool lentidao;
    public bool sangramento;

    public float coolDownCur;
    public float coolDownTotal;
    public float duracao;

    public string[] itensCraftName;
    public int[] itensCraftIndice;

    
}

[System.Serializable]
public enum TYPE_ITEM
{
    NULL,
    CONSUMIBLE,
    ATIVAVEL
}


public abstract class ItemBaseInfo : MonoBehaviour
{
   // public Item[] itens;



    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
		
    }



}
