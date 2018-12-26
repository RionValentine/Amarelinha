using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class Titulo
{
    public string nomeTitulo;
    public int idChamp;
    public TYPE_TITULO typeClass;
    public Sprite iconTituloB;
    public int LevelTitulo;
    public string Descrição;

    public int[] poderes;
    public string[] poderesTitulo;

    public int habilidades;
    public string habilidadesTitulo;

    public int danoFisicoBase;
    public int danoMagicoBase;
    public int defesaFisicaBase;
    public int defesaMagicaBase;
    public int criticoBase;
    public int tempoRecargaBase;
    public int velocidadeMovimentoBase;
    public int velocidadeAtaqueBase;

    public int danoFisicoUp;
    public int danoMagicoUp;
    public int defesaFisicaUp;
    public int defesaMagicaUp;
    public int criticoUp;
    public int tempoRecargaUp;
    public int velocidadeMovimentoUp;
    public int velocidadeAtaqueUp;


    public float ataqueRange;


    public float PontosVida;
    public float PontosEssencia;

}


    [System.Serializable]
public enum TYPE_TITULO
{    
    NULL,
    TANK,
    TANK_WARRIOR,
    TANK_MAGE,
    TANK_SUPPORT,
    TANK_ASSASSIN,
    TANK_GUNNER,
    WARRIOR,
    WARRIOR_TANK,
    WARRIOR_MAGE,
    WARRIOR_SUPPORT,
    WARRIOR_ASSASSIN,
    WARRIOR_GUNNER,
    WARRIOR_HUNTER,
    MAGE,
    MAGE_TANK,
    MAGE_WARRIOR,
    MAGE_SUPPORT,
    MAGE_ASSASSIN,
    MAGE_GUNNER,
    SUPPORT,
    SUPPORT_TANK,
    SUPPORT_WARRIOR,
    SUPPORT_MAGE,
    SUPPORT_ASSASSIN,
    SUPPORT_GUNNER,
    SUPPORT_HUNTER,
    ASSASSIN,
    ASSASSIN_TANK,
    ASSASSIN_WARRIOR,
    ASSASSIN_MAGE,
    ASSASSIN_SUPPORT,
    ASSASSIN_GUNNER,
    ASSASSIN_HUNTER,
    GUNNER,
    GUNNER_TANK,
    GUNNER_WARRIOR,
    GUNNER_MAGE,
    GUNNER_SUPPORT,
    GUNNER_ASSASSIN,
    GUNNER_HUNTER,
    HUNTER,
    HUNTER_TANK,
    HUNTER_WARRIOR,
    HUNTER_MAGE,
    HUNTER_SUPPORT,
    HUNTER_ASSASSIN,
    HUNTER_GUNNER,
}
    public class TituloBaseInfo : MonoBehaviour {


    public Titulo[] titulos;
    public PoderesBaseInfo poderesBaseInfo;
    public HabilidadesBaseInfo habilidadesBaseInfo;
    public InventarioController auxInventario;

    // Use this for initialization
    void Start ()
    {
        habilidadesBaseInfo = GetComponent<HabilidadesBaseInfo>();
        poderesBaseInfo = GetComponent<PoderesBaseInfo>();
        auxInventario = GetComponent<InventarioController>();

    }
	
	// Update is called once per frame
	void Update ()
    {
        ListTitulo();
        PoderesResquest();
        HabilidadesResquest();


    }


    public void ListTitulo()
    {
        for (int i = 0; i < titulos.Length; i++)
        {
            titulos[i].nomeTitulo = "Terry";
            titulos[i].idChamp =i;
            titulos[i].typeClass = TYPE_TITULO.WARRIOR;
           
            titulos[i].Descrição = "";
                        
            titulos[i].poderes = new int[4];
            titulos[i].poderesTitulo = new string[4];

            titulos[i].poderesTitulo[0] = "";
            titulos[i].poderesTitulo[1] = "";
            titulos[i].poderesTitulo[2] = "";
            titulos[i].poderesTitulo[3] = "";

            titulos[i].habilidadesTitulo = "";

            titulos[i].danoFisicoBase = 0;
            titulos[i].danoMagicoBase =0;
            titulos[i].defesaFisicaBase =0;
            titulos[i].defesaMagicaBase =0;
            titulos[i].criticoBase =0;
            titulos[i].tempoRecargaBase =0;
            titulos[i].velocidadeMovimentoBase =0;
            titulos[i].velocidadeAtaqueBase =0;

            titulos[i].danoFisicoUp =0;
            titulos[i].danoMagicoUp =0;
            titulos[i].defesaFisicaUp =0;
            titulos[i].defesaMagicaUp =0;
            titulos[i].criticoUp =0;
            titulos[i].tempoRecargaUp =0;
            titulos[i]. velocidadeMovimentoUp =0;
            titulos[i].velocidadeAtaqueUp =0;

            titulos[i].PontosVida = 0;
            titulos[i].PontosEssencia = 0;

    i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////

            titulos[i].nomeTitulo = "";
            titulos[i].idChamp = i;
            titulos[i].typeClass = TYPE_TITULO.NULL;

            titulos[i].Descrição = "";

            titulos[i].poderes = new int[4];
            titulos[i].poderesTitulo = new string[4];

            titulos[i].poderesTitulo[0] = "";
            titulos[i].poderesTitulo[1] = "";
            titulos[i].poderesTitulo[2] = "";
            titulos[i].poderesTitulo[3] = "";

            titulos[i].habilidadesTitulo = "";

            titulos[i].danoFisicoBase = 0;
            titulos[i].danoMagicoBase = 0;
            titulos[i].defesaFisicaBase = 0;
            titulos[i].defesaMagicaBase = 0;
            titulos[i].criticoBase = 0;
            titulos[i].tempoRecargaBase = 0;
            titulos[i].velocidadeMovimentoBase = 0;
            titulos[i].velocidadeAtaqueBase = 0;

            titulos[i].danoFisicoUp = 0;
            titulos[i].danoMagicoUp = 0;
            titulos[i].defesaFisicaUp = 0;
            titulos[i].defesaMagicaUp = 0;
            titulos[i].criticoUp = 0;
            titulos[i].tempoRecargaUp = 0;
            titulos[i].velocidadeMovimentoUp = 0;
            titulos[i].velocidadeAtaqueUp = 0;

            titulos[i].PontosVida = 0;
            titulos[i].PontosEssencia = 0;

            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////

        }
    }



    public void PoderesResquest()
    {
        for (int t = 0; t < titulos.Length; t++)
        {
            for (int p = 0; p < titulos[t].poderesTitulo.Length; p++)
            {                
                for (int b = 0; b < poderesBaseInfo.Poderes.Length; b++)
                {                   
                    if (poderesBaseInfo.Poderes[b].poderNome == titulos[t].poderesTitulo[p])
                    {
                        titulos[t].poderes[p] = poderesBaseInfo.Poderes[b].indice;           
                    }
                }
            }
        }
     }


    public void HabilidadesResquest()
    {
        for (int t = 0; t < titulos.Length; t++)
        {     
 
                for (int b = 0; b < habilidadesBaseInfo.habilidades.Length; b++)
                {
                    if (habilidadesBaseInfo.habilidades[b].HabilidadeNome == titulos[t].habilidadesTitulo)
                    {
                        titulos[t].habilidades = habilidadesBaseInfo.habilidades[b].indice;
                    }
                }
            
        }
    }





}
