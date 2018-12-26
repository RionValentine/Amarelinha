using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



[System.Serializable]
public class Poder
{
    public string poderNome;
    public TYPE_PODER typoPoder;
    public SUB_TYPE_PODER subTypePoder;
    public int custoCompra;
    public int custoMana;
    public int custoFadiga;

    public int AcoesCusto;

    public GameObject PrefabPoder;
    public GameObject posicaoInstanciar;
    public string animationName;

    public int indice;

    public Sprite iconBase;

    public int valorMercado;

    

    public int level;
    public float duração;

    public int forca;
    public int velocidade;
    public int destreza;
    public int resistencia;
    public int inteligencia;
    public int sabedoria;
    public int autoControle;
    public int carisma;

    public int aumentoDanoFisico;
    public int aumentoDanoMagico;
    public int aumentoDefesaFisica;
    public int aumentoDefesaMagica;

    public int danoFisico;
    public int danoMagico;
    public int defesaFisica;
    public int defesaMagica;

    public int acao;
    public int reacao;

    public int vitalidade;
    public int mana;
    public int fadiga;
    public int attackRate;

    public float LifeValue;
    public float ManaValue;
    public float FadigaValue;

    public float movimentoExtra;

    public string Descricao;

    public bool curaStatus;
    public bool causaStatus;

    public bool precisadeItem;
    public string nomeItem;
    public int indiceItem;

    public bool CFogo;
    public bool CAgua;
    public bool CVento;
    public bool CTerra;
    public bool CTempo;
    public bool CEspaco;
    public bool CLuz;
    public bool CTrevas;
    public bool CVida;
    public bool CMateria;
    public bool CMente;
    public bool CAlma;

}


[System.Serializable]
public enum TYPE_PODER
{
    NULL,
    PODER,
    MAGIC
}

[System.Serializable]
public enum SUB_TYPE_PODER
{
  ATAQUE,
  DEFESA,
  BUFF,
  INVOCAÇÃO,
  CURA     
}


public class PoderesBaseInfo : MonoBehaviour
{
    public Poder[] Poderes;
    public Vector3 posicaoInstanciar;
    public GameObject  PoderesInstanciado;

    // Use this for initialization
    void Start()
    {
        ListadePoderes();
    }

    // Update is called once per frame
    void Update()
    {

    }

   public GameObject InstanciarPrefabCirculo( Transform Posicao, int indice) 
{
        for (int i = 0; i < Poderes.Length; i++)
        {
		    if(Poderes[i].indice == indice)
		    {
                    posicaoInstanciar = Poderes[i].PrefabPoder.transform.position;
                    PoderesInstanciado = Instantiate(Poderes[i].PrefabPoder,
                    Posicao.transform.position,
                    transform.rotation);
		            return (Poderes[i].PrefabPoder);
		    }
	    }
        return null;
}

