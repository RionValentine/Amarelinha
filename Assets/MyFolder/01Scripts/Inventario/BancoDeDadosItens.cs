using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class BancoDeDadosItens : MonoBehaviour
{
	// public List<BasicStats> Item;
	public Item[] Itens;
	public int qntSlot;
	// Use this for initialization
	void Start ()
	{
		ListadeItens ();
//		for (int i = 0; i < Itens.Length; i++) {
//			Itens [i].indice = i;
//		}
	}

	// Update is called once per frame
	void Update ()
	{
		
	}

	public string RetornaNome (int indice)
	{
        
		for (int i = 0; i < Itens.Length; i++) {
			if (Itens [i].indice == indice) {
				indice = Itens [i].indice;
				return Itens [i].itemName;
			}

		}
		return null;
	}


	public string RetornaDescricao (int indice)
	{

		for (int i = 0; i < Itens.Length; i++) {
			if (Itens [i].indice == indice) {
				indice = Itens [i].indice;
				return Itens [i].Descricao;
			}

		}
		return null;
	}


	public int RetornaIndiceDoItem (int indice)
	{

		for (int i = 0; i < Itens.Length; i++) {
			if (Itens [i].indice == indice) {
				indice = Itens [i].indice;
				return Itens [i].indice;
			}

		}
		return -1;
	}


	public Sprite RetornaTexturaBase (int indice)
	{
        
		for (int i = 0; i < Itens.Length; i++) {
			if (Itens [i].indice == indice) {
				indice = Itens [i].indice;
				return Itens [i].iconBase;
			}               
            
		}
		return null;
	}

	public int RetornaMaxEstoque (int indice)
	{
		for (int i = 0; i < Itens.Length; i++) {
			if (Itens [i].indice == indice) {
				indice = Itens [i].indice;
				return Itens [i].amountMax;
			}

		}

		return 99;
	}


	public void ListadeItens()
	{		
		for (int i = 0; i < Itens.Length; i++) 
		{
				
/////////////////////////////////////////////////////////////////////////////////////////////////

				Itens[i].typeItem = TYPE_ITEM.CONSUMIBLE;
				Itens [i].indice = i;
				Itens [i].potencial = 0;
				Itens [i].itemName = "Poção Cura Simples"; 
				Itens [i].iconBase = Resources.Load <Sprite> ("ItensGerais/"+ Itens [i].itemName);
				Itens [i].valorMercado = 50;
				Itens [i].amountMax = 5;
				Itens [i].lifeValue = 250;
                Itens[i].duracao = 5.0f;
                Itens [i].curaStatus = false;
				Itens [i].causaStatus	= false;
				Itens [i].Descricao ="esta poção serve para recuperar 250 Pontos de vida perdidos ao longo de 5 segundos ";
				i++;

            /////////////////////////////////////////////////////////////////////////////////////////////////

            Itens[i].typeItem = TYPE_ITEM.NULL;
            Itens[i].indice = i;
            Itens[i].potencial = 0;
            Itens[i].itemName = "Espada Longa";
            Itens[i].iconBase = Resources.Load<Sprite>("ItensGerais/" + Itens[i].itemName);
            Itens[i].valorMercado = 350;
            Itens[i].amountMax = 1;
            Itens[i].danoFisicoBase = 15;
            Itens[i].Descricao = "Aumenta em 15 o dano Fisico";
            i++;

            /////////////////////////////////////////////////////////////////////////////////////////////////

            Itens[i].typeItem = TYPE_ITEM.NULL;
            Itens[i].indice = i;
            Itens[i].potencial = 0;
            Itens[i].itemName = "Picareta";
            Itens[i].iconBase = Resources.Load<Sprite>("ItensGerais/" + Itens[i].itemName);
            Itens[i].valorMercado = 875;
            Itens[i].amountMax = 1;
            Itens[i].danoFisicoBase = 15;
            Itens[i].Descricao = "Aumenta em 15 o dano Fisico";
            i++;

            /////////////////////////////////////////////////////////////////////////////////////////////////

            Itens[i].typeItem = TYPE_ITEM.NULL;
            Itens[i].indice = i;
            Itens[i].potencial = 1;
            Itens[i].itemName = "Cetro Vampirico";
            Itens[i].iconBase = Resources.Load<Sprite>("ItensGerais/" + Itens[i].itemName);
            Itens[i].valorMercado = 900;
            Itens[i].amountMax = 1;
            Itens[i].danoFisicoBase = 15;
            Itens[i].Descricao = "Aumenta em 15 o dano Fisico";
            Itens[i].itensCraftName = new string[1];
            Itens[i].itensCraftName[0] = "Espada Longa";
            i++;

            /////////////////////////////////////////////////////////////////////////////////////////////////

            Itens[i].typeItem = TYPE_ITEM.NULL;
            Itens[i].indice = i;
            Itens[i].potencial = 1;
            Itens[i].itemName = "Martelo de Guerra";
            Itens[i].iconBase = Resources.Load<Sprite>("ItensGerais/" + Itens[i].itemName);
            Itens[i].valorMercado = 1100;
            Itens[i].amountMax = 1;
            Itens[i].danoFisicoBase = 15;
            Itens[i].Descricao = "Aumenta em 15 o dano Fisico";
            Itens[i].itensCraftName = new string[2];
            Itens[i].itensCraftName[0] = "Espada Longa";
            Itens[i].itensCraftName[1] = "Espada Longa";
            i++;

            /////////////////////////////////////////////////////////////////////////////////////////////////

            Itens[i].typeItem = TYPE_ITEM.NULL;
            Itens[i].indice = i;
            Itens[i].potencial = 1;
            Itens[i].itemName = "Dente Serrilhado";
            Itens[i].iconBase = Resources.Load<Sprite>("ItensGerais/" + Itens[i].itemName);
            Itens[i].valorMercado = 1100;
            Itens[i].amountMax = 1;
            Itens[i].danoFisicoBase = 15;
            Itens[i].Descricao = "Aumenta em 15 o dano Fisico";
            Itens[i].itensCraftName = new string[2];
            Itens[i].itensCraftName[0] = "Espada Longa";
            Itens[i].itensCraftName[1] = "Espada Longa";
            i++;
            /////////////////////////////////////////////////////////////////////////////////////////////////

            Itens[i].typeItem = TYPE_ITEM.NULL;
            Itens[i].indice = i;
            Itens[i].potencial = 2;
            Itens[i].itemName = "Espada fantasma de youmuus";
            Itens[i].iconBase = Resources.Load<Sprite>("ItensGerais/" + Itens[i].itemName);
            Itens[i].valorMercado = 2900;
            Itens[i].amountMax = 1;
            Itens[i].danoFisicoBase = 15;
            Itens[i].Descricao = "Aumenta em 15 o dano Fisico";
            Itens[i].itensCraftName = new string[3];
            Itens[i].itensCraftName[0] = "Dente Serrilhado";
            Itens[i].itensCraftName[1] = "Espada Longa";
            Itens[i].itensCraftName[2] = "Martelo de Guerra";
            i++;
            /////////////////////////////////////////////////////////////////////////////////////////////////

            Itens[i].typeItem = TYPE_ITEM.NULL;
            Itens[i].indice = i;
            Itens[i].potencial = 0;
            Itens[i].itemName = "Cristal Safira";
            Itens[i].iconBase = Resources.Load<Sprite>("ItensGerais/" + Itens[i].itemName);
            Itens[i].valorMercado = 350;
            Itens[i].amountMax = 1;
            Itens[i].PontosEssencia = 15;
            Itens[i].Descricao = "Aumenta em 250 pontos de Essencia Maxima do personagem";
            i++;

            /////////////////////////////////////////////////////////////////////////////////////////////////

            Itens[i].typeItem = TYPE_ITEM.NULL;
            Itens[i].indice = i;
            Itens[i].potencial = 0;
            Itens[i].itemName = "Tomo da Amplificação";
            Itens[i].iconBase = Resources.Load<Sprite>("ItensGerais/" + Itens[i].itemName);
            Itens[i].valorMercado = 435;
            Itens[i].amountMax = 1;
            Itens[i].danoMagicoBase = 20;
            Itens[i].Descricao = "Aumenta em 20 o dano Mágico";

            i++;

            /////////////////////////////////////////////////////////////////////////////////////////////////

            Itens[i].typeItem = TYPE_ITEM.NULL;
            Itens[i].indice = i;
            Itens[i].potencial = 0;
            Itens[i].itemName = "Pigente da Fada";
            Itens[i].iconBase = Resources.Load<Sprite>("ItensGerais/" + Itens[i].itemName);
            Itens[i].valorMercado = 125;
            Itens[i].amountMax = 1;
            Itens[i].danoMagicoBase = 20;
            Itens[i].Descricao = "Aumenta em 25% a regeneração base de Essencia ";

            i++;

            /////////////////////////////////////////////////////////////////////////////////////////////////

            Itens[i].typeItem = TYPE_ITEM.NULL;
            Itens[i].indice = i;
            Itens[i].potencial = 2;
            Itens[i].itemName = "Sabre bilgewater";
            Itens[i].iconBase = Resources.Load<Sprite>("ItensGerais/" + Itens[i].itemName);
            Itens[i].valorMercado = 1500;
            Itens[i].amountMax = 1;
            Itens[i].danoFisicoBase = 15;
            Itens[i].Descricao = "Aumenta em 25 o dano Fisico e 10% de roubo de vida";
            Itens[i].itensCraftName = new string[2];
            Itens[i].itensCraftName[0] = "Cetro Vampirico";
            Itens[i].itensCraftName[1] = "Espada Longa";
            i++;
            /////////////////////////////////////////////////////////////////////////////////////////////////

            Itens[i].typeItem = TYPE_ITEM.NULL;
            Itens[i].indice = i;
            Itens[i].potencial = 0;
            Itens[i].itemName = "Adaga de Velocidade";
            Itens[i].iconBase = Resources.Load<Sprite>("ItensGerais/" + Itens[i].itemName);
            Itens[i].valorMercado = 300;
            Itens[i].amountMax = 1;
            Itens[i].danoMagicoBase = 20;
            Itens[i].Descricao = "Aumenta em 25% a regeneração base de Essencia ";
            i++;
            /////////////////////////////////////////////////////////////////////////////////////////////////

            Itens[i].typeItem = TYPE_ITEM.NULL;
            Itens[i].indice = i;
            Itens[i].potencial = 1;
            Itens[i].itemName = "Arco Curvo";
            Itens[i].iconBase = Resources.Load<Sprite>("ItensGerais/" + Itens[i].itemName);
            Itens[i].valorMercado = 1500;
            Itens[i].amountMax = 1;
            Itens[i].danoFisicoBase = 15;
            Itens[i].Descricao = "Aumenta em 25 o dano Fisico e 10% de roubo de vida";
            Itens[i].itensCraftName = new string[2];
            Itens[i].itensCraftName[0] = "Adaga de Velocidade";
            Itens[i].itensCraftName[1] = "Adaga de Velocidade";

            i++;
            /////////////////////////////////////////////////////////////////////////////////////////////////

            Itens[i].typeItem = TYPE_ITEM.NULL;
            Itens[i].indice = i;
            Itens[i].potencial = 3;
            Itens[i].itemName = "Espada do Rei Destruido";
            Itens[i].iconBase = Resources.Load<Sprite>("ItensGerais/" + Itens[i].itemName);
            Itens[i].valorMercado = 3200;
            Itens[i].amountMax = 1;
            Itens[i].danoFisicoBase = 15;
            Itens[i].Descricao = "Aumenta em 25 o dano Fisico e 10% de roubo de vida";
            Itens[i].itensCraftName = new string[2];
            Itens[i].itensCraftName[0] = "Arco Curvo";
            Itens[i].itensCraftName[1] = "Sabre bilgewater";
            qntSlot = i;
			break;
			//Debug.Log ("" + i);
				/////////////////////////////////////////////////////////////////////////////////////////////////
//			Itens[i].typeItem = TYPE_ITEM.NULL;
//			Itens [i].tipoArma = -1;
//			Itens [i].tipoArmadura = -1;
//			Itens[i].indice =i;
//			Itens[i].id = -1;
//			Itens[i].itemName = "PocaoCuraMenor"; 
//			Itens [i].iconBase = Resources.Load <Sprite> ("ItensGerais/"+ Itens [i].itemName);
//			Itens[i].isStackable=true;
//			Itens[i].valorMercado= 100;
//			Itens[i].amountMax =99;
//			Itens[i].level  =0;
//			Itens[i].forca 			=0;
//			Itens[i].velocidade		=0;
//			Itens[i]. destreza		=0;
//			Itens[i].resistencia	=0;
//			Itens[i].inteligencia	=0;
//			Itens[i].sabedoria		=0;
//			Itens[i].autoControle	=0;
//			Itens[i].carisma		=0;
//			Itens[i].danoFisico		=0;
//			Itens[i].danoMagico		=0;
//			Itens[i].defesaFisica	=0;
//			Itens[i].defesaMagica	=0;
//			Itens[i].vitalidade		=0;
//			Itens[i].mana			=0;
//			Itens[i].fadiga			=0;
//			Itens[i].attackRate		=0;
//			Itens[i].LifeValue		=250;
//			Itens[i].ManaValue		=0;
//			Itens[i].FadigaValue	=0;
//
//			Itens[i].curaStatus		=false;
//			Itens[i].causaStatus	=false;

			}

	}

}
