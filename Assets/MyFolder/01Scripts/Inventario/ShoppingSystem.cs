using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ShoppingSystem : MonoBehaviour
{
    public string nome;
    public GameObject[] slotItemShop;
    public int[] indiceDoItem;

    public int itensNecessarios;

    public int indiceDoItemF;
    public int quantidadeDoItemF;
    public int gold;

    public GameObject slotModel;
    public GameObject slotShoppingModel;
    public MenuController AuxMenuControlle;

    public BancoDeDadosItens auxBancoDeDadosItens;
    public InventarioController auxInventarioController;
    public bool BluePrint;


    public GameObject buttonsPotencia0;

    public int LinhaItem0;
    public int LinhaItem0Valor;
    public int[] LinhaItem1;
    public int[] LinhaItem2;
    public int[] LinhaItem3;
    public int[] LinhaItem1Valor;
    public int[] LinhaItem2Valor;
    public int[] LinhaItem3Valor;
    public GameObject[] buttonsPotencia1;
    public GameObject[] buttonsPotencia2;
    public GameObject[] buttonsPotencia3;

    public int[] todosItensCompra;
    public int[] inventarioAuxiliar;

    public int[] SomaItemQuantidade;
    public int[] SomaItemIndice;
    // Use this for initialization
    void Start()
    {
        inventarioAuxiliar = new int[6];

        buttonsPotencia0.SetActive(false);

        for (int b1 = 0; b1 < buttonsPotencia1.Length; b1++)
        {
            buttonsPotencia1[b1].SetActive(false);
        }
        for (int b2 = 0; b2 < buttonsPotencia2.Length; b2++)
        {
            buttonsPotencia2[b2].SetActive(false);
        }
        for (int b3 = 0; b3 < buttonsPotencia3.Length; b3++)
        {
            buttonsPotencia3[b3].SetActive(false);
        }

        auxInventarioController = this.GetComponent<InventarioController>();
        AuxMenuControlle = this.GetComponent<MenuController>();
        auxBancoDeDadosItens = this.GetComponent<BancoDeDadosItens>();

        // DesenhaIventario();
        DesenhaShopping();
    }

    // Update is called once per frame
    void Update()
    {
        AtualizaInventario();
    }


    public void DesenhaIventario()
    {
        for (int i = 0; i < 6; i++)
        {
            GameObject item = Instantiate(slotModel, AuxMenuControlle.RectSlotsInventario.GetComponent<RectTransform>().position, Quaternion.identity) as GameObject;
            item.GetComponent<SlotBehaviour>().indiceSlot = i;
            item.transform.parent = AuxMenuControlle.RectSlotsShopping.transform;
            item.name = "Slot" + i;
            //item.transform.GetChild(2).GetComponent<Text>().text = "" + auxBancoDeDadosItens.Itens[].valorMercado;
            // item.GetComponent<SlotBehaviour>().SlotShopping = this;
            item.transform.localScale = new Vector3(1, 1, 1);
            slotItemShop[i] = item;

            for (int s = 0; s < auxBancoDeDadosItens.Itens.Length; s++)
            {
                item.transform.GetChild(0).GetComponent<Image>().sprite = auxBancoDeDadosItens.RetornaTexturaBase(s);
                indiceDoItem[s] = s;
            }

            // textuteChange();
        }
    }


    public void DesenhaShopping()
    {
        for (int i = 0; i < auxBancoDeDadosItens.Itens.Length; i++)
        {
            GameObject item = Instantiate(slotShoppingModel, AuxMenuControlle.RectSlotsShopping.GetComponent<RectTransform>().position, Quaternion.identity) as GameObject;
            //item.GetComponent<SlotBehaviour>().indiceSlot = i;
            item.transform.parent = AuxMenuControlle.RectSlotsShopping.transform;
            item.name = "Slot" + i;
            //  item.transform.GetChild(2).GetComponent<Text>().text = "" + auxBancoDeDadosItens.Itens[].valorMercado;
            item.GetComponent<ShoppingButton>().auxShoppingSystem = this;
            item.GetComponent<ShoppingButton>().auxBancoDeDadosItens = auxBancoDeDadosItens;
            item.transform.localScale = new Vector3(1, 1, 1);
            slotItemShop[i] = item;

            item.transform.GetChild(0).GetComponent<Image>().sprite = auxBancoDeDadosItens.RetornaTexturaBase(i);
            item.transform.GetChild(4).GetComponent<Text>().text = "" + auxBancoDeDadosItens.Itens[i].valorMercado;

            indiceDoItem[i] = i;
            item.GetComponent<ShoppingButton>().indiceItem = auxBancoDeDadosItens.RetornaIndiceDoItem(i);
            // aux textuteChange();
        }
    }



    public void DesenhaFormula(int indiceItemAtual)
    {
        buttonsPotencia0.SetActive(false);

        for (int b1 = 0; b1 < buttonsPotencia1.Length; b1++)
        {
            buttonsPotencia1[b1].SetActive(false);
        }
        for (int b2 = 0; b2 < buttonsPotencia2.Length; b2++)
        {
            buttonsPotencia2[b2].SetActive(false);
        }
        for (int b3 = 0; b3 < buttonsPotencia3.Length; b3++)
        {
            buttonsPotencia3[b3].SetActive(false);
        }

        ItensPotencia1D(indiceItemAtual);

        if (auxBancoDeDadosItens.Itens[LinhaItem0].potencial==0)
        {
            Debug.Log("Potencia =" + auxBancoDeDadosItens.Itens[LinhaItem0].potencial);
        }

        if (auxBancoDeDadosItens.Itens[LinhaItem0].potencial == 1)
        {
            Debug.Log("Potencia =" + auxBancoDeDadosItens.Itens[LinhaItem0].potencial);
        }

        if (auxBancoDeDadosItens.Itens[LinhaItem0].potencial == 2)
        {
            Debug.Log("Potencia =" + auxBancoDeDadosItens.Itens[LinhaItem0].potencial);
        }

        if (auxBancoDeDadosItens.Itens[LinhaItem0].potencial == 3)
        {
            Debug.Log("Potencia =" + auxBancoDeDadosItens.Itens[LinhaItem0].potencial);
        }
    }




    public void ItensPotencia1D(int indiceItemAtual)
    {
        AtualizaInventario();
        LinhaItem0 = -1;
        LinhaItem0Valor = 0;
        for (int ic1 = 0; ic1 < 3; ic1++)
        {
            LinhaItem1[ic1] = -1;
            LinhaItem1Valor[ic1] = 0;
        }

        for (int ic1 = 0; ic1 < 6; ic1++)
        {
            LinhaItem2[ic1] = -1;
            LinhaItem2Valor[ic1] = 0;
            LinhaItem3[ic1] = -1;
            LinhaItem3Valor[ic1] = 0;
        }

        LinhaItem0 = indiceItemAtual;
        LinhaItem0Valor = auxBancoDeDadosItens.Itens[indiceItemAtual].valorMercado;
        //Debug.Log("Itens Linha 0 = " + auxBancoDeDadosItens.RetornaNome(indiceItemAtual));
        buttonsPotencia0.SetActive(true);
        buttonsPotencia0.transform.GetChild(0).GetComponent<Image>().sprite = auxBancoDeDadosItens.RetornaTexturaBase(indiceItemAtual);
        buttonsPotencia0.transform.GetChild(4).GetComponent<Text>().text = "" + auxBancoDeDadosItens.Itens[indiceItemAtual].valorMercado;

        for (int ic1 = 0; ic1 < auxBancoDeDadosItens.Itens[indiceItemAtual].itensCraftName.Length; ic1++)
        {
            for (int b1 = 0; b1 < auxBancoDeDadosItens.Itens.Length; b1++)
            {
                if (auxBancoDeDadosItens.Itens[indiceItemAtual].itensCraftName[ic1] == auxBancoDeDadosItens.RetornaNome(b1))
                {
                    LinhaItem1[ic1] = auxBancoDeDadosItens.RetornaIndiceDoItem(b1);
                    LinhaItem1Valor[ic1] = auxBancoDeDadosItens.Itens[b1].valorMercado;
                    // Debug.Log("Nome Itens Linha 1 = " + auxBancoDeDadosItens.RetornaNome(LinhaItem1[ic1]) + "   Indice = " + LinhaItem1[ic1]);

                    buttonsPotencia1[ic1].SetActive(true);
                    buttonsPotencia1[ic1].transform.GetChild(0).GetComponent<Image>().sprite = auxBancoDeDadosItens.RetornaTexturaBase(b1);
                    buttonsPotencia1[ic1].transform.GetChild(4).GetComponent<Text>().text = "" +  LinhaItem1Valor[ic1];
                }
            }
        }

        if (LinhaItem1[0] > -1)
        {
            if (auxBancoDeDadosItens.Itens[LinhaItem1[0]].itensCraftName.Length > 0)
            {
                for (int i = 0; i < auxBancoDeDadosItens.Itens[LinhaItem1[0]].itensCraftName.Length; i++)
                {
                    for (int b1 = 0; b1 < auxBancoDeDadosItens.Itens.Length; b1++)
                    {
                        if (auxBancoDeDadosItens.Itens[LinhaItem1[0]].itensCraftName[i] == auxBancoDeDadosItens.RetornaNome(b1))
                        {
                            LinhaItem2[i] = auxBancoDeDadosItens.RetornaIndiceDoItem(b1);
                            LinhaItem2Valor[i] = auxBancoDeDadosItens.Itens[b1].valorMercado;
                            buttonsPotencia2[i].SetActive(true);
                            buttonsPotencia2[i].transform.GetChild(0).GetComponent<Image>().sprite = auxBancoDeDadosItens.RetornaTexturaBase(b1);
                            buttonsPotencia2[i].transform.GetChild(4).GetComponent<Text>().text = "" + LinhaItem2Valor[i];
                        }
                    }
                }
            }
        }

        if (LinhaItem1[1] > -1)
        {
          
            if (auxBancoDeDadosItens.Itens[LinhaItem1[1]].itensCraftName.Length > 0)
            {
                for (int i = 0; i < auxBancoDeDadosItens.Itens[LinhaItem1[1]].itensCraftName.Length; i++)
                {
                    for (int b1 = 0; b1 < auxBancoDeDadosItens.Itens.Length; b1++)
                    {
                        if (auxBancoDeDadosItens.Itens[LinhaItem1[1]].itensCraftName[i] == auxBancoDeDadosItens.RetornaNome(b1))
                        {
                            LinhaItem2[(i + 2)] = auxBancoDeDadosItens.RetornaIndiceDoItem(b1);
                            LinhaItem2Valor[(i + 2)] = auxBancoDeDadosItens.Itens[b1].valorMercado;
                            buttonsPotencia2[(i + 2)].SetActive(true);
                            buttonsPotencia2[(i + 2)].transform.GetChild(0).GetComponent<Image>().sprite = auxBancoDeDadosItens.RetornaTexturaBase(b1);
                            buttonsPotencia2[(i + 2)].transform.GetChild(4).GetComponent<Text>().text = "" + auxBancoDeDadosItens.Itens[b1].valorMercado;
                        }
                    }

                    int desconto = 0;
                    int passada = 0;
                    for (int inv = 0; inv < auxInventarioController.inventario.indiceItem.Length; inv++)
                    {
                        
                            if (auxBancoDeDadosItens.Itens[LinhaItem1[1]].itensCraftName[i] == auxBancoDeDadosItens.RetornaNome(auxInventarioController.inventario.indiceItem[inv]))
                            {
                            if (passada <= auxBancoDeDadosItens.Itens[LinhaItem1[1]].itensCraftName.Length)
                            {
                                passada++;
                                desconto += auxBancoDeDadosItens.Itens[auxInventarioController.inventario.indiceItem[inv]].valorMercado;
                                int valorl2 = auxBancoDeDadosItens.Itens[LinhaItem1[1]].valorMercado - desconto;
                                buttonsPotencia1[1].transform.GetChild(4).GetComponent<Text>().text = "" + valorl2;
                                LinhaItem1Valor[1] = valorl2;
                                Debug.Log("Item Base" + auxBancoDeDadosItens.Itens[LinhaItem1[1]].valorMercado + "Desconto = " + desconto);
                                
                            }
                        }
                    }

                }
            }

        }

        if (LinhaItem1[2] > -1)
        {
            if (auxBancoDeDadosItens.Itens[LinhaItem1[2]].itensCraftName.Length > 0)
            {
                for (int i = 0; i < auxBancoDeDadosItens.Itens[LinhaItem1[2]].itensCraftName.Length; i++)
                {
                    for (int b1 = 0; b1 < auxBancoDeDadosItens.Itens.Length; b1++)
                    {
                        if (auxBancoDeDadosItens.Itens[LinhaItem1[2]].itensCraftName[i] == auxBancoDeDadosItens.RetornaNome(b1))
                        {
                            LinhaItem2[(i + 4)] = auxBancoDeDadosItens.RetornaIndiceDoItem(b1);
                            LinhaItem2Valor[(i + 4)] = auxBancoDeDadosItens.Itens[b1].valorMercado;
                            buttonsPotencia2[(i + 4)].SetActive(true);
                            buttonsPotencia2[(i + 4)].transform.GetChild(0).GetComponent<Image>().sprite = auxBancoDeDadosItens.RetornaTexturaBase(b1);
                            buttonsPotencia2[(i + 4)].transform.GetChild(4).GetComponent<Text>().text = "" + auxBancoDeDadosItens.Itens[b1].valorMercado;
                            
                        }
                    }
                    int desconto = 0;
                    int passada = 0;
                    for (int inv = 0; inv < auxInventarioController.inventario.indiceItem.Length; inv++)
                    {
                       
                        if (auxBancoDeDadosItens.Itens[LinhaItem1[2]].itensCraftName[i] == auxBancoDeDadosItens.RetornaNome(auxInventarioController.inventario.indiceItem[inv]) && passada <= (auxBancoDeDadosItens.Itens[LinhaItem1[2]].itensCraftName.Length-1))
                        {                           
                            desconto += auxBancoDeDadosItens.Itens[auxInventarioController.inventario.indiceItem[inv]].valorMercado;
                            passada++;
                            int valorl2 = auxBancoDeDadosItens.Itens[LinhaItem1[2]].valorMercado - desconto;
                           buttonsPotencia1[2].transform.GetChild(4).GetComponent<Text>().text = "" + valorl2;
                           LinhaItem1Valor[2] = valorl2;
                           Debug.Log("Item Base" + auxBancoDeDadosItens.Itens[LinhaItem1[2]].valorMercado + "Desconto = " + desconto);
                            Debug.Log("passada =" + passada);

                        }
                    }
                }
            }
        }

        for (int i = 0; i < 6; i++)
        {
            if (LinhaItem2[i] > -1)
            {
                Debug.Log("LinhaItem2[i] = " + LinhaItem2[i]);

                if (auxBancoDeDadosItens.Itens[LinhaItem2[i]].itensCraftName.Length > 0)
                {
                    for (int b1 = 0; b1 < auxBancoDeDadosItens.Itens.Length; b1++)
                    {
                        if (auxBancoDeDadosItens.Itens[LinhaItem2[i]].itensCraftName[0] == auxBancoDeDadosItens.RetornaNome(b1))
                        {
                            LinhaItem3[i] = auxBancoDeDadosItens.RetornaIndiceDoItem(b1);
                            LinhaItem3Valor[i] = auxBancoDeDadosItens.Itens[b1].valorMercado;
                            buttonsPotencia3[i].SetActive(true);
                            buttonsPotencia3[i].transform.GetChild(0).GetComponent<Image>().sprite = auxBancoDeDadosItens.RetornaTexturaBase(b1);
                            buttonsPotencia3[i].transform.GetChild(4).GetComponent<Text>().text = "" + auxBancoDeDadosItens.Itens[b1].valorMercado;
                        }

                    }
                    for (int inv = 0; inv < auxInventarioController.inventario.indiceItem.Length; inv++)
                    {
                        if (auxBancoDeDadosItens.Itens[LinhaItem2[i]].itensCraftName[0] == auxBancoDeDadosItens.RetornaNome(auxInventarioController.inventario.indiceItem[inv]))
                        {                                     
                                int valorl2 = auxBancoDeDadosItens.Itens[LinhaItem2[i]].valorMercado - auxBancoDeDadosItens.Itens[auxInventarioController.inventario.indiceItem[inv]].valorMercado;
                                buttonsPotencia2[i].transform.GetChild(4).GetComponent<Text>().text = "" + valorl2;
                                LinhaItem2Valor[(i)] = valorl2;                                                       
                                Debug.Log("Item Base" + auxBancoDeDadosItens.Itens[LinhaItem2[i]].valorMercado + "Desconto" + auxBancoDeDadosItens.Itens[auxInventarioController.inventario.indiceItem[inv]].valorMercado);
                        }
                    }

                }
            }
        }
        DescontoCompraItens();
    }

    public void AtualizaInventario()
    {
        for (int i = 0; i < 6; i++)
        {
            inventarioAuxiliar[i] = auxInventarioController.inventario.indiceItem[i];
        }
        
    }
    public void DescontoCompraItens()
    {
        todosItensCompra[0] = LinhaItem0;
        for (int l1 = 0; l1 < 3; l1++)
        {

                todosItensCompra[(l1+1)] = LinhaItem1[l1];
          
        }

        for (int l2 = 0; l2 < 6; l2++)
        {
            todosItensCompra[(l2+4)] = LinhaItem2[l2];

   
        }

        for (int l3 = 0; l3 < 6; l3++)
        {
            todosItensCompra[l3 + 10] = LinhaItem3[l3];
            for (int i = 0; i < auxInventarioController.inventario.indiceItem.Length; i++)
            { 
                if (LinhaItem2[l3] == auxInventarioController.inventario.indiceItem[i])
                {
                    //Debug.Log("desconto da loja =" + auxBancoDeDadosItens.Itens[auxInventarioController.inventario.indiceItem[i]].valorMercado);
                }
            }
        }
        for (int i = 0; i < auxInventarioController.inventario.indiceItem.Length; i++)
        {
            
            if (LinhaItem2[i] == auxInventarioController.inventario.indiceItem[i])
            {
               // Debug.Log("desconto da loja =" + auxBancoDeDadosItens.Itens[auxInventarioController.inventario.indiceItem[i]].valorMercado);
            }
        }

        for (int inv = 16; inv >-1; inv--)
        {

            //Debug.Log(inv);
        }
       // auxInventarioController.inventario.indiceItem[0] = 1;

    }

    public void DescontoPotencia1()
    {

    }

}