    public void ListadePoderes()
    {
        for (int i = 0; i < Poderes.Length; i++)
        {

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.MAGIC;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.ATAQUE;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Absorção de Vitalidade";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Essa habilidade causa dano a um alvo e cura seu conjurador uma porcentagem do mesmo. Dano Base= (10 + Autocontrole + C.Trevas) Distancia Total = AutoControle + C.Espaço ";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.PODER;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.BUFF;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Acrobata";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Amplia as habilidades acrobatas consideravelmente. Adicionando +10 nos testes de Esquiva  por 1d4 + AutoControle em Ataques";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.PODER;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.BUFF;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Agilidade";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Da um impulso pra frente e aumenta o movimento em +5 metros e adicionando Bonus de Velocidade no dano.";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.PODER;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.BUFF;
            Poderes[i].indice = i; 
            Poderes[i].poderNome = "Agilidade Sobrenatural";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Adiciona bônus de 1d6+5 nos testes de Ataque e Esquiva por 1d4 + Auto Controle/2 em Ataques";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.PODER;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.INVOCAÇÃO;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Animar Plantas";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Usa sementes para criar uma planta magicamente que ataca quem estiver perto.";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.PODER;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.BUFF;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Aprimoramento Desarmado";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Aumenta a dificuldade dos ataques Desarmados em 1d6+10 ";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.PODER;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.BUFF;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Aprisionamento Infernal";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Dificulta o movimento de uma certa área durante alguns turnos.";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.PODER;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.ATAQUE;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Apunhalada Mortal";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Desfere um ataque poderoso usando Adagas e Facas. Causando 1d6 + 10 + Força";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.MAGIC;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.BUFF;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Arma Flamejante";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Encanta a arma com fogo por algumas rodadas, Adicionando 5 + C.Fogo no dano com a arma";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.PODER;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.BUFF;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Arma Sagrada";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Aumenta o dano por rodadas e Adiciona status sagrado a sua arma acertando criaturas incorpóreas";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.PODER;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.INVOCAÇÃO;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Armadilha";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Coloca uma armadilha no chão que prende o inimigo e causa dano de 1d6 + 10";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.PODER;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.ATAQUE;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Ataque Devastador";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Desfere um ataque poderoso usando armas de haste. Causando 1d6 + 5 + Força em area";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.PODER;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.BUFF;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Ataque Potente";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Desfere um tipo poderoso com Espada aumentando seu dano. Causando 1d6 + 10 + Força";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.PODER;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.BUFF;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Ataque Veloz";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Aumenta a quantidade de ação em 1d4+1";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.PODER;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.BUFF;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Atordoamento com Escudo";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Desfere um ataque poderoso como escudo causando 1d4+5 + Força de dano + Dureza do Escudo e tem chances de deixar seu alvo desnorteado tendo 1d6 + 1 como redutor nos testes de esquiva.";
            i++;


            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.PODER;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.BUFF;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Aumento de Esquiva";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Aumenta o bônus dos testes de esquiva";
            i++;
            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.MAGIC;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.BUFF;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Aumento de Dano";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Aumenta o dano de um alvo Físico. em 1d6+5 por 1d4+1 rodada";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.PODER;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.BUFF;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Aura de Defesa";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Aumenta o IPF e IPM consideravelmente por 1d4+1 em rodadas.";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.MAGIC;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.CURA;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Aura Divina";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Retira status negativo do tipo envenenamento, Silencio, Restrição e Sangramento de um personagem.";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.MAGIC;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.CURA;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Aura Flamejante";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Queima inimigos a volta do personagem.";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.PODER;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.ATAQUE;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Boleadeira";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Joga Boleadeiras em um alvo causando 1d4+5+Destreza de dano e retira -1d4+1 de movimento do alvo";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.PODER;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.BUFF;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Campo Negro";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Cria uma área de defesa que absorve 1d4+5 +C.Trevas de dano magico e físico e causa o mesmo em dano ao inimigo  ";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.PODER;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.ATAQUE;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Chamado Espectral";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Cria uma aura de energia negativa a sua volta, que reduz os testes de ataque do inimigo em 1d4+5 + C.Trevas e causa o mesmo em dano por rodada.";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.PODER;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.BUFF;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Codigo de Honra";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Adiciona +10 no dano dFisico e Magico, por 1d4+1 Rodada";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.MAGIC;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.BUFF;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Concentração";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Concede bônus de 1d4+10 nos testes de concentração e vontade para nao perder uma conjuração ao receber dano";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.MAGIC;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.INVOCAÇÃO;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Constrição";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Cria uma vegetação em uma área que reduz o movimento de quem estiver nela em 1d4+1 e causa dano de 1d4+5+Autocontrole+C.Planta.";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.MAGIC;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.BUFF;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Consumir";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Consome um corpo próximo para aumentar suas habilidades e restaurar sua Vida, para cada corpo consumido aumente em +10% o dano e vida maxima, no maximo de 10 corpos dura 1d4+1 Rodada";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.PODER;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.BUFF;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Coração de Leão";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Aumenta a resistência em 1d4+5 contra poderes que causam status negativos. dura 1d4+1+AutoControle em rodadas";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.PODER;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.BUFF;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Corpo de Ferro";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Aumenta a Absorção de dano Físico. em 1d6+10, por 1d4+1+Autocontrole/2 em rodadas";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.MAGIC;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.CURA;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Cura de Batalha";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Restaura 1d4+10+AutoControle+C.Primordio em pontos de vida do alvo";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.PODER;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.BUFF;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Defesa Armada";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Aumenta o bloqueio com a arma e a dureza dela. 1d4+10 nos teste de Aparar do personagem";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.PODER;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.ATAQUE;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Disparo Mortal";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Arremessa 3 adagas por uma longa distância que causa 1d6+ 10+ Destreza e coloca uma marca no alvo.";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.PODER;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.ATAQUE;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Dreno Macabro";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Desfere dano a um alvo e parte desse dano regenera sua vida";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.MAGIC;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.BUFF;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Escudo Magico";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Aumenta o IPM seu e de um aliado";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.PODER;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.BUFF;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Escudo Reluzente";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Aumenta o bônus de bloqueio com escudo e causa dano caso seja bem sucedido em Bloquear o ataque inimigo.";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.MAGIC;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.ATAQUE;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Esfera Negra";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Lança uma esfera negra acertando todos em seu caminho Causando 1d4+5+AutoControle+C.Trevas de dano em Linha reta de AutoControle+C.Espaço em Metros";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.PODER;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.BUFF;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Evasão";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Aumenta os testes de esquiva do personagem em 1d4+10 por 1d4+1 Rodada";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.MAGIC;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.ATAQUE;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Explosão de Terra";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Explode uma porção de terra jogando os alvos pra o ar e causando 1d6 + 10 + AutoControle + C.Terra de dano em uma area de AutoControle +C.Espaço em Metros Quadrados.";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.PODER;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.ATAQUE;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Faca Voadora";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Arremessa facas com bastante velocidade e precisão aumentando o dano e o alcance.";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.PODER;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.ATAQUE;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Flecha Explosiva";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Dispara uma flecha que ao contato explode causando mais dano ao alvo e a inimigos adjacentes.";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.PODER;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.ATAQUE;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Flecha Incapacitante";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Dispara uma flecha que além de dar dano adiciona redutor na próxima jogar de esquiva ou ataque do alvo";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.PODER;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.BUFF;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Foco em Ki";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Aumenta o dano gerado utilizando o Ki em 1d4+10+AutoControle por 1d4+1 Rodada.";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.PODER;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.BUFF;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Fumaça Shinobi";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Cria uma área de fumaça que deixa o ninja furtivo e aumenta seu movimento dentro dela. todo ataque basico do personagem e considerado ataque Furtivo adicionando 1d6+10 de dano enquanto tiver dentro da fumaça";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.PODER;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.BUFF;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Furia Ancestral";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Ativa o modo de fúria aumentando os atributos físicos. em +5 por 1d4+1+Constituição/2 em Roradas";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.PODER;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.BUFF;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Granada de Impacto";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Aumenta o campo de explosão e o dano causado de uma granada comum.";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.PODER;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.ATAQUE;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Grande Impacto";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Desfere um ataque poderoso com armas de Impacto (Massas e martelo)";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.PODER;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.BUFF;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Grito de Guerra";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Aumenta o dono do personagem e a proteção física. em 1d4+10 por 1d4+1 rodada";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.PODER;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.BUFF;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Instante Vicioso";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Aumenta as chances de crítico em um ataque. +1";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.PODER;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.BUFF;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Instinto de Caçador";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Aumenta em 1d4+5 os teste de reflexos e os testes de ataque.";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.PODER;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.ATAQUE;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Investida Implacavel";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Avança para cima de um determinado alvo. causando dano em todos no caminho";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.MAGIC;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.INVOCAÇÃO;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Invocar Criatura I";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Invoca uma criatura que ajuda em combate e em pequenos afazeres";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.MAGIC;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.INVOCAÇÃO;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Invocar Mortos Vivos";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Pode controlar um cadáver próximo";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.PODER;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.ATAQUE;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Lamina da Penitencia";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Desfere um ataque poderoso e agravado. que nao permite que o alvo se cure passivamente";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.PODER;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.BUFF;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Lamina da Sabedoria";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Aumenta a dificuldade e o dano. em 1d4+5";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.PODER;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.BUFF;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Lamina Veloz";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Aumenta a velocidade dos ataques os deixando difíceis de ser defendidos. 1d4+10 na dificuldade dos ataques";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.MAGIC;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.ATAQUE;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Lança de Raio";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Dispara uma lança em forma de raio Sagrado sendo mais eficaz e seres com a tendência contraria do conjurador.";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.MAGIC;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.ATAQUE;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Lança de Ossos";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Conjura uma lança feita de ossos causado dano em um alvo caso tenha algum corpo próximo o dano e maior";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.PODER;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.BUFF;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Magia Rapida";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Aumenta a dificuldade de uma magia por algumas rodadas.";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.PODER;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.BUFF;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Maquina de Guerra";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Pode conjurar uma máquina fixa que o auxilia em combate disparando tiros de energia.";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.PODER;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.BUFF;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Misseis Magicos";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Dispara projeteis de energia difíceis de serem esquivados.";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.PODER;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.ATAQUE;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Nuvem de Veneno";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Desfere ataque no chão que percorre um caminho causando dano a quem estiver por ele.";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.PODER;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.ATAQUE;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Onda de Impacto";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Desfere ataque no chão que percorre um caminho causando dano a quem estiver por ele.";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.PODER;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.BUFF;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Paralisia";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Faz com que o alvo perca uma quantidade de ações e reações durante alguns turnos.";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.PODER;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.BUFF;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Proteção Divina";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Aumenta a defesa e preteje contra ataque q ignoram a armadura.";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.PODER;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.BUFF;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Providencia Divina";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Consegue recuperar seus pontos de vida.";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.MAGIC;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.ATAQUE;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Provocar";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "O personagem chama a atenção de um ou mais alvos para se voltarem a ele.";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.MAGIC;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.ATAQUE;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Punho de Ferro";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Desfere um ataque poderoso com as mão nuas";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.MAGIC;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.ATAQUE;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Rajada de Energia";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Desfere uma rajada de energia que faz o algo perder IPM no próximo ataque.";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.MAGIC;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.ATAQUE;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Rajada de Gelo";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Dispara estacas de gelo em um alvo.";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.MAGIC;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.ATAQUE;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Rajada de Vento";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Desfere uma rajada de vendo que faz o algo recuar para trás ";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.MAGIC;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.ATAQUE;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Relampago Negro";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Um relâmpago negro cai do céu e acerta um alvo.";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.MAGIC;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.BUFF;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Restrição";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Retira Ação, reação e movimento do algo";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.PODER;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.ATAQUE;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Rugido de Batalha";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Aumenta os pontos de vida consideravelmente por algumas rodadas e não sofre sangramento.";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.PODER;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.ATAQUE;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Sangramento Demoniaco";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Além de desferir um grande ataque no seu oponente ele fica sangrando por alguma rodadas.";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.MAGIC;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.ATAQUE;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Sementes Explosivas";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Imbui uma quantidade de sementes que ao contato explodem";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.PODER;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.ATAQUE;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Shunpo";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Mesmo sem movimento o ninja consegue pular em cima do seu alvo e causar dano.";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.PODER;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.ATAQUE;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Tiro Fantasma";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "az um disparo que ao acertar um alvo uma segunda bala sai desse ponto e atinge um outro alvo próximo.";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.PODER;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.ATAQUE;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Tiro Ionico";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Desfere um tipo poderoso com arma de fogo aumentando seu dano.";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.PODER;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.ATAQUE;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Tiro Longo";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Aumente a distância que a flecha pode percorrer.";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.PODER;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.ATAQUE;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Tiro Potente";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Desfere um tipo poderoso com o arco aumentando seu dano.";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.PODER;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.ATAQUE;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Tiro Rapido";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Aumenta a dificuldade de seus ataques com arco";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.MAGIC;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.BUFF;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Transferencia de Dor";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Transfere parte do dano sofrido para um morto vivo invocador por você";
            i++;


            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.PODER;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.BUFF;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Trova de Asmita";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Chove estacas de gelo em uma área.";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.PODER;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.BUFF;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Trova de Fiura";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Anéis de fogos perseguem um algo.";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.PODER;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.BUFF;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Trova de Garnet";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Aumenta a defesa em todos que estiverem em uma área";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.PODER;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.BUFF;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Trova do Arauto";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Cura todos que estiverem dentro de uma área";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.PODER;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.BUFF;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Trova do Conhecimento";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Aumenta os valores de inteligência os afetados.";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.PODER;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.BUFF;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Trovão Negro";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Um relâmpago negro cai do céu e acerta um alvo.";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.MAGIC;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.ATAQUE;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "Vinhas Mortais";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "Vinhas saem do solo e perfuram o alvo ando grande dano e causando sangramento.";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.PODER;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.BUFF;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            Poderes[i].typoPoder = TYPE_PODER.PODER;
            Poderes[i].subTypePoder = SUB_TYPE_PODER.BUFF;
            Poderes[i].indice = i;
            Poderes[i].poderNome = "";
            Poderes[i].iconBase = Resources.Load<Sprite>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].PrefabPoder = Resources.Load<GameObject>("Poderes/" + Poderes[i].poderNome);
            Poderes[i].animationName = Poderes[i].poderNome;
            Poderes[i].valorMercado = 150;
            Poderes[i].Descricao = "";
           


            break;
        }
    }
 }
