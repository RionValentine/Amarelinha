using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InventarioController : MonoBehaviour
{
    public CharBaseStatus auxCharBaseStatus;
    public GameObject[] Slots;
    public int maxSlot;
    public int indiceInventariotAtual;
    public int indiceEquipamentotAtual;
    public int indiceAtual;
    public int indiceAnterior;

    public ShoppingSystem auxShoppingSystem;
    [System.Serializable]
    public class Celula
    {
        public int[]   indiceItem;
        public int[]   quantidade;
        public bool[]  cooldown;
        public float[] cooldownAtual;
        public bool[]  isEmpty;       
    }

    public Celula inventario;
  //  public Celula EquipamentoCelula;
    public Celula celulaAux1;
    public Celula celulaAux2;

    public bool pegaCelula;


    public Sprite iconBase;
    public Sprite iconOver;


    public GameObject CelularAuxiliar;
    public SlotBehaviour auxSlotBehaviour;

    [Header("-Models-")]
    public GameObject slotModel;

    public BancoDeDadosItens auxItem;
    public MenuController AuxMenuControlle;

    public bool equipOnline;
    public bool equipAnterior;

    [Header("-Menu2d-")]
    public Transform fakeMouseSeta;
    public Transform fakeMouseSeta2;
    // public GameObject seta;
    public Camera cameraFake;


    public Vector3 offSetCel;
    // Use this for initialization
    void Start () {
        if(AuxMenuControlle==null)
        {
            Debug.Log("Nao tinha");
            auxItem = this.GetComponent<BancoDeDadosItens>();
            AuxMenuControlle = GameObject.Find("GameController").GetComponent<MenuController>();
            auxShoppingSystem = this.GetComponent<ShoppingSystem>();
        }
        else
        {
            Debug.Log("Ja tinha");
        }
        


      
        
        DesenhaIventario();
        textuteChange();
        Bonusitens();
    }
	
	// Update is called once per frame
	void Update ()
    {
       // Vector3 mouseposition = new Vector3( Input.mousePosition.x, Input.mousePosition.y, fakeMouseSeta.position.z);
        //fakeMouseSeta.position = mouseposition;

        if(AuxMenuControlle.exibMenu)
        {
            
            RaycastHit hit;
            //Vector3 forward = fakeMouseSeta.transform.TransformDirection(Vector3.forward) * 100;
           // Debug.DrawRay(fakeMouseSeta.transform.position, forward, Color.green);

          //  if (Physics.Raycast(fakeMouseSeta.transform.position, (forward), out hit))
         //   {
               // Debug.Log("" + hit.collider.name);
         //   }
            AuxMenuControlle.ChamarMenuButton();

        }
        
        JoysticMoviment();
        textuteChange();

    }


    public void DesenhaIventario()
    {
        //inventario.indiceItem = new int[109];
       // inventario.quantidade = new int[109];
       // inventario.cooldown   = new bool[109];

        celulaAux1.indiceItem = new int[1];
        celulaAux1.quantidade = new int[1];
        celulaAux1.cooldown   = new bool[1];
        celulaAux1.cooldownAtual = new float[1];

        celulaAux2.indiceItem = new int[1];
        celulaAux2.quantidade = new int[1];
        celulaAux2.cooldown = new bool[1];
        celulaAux2.cooldownAtual = new float[1];

        celulaAux1.indiceItem[0] = -1;
        celulaAux1.quantidade[0] = -1;
        celulaAux1.cooldown[0]   = false;
        celulaAux1.cooldownAtual[0] = 0f;

        celulaAux2.indiceItem[0] = -1;
        celulaAux2.quantidade[0] = -1;
        celulaAux2.cooldown[0]   = false;
        celulaAux2.cooldownAtual[0] = 0f;

        for (int i = 0; i < 6; i++)
        {
            GameObject item = Instantiate(slotModel, AuxMenuControlle.RectSlotsInventario.GetComponent<RectTransform>().position, Quaternion.identity) as GameObject;
            item.GetComponent<SlotBehaviour>().indiceSlot = i;
            item.transform.parent = AuxMenuControlle.RectSlotsInventario.transform;
            item.name = "Slot" + i;
            item.transform.GetChild(2).GetComponent<Text>().text = "" + (i+1);
            item.GetComponent<SlotBehaviour>().AuxInventarioController = this;
            item.transform.localScale = new Vector3(1, 1, 1);
            Slots[i] = item;

           // inventario.indiceItem[i] = -1;

            inventario.indiceItem[i] = -1;
            inventario.quantidade[i] = -1;
           // textuteChange();
        }
        inventario.indiceItem[0] = 1;
        inventario.indiceItem[1] = 1;
        inventario.indiceItem[2] = 1;
        inventario.indiceItem[5] = 11;
    }

    public void textuteChange()
    {
        for (int i = 0; i < 6; i++)
        {
            if (celulaAux1.indiceItem[0] !=-1 && celulaAux2.indiceItem[0] !=-1)
            {
                CelularAuxiliar.transform.GetChild(0).GetComponent<Image>().sprite = auxItem.RetornaTexturaBase(celulaAux1.indiceItem[0]);
                CelularAuxiliar.transform.transform.position = Input.mousePosition + offSetCel;
                CelularAuxiliar.SetActive(true);
                if (celulaAux1.quantidade[0] > 1)
                {
                    CelularAuxiliar.transform.GetChild(1).GetComponent<Text>().text = "" + celulaAux1.quantidade[0];
                }
                else
                {
                    CelularAuxiliar.transform.GetChild(1).GetComponent<Text>().text="";
                }        
            }
            else
            {
                CelularAuxiliar.SetActive(false);
                CelularAuxiliar.transform.GetChild(0).GetComponent<Image>().sprite = null;
            }
            
            Slots[i].transform.GetChild(0).GetComponent<Image>().sprite = auxItem.RetornaTexturaBase(inventario.indiceItem[i]);

            if (Slots[i] != null)
            {
                if (Slots[i] == Slots[indiceAtual])
                {
                    //Slots[i].GetComponent<Image>().sprite = iconOver;
                    Slots[i].GetComponent<Image>().color = Color.red;

                    // Slots[i].transform.GetChild(0).GetComponent<Image>().sprite = auxItem.RetornaTexturaOver(inventario.indiceItem[i]);
                    if (inventario.quantidade[i] > 1)
                    {
                        Slots[i].transform.GetChild(1).GetComponent<Text>().enabled = true;
                        Slots[i].transform.GetChild(1).GetComponent<Text>().text = "" + inventario.quantidade[i];

                    }
                    else
                    {
                        Slots[i].transform.GetChild(1).GetComponent<Text>().enabled = false;
                    }

                }
                else
                {
                    Slots[i].GetComponent<Image>().color = Color.white;
                    if (inventario.quantidade[i] > 1)
                    {
                        Slots[i].transform.GetChild(1).GetComponent<Text>().enabled = true;
                        Slots[i].transform.GetChild(1).GetComponent<Text>().text = "" + inventario.quantidade[i];

                    }
                    else
                    {
                        Slots[i].transform.GetChild(1).GetComponent<Text>().enabled = false;
                    }

                }
            }else
            {
                Slots[i].transform.GetChild(0).GetComponent<Image>().color = Color.blue;
            }



        }
    }

    /*public void FPegaCelula(int indice, int quantidade, bool cooldown, int indiceDaCelula)
    {
        if (inventario.indiceItem[indiceDaCelula] > -1)
        {
            Slots[indiceAnterior].GetComponent<Image>().color = Color.red;
            celulaAux1.indiceItem[0] = indice;
            celulaAux1.quantidade[0] = quantidade;
            celulaAux1.cooldown[0] = cooldown;
        }
        if (!pegaCelula)
        {
            if (Slots[indiceAtual].GetComponent<SlotBehaviour>().SlotEquip)
            {
                equipOnline = true;
            }

            //inventario.indiceItem[indiceDaCelula] = -1;
            //inventario.quantidade[indiceDaCelula] = -1;
            //inventario.cooldown[indiceDaCelula] = false;
            pegaCelula = true;

        }
        else
        {
            if (celulaAux1.indiceItem[0] == celulaAux2.indiceItem[0] && auxItem.RetornaMaxEstoque(celulaAux2.indiceItem[0]) > 1 && Slots[indiceAnterior].GetComponent<SlotBehaviour>().indiceSlot != Slots[indiceAtual].GetComponent<SlotBehaviour>().indiceSlot && inventario.indiceItem[indiceDaCelula] > -1)
            {
                if ((celulaAux2.quantidade[0] + celulaAux1.quantidade[0]) <= auxItem.RetornaMaxEstoque(celulaAux2.indiceItem[0]))
                {
                    celulaAux2.quantidade[0] += celulaAux1.quantidade[0];
                    inventario.indiceItem[indiceDaCelula] = celulaAux2.indiceItem[0];
                    inventario.quantidade[indiceDaCelula] = celulaAux2.quantidade[0];
                    inventario.cooldown[indiceDaCelula] = celulaAux2.cooldown[0];

                    celulaAux2.indiceItem[0] = -1;
                    celulaAux2.quantidade[0] = -1;

                    celulaAux1.indiceItem[0] = -1;
                    celulaAux1.quantidade[0] = -1;

                    inventario.indiceItem[indiceAnterior] = -1;
                    inventario.quantidade[indiceAnterior] = -1;
                    inventario.cooldown[indiceAnterior] = false;

                    Slots[indiceAnterior].GetComponent<Image>().color = Color.white;
                    Debug.Log("Nao teve Sobra");
                }
                else
                {
                    celulaAux1.quantidade[0] = (celulaAux2.quantidade[0] + celulaAux1.quantidade[0]) - auxItem.RetornaMaxEstoque(celulaAux2.indiceItem[0]);
                    celulaAux2.quantidade[0] = auxItem.RetornaMaxEstoque(celulaAux2.indiceItem[0]);


                    inventario.indiceItem[indiceDaCelula] = celulaAux2.indiceItem[0];
                    inventario.quantidade[indiceDaCelula] = celulaAux2.quantidade[0];


                    inventario.indiceItem[indiceAnterior] = celulaAux1.indiceItem[0];
                    inventario.quantidade[indiceAnterior] = celulaAux1.quantidade[0];

                    celulaAux2.indiceItem[0] = -1;
                    celulaAux2.quantidade[0] = -1;

                    celulaAux1.indiceItem[0] = -1;
                    celulaAux1.quantidade[0] = -1;
                    Slots[indiceAnterior].GetComponent<Image>().color = Color.white;
                    Debug.Log("teve Sobra");
                }

            }
            else if (!Slots[indiceAtual].GetComponent<SlotBehaviour>().SlotEquip)
            {

                if (inventario.indiceItem[indiceAtual] > -1)
                {
                    if (!equipOnline)
                    {
                        inventario.indiceItem[indiceDaCelula] = celulaAux2.indiceItem[0];
                        inventario.quantidade[indiceDaCelula] = celulaAux2.quantidade[0];
                        inventario.cooldown[indiceDaCelula] = celulaAux2.cooldown[0];

                        inventario.indiceItem[indiceAnterior] = celulaAux1.indiceItem[0];
                        inventario.quantidade[indiceAnterior] = celulaAux1.quantidade[0];
                        inventario.cooldown[indiceAnterior] = celulaAux1.cooldown[0];

                        celulaAux2.indiceItem[0] = -1;
                        celulaAux2.quantidade[0] = -1;

                        celulaAux1.indiceItem[0] = -1;
                        celulaAux1.quantidade[0] = -1;
                        Slots[indiceAnterior].GetComponent<Image>().color = Color.white;
                        Debug.Log("troco com outro item");
                        equipOnline = false;
                    }
                    else if (auxItem.Itens[inventario.indiceItem[indiceAtual]].typeItem != TYPE_ITEM.EQUIPAMENTO)
                    {
                        Debug.Log("nao e equipamento");
                        celulaAux2.indiceItem[0] = -1;
                        celulaAux2.quantidade[0] = -1;

                        celulaAux1.indiceItem[0] = -1;
                        celulaAux1.quantidade[0] = -1;
                        Slots[indiceAnterior].GetComponent<Image>().color = Color.white;

                        equipOnline = false;

                    }
                    else
                    {
                        Debug.Log(" e equipamento");
                        if (Slots[indiceAnterior].GetComponent<SlotBehaviour>().typeToSubRestrict[0] == auxItem.Itens[inventario.indiceItem[indiceAtual]].subTypeItem ||
                            Slots[indiceAnterior].GetComponent<SlotBehaviour>().typeToSubRestrict[1] == auxItem.Itens[inventario.indiceItem[indiceAtual]].subTypeItem ||
                            Slots[indiceAnterior].GetComponent<SlotBehaviour>().typeToSubRestrict[2] == auxItem.Itens[inventario.indiceItem[indiceAtual]].subTypeItem ||
                            Slots[indiceAnterior].GetComponent<SlotBehaviour>().typeToSubRestrict[3] == auxItem.Itens[inventario.indiceItem[indiceAtual]].subTypeItem ||
                            Slots[indiceAnterior].GetComponent<SlotBehaviour>().typeToSubRestrict[4] == auxItem.Itens[inventario.indiceItem[indiceAtual]].subTypeItem)
                        {
                            //Debug.Log ("typeToRestrict = " + Slots [indiceAtual].GetComponent<SlotBehaviour> ().typeToSubRestrict[i]);

                            if (inventario.indiceItem[indiceAtual] > -1)
                            {
                                inventario.indiceItem[indiceDaCelula] = celulaAux2.indiceItem[0];
                                inventario.quantidade[indiceDaCelula] = celulaAux2.quantidade[0];
                                inventario.cooldown[indiceDaCelula] = celulaAux2.cooldown[0];

                                inventario.indiceItem[indiceAnterior] = celulaAux1.indiceItem[0];
                                inventario.quantidade[indiceAnterior] = celulaAux1.quantidade[0];
                                inventario.cooldown[indiceAnterior] = celulaAux1.cooldown[0];

                                celulaAux2.indiceItem[0] = -1;
                                celulaAux2.quantidade[0] = -1;

                                celulaAux1.indiceItem[0] = -1;
                                celulaAux1.quantidade[0] = -1;
                                Slots[indiceAnterior].GetComponent<Image>().color = Color.white;

                                Debug.Log("troco com outro Equipamento");
                            }
                            else
                            {
                                inventario.indiceItem[indiceDaCelula] = celulaAux2.indiceItem[0];
                                inventario.quantidade[indiceDaCelula] = celulaAux2.quantidade[0];
                                inventario.cooldown[indiceDaCelula] = celulaAux2.cooldown[0];

                                celulaAux2.indiceItem[0] = -1;
                                celulaAux2.quantidade[0] = -1;

                                celulaAux1.indiceItem[0] = -1;
                                celulaAux1.quantidade[0] = -1;

                                inventario.indiceItem[indiceAnterior] = -1;
                                inventario.quantidade[indiceAnterior] = -1;
                                inventario.cooldown[indiceAnterior] = false;
                                Slots[indiceAnterior].GetComponent<Image>().color = Color.white;
                                Debug.Log("troco por um equipamento vazio");
                            }
                        }
                        else
                        {
                            celulaAux2.indiceItem[0] = -1;
                            celulaAux2.quantidade[0] = -1;

                            celulaAux1.indiceItem[0] = -1;
                            celulaAux1.quantidade[0] = -1;
                            Slots[indiceAnterior].GetComponent<Image>().color = Color.white;
                        }
                        equipOnline = false;
                    }


                }
                else
                {
                    inventario.indiceItem[indiceDaCelula] = celulaAux2.indiceItem[0];
                    inventario.quantidade[indiceDaCelula] = celulaAux2.quantidade[0];
                    inventario.cooldown[indiceDaCelula] = celulaAux2.cooldown[0];

                    celulaAux2.indiceItem[0] = -1;
                    celulaAux2.quantidade[0] = -1;

                    celulaAux1.indiceItem[0] = -1;
                    celulaAux1.quantidade[0] = -1;

                    inventario.indiceItem[indiceAnterior] = -1;
                    inventario.quantidade[indiceAnterior] = -1;
                    inventario.cooldown[indiceAnterior] = false;
                    Slots[indiceAnterior].GetComponent<Image>().color = Color.white;
                    equipOnline = false;
                    Debug.Log("troco por um Item vazio");
                    equipOnline = false;
                }

            }
            else
            {
               // eEquipamento(indiceDaCelula);

            }
        }


        celulaAux2.indiceItem[0] = celulaAux1.indiceItem[0];
        celulaAux2.quantidade[0] = celulaAux1.quantidade[0];
        celulaAux2.cooldown[0] = celulaAux1.cooldown[0];
        Debug.Log("pegaCelula");


        if (Slots[indiceAtual].GetComponent<SlotBehaviour>().indiceSlot == 50 || Slots[indiceAnterior].GetComponent<SlotBehaviour>().indiceSlot == 50)
        {
           // auxPlayer.auxCharBase[auxPlayer.CharAtual].indiceEquipamento[0] = inventario.indiceItem[50];
        }
        if (Slots[indiceAtual].GetComponent<SlotBehaviour>().indiceSlot == 51 || Slots[indiceAnterior].GetComponent<SlotBehaviour>().indiceSlot == 51)
        {
           // auxPlayer.auxCharBase[auxPlayer.CharAtual].indiceEquipamento[1] = inventario.indiceItem[51];
        }
        if (Slots[indiceAtual].GetComponent<SlotBehaviour>().indiceSlot == 52 || Slots[indiceAnterior].GetComponent<SlotBehaviour>().indiceSlot == 52)
        {
           // auxPlayer.auxCharBase[auxPlayer.CharAtual].indiceEquipamento[2] = inventario.indiceItem[52];
        }
        if (Slots[indiceAtual].GetComponent<SlotBehaviour>().indiceSlot == 53 || Slots[indiceAnterior].GetComponent<SlotBehaviour>().indiceSlot == 53)
        {
           // auxPlayer.auxCharBase[auxPlayer.CharAtual].indiceEquipamento[3] = inventario.indiceItem[53];
        }
        if (Slots[indiceAtual].GetComponent<SlotBehaviour>().indiceSlot == 54 || Slots[indiceAnterior].GetComponent<SlotBehaviour>().indiceSlot == 54)
        {
            //auxPlayer.auxCharBase[auxPlayer.CharAtual].indiceEquipamento[4] = inventario.indiceItem[54];
        }
        if (Slots[indiceAtual].GetComponent<SlotBehaviour>().indiceSlot == 55 || Slots[indiceAnterior].GetComponent<SlotBehaviour>().indiceSlot == 55)
        {
            //auxPlayer.auxCharBase[auxPlayer.CharAtual].indiceEquipamento[5] = inventario.indiceItem[55];
        }
        if (Slots[indiceAtual].GetComponent<SlotBehaviour>().indiceSlot == 56 || Slots[indiceAnterior].GetComponent<SlotBehaviour>().indiceSlot == 56)
        {
            //auxPlayer.auxCharBase[auxPlayer.CharAtual].indiceEquipamento[6] = inventario.indiceItem[56];
        }
        if (Slots[indiceAtual].GetComponent<SlotBehaviour>().indiceSlot == 57 || Slots[indiceAnterior].GetComponent<SlotBehaviour>().indiceSlot == 57)
        {
            //auxPlayer.auxCharBase[auxPlayer.CharAtual].indiceEquipamento[7] = inventario.indiceItem[57];
        }
        if (Slots[indiceDaCelula].GetComponent<SlotBehaviour>().indiceSlot == 58)
        {
           // auxPlayer.auxCharBase[auxPlayer.CharAtual].indiceEquipamento[8] = inventario.indiceItem[indiceDaCelula];
            //Debug.Log("coloquei uma arma2" + "Indice do Item = " + inventario.indiceItem[indiceDaCelula]);
        }

        if (celulaAux1.indiceItem[0] < 0) pegaCelula = false;

    }
    */


    public void FPegaCelula(int indice, int quantidade, float cooldownAtual, int indiceDaCelula)
    {
     
        celulaAux1.indiceItem[0] = indice;
        celulaAux1.quantidade[0] = quantidade;
        celulaAux1.cooldownAtual[0] = cooldownAtual;

        if (!pegaCelula)
        {
            Debug.Log("estagio1 " + pegaCelula);
            inventario.indiceItem[indiceDaCelula] = -1;
            inventario.quantidade[indiceDaCelula] = -1;
            inventario.cooldownAtual[indiceDaCelula] = -1;
        }
        else
        {
            Debug.Log("estagio2 " + pegaCelula);
            pegaCelula = false;
            Debug.Log("2 " + pegaCelula);
            inventario.indiceItem[indiceDaCelula] = celulaAux2.indiceItem[0];
            inventario.quantidade[indiceDaCelula] = celulaAux2.quantidade[0];
            inventario.cooldownAtual[indiceDaCelula] = celulaAux2.cooldownAtual[0];
        }

        celulaAux2.indiceItem[0] = celulaAux1.indiceItem[0];
        celulaAux2.quantidade[0] = celulaAux1.quantidade[0];
        celulaAux2.cooldownAtual[0] = celulaAux1.cooldownAtual[0];
    }

    /*
    public void FPegaCelula3(int indice, int quantidade, float cooldownAtual, bool cooldown, int indiceDaCelula)
    {               
        if (!pegaCelula)
        {
            Debug.Log("NaopegaCelula");
            // inventario.indiceItem[indiceDaCelula] = -1;
            //inventario.quantidade[indiceDaCelula] = -1;
            //inventario.Aprimoramento[indiceDaCelula] = -1;
            //inventario.elemento[indiceDaCelula] = -1;
            //inventario.cooldown[indiceDaCelula] = false;
            //inventario.cooldownAtual[indiceDaCelula] = 0;

            celulaAux1.indiceItem[0] = indice;
            celulaAux1.quantidade[0] = quantidade;           
            celulaAux1.cooldown[0] = cooldown;
            celulaAux1.cooldownAtual[0] = cooldownAtual;
            pegaCelula = true;
            if (equipOnline)
            {
                equipAnterior = true;
            }
        }
        else
        {
            if(!equipOnline)
            {
                if(!equipAnterior)
                {
                    troca(indiceDaCelula);
                    pegaCelula = false;
                    Debug.Log("Nao trocou Equipamento");
                }
                else
                {
                    for (int i = 0; i < Slots[indiceAnterior].GetComponent<SlotBehaviour>().typeToSubRestrict.Length; i++)
                    {
                        
                        //Debug.Log("restrições" + Slots[indiceAnterior].GetComponent<SlotBehaviour>().typeToSubRestrict[i]);
                        
                        if (inventario.indiceItem[indiceAtual] != -1)
                        {

                            if (Slots[indiceAnterior].GetComponent<SlotBehaviour>().typeToSubRestrict[i] == auxItem.Itens[inventario.indiceItem[indiceAtual]].subTypeItem)
                            {
                                Debug.Log("Trocou Equipamento novo");
                                celulaAux2.indiceItem[0] = inventario.indiceItem[indiceDaCelula];
                                celulaAux2.quantidade[0] = inventario.quantidade[indiceDaCelula];                                
                                celulaAux2.cooldown[0] = inventario.cooldown[indiceDaCelula];
                                celulaAux2.cooldownAtual[0] = inventario.cooldownAtual[indiceDaCelula];

                                inventario.indiceItem[indiceDaCelula] = celulaAux1.indiceItem[0];
                                inventario.quantidade[indiceDaCelula] = celulaAux1.quantidade[0];                                
                                inventario.cooldown[indiceDaCelula] = celulaAux1.cooldown[0];
                                inventario.cooldownAtual[indiceDaCelula] = celulaAux1.cooldownAtual[0];

                                inventario.indiceItem[indiceAnterior] = celulaAux2.indiceItem[0];
                                inventario.quantidade[indiceAnterior] = celulaAux2.quantidade[0];                               
                                inventario.cooldown[indiceAnterior] = celulaAux2.cooldown[0];
                                inventario.cooldownAtual[indiceAnterior] = celulaAux2.cooldownAtual[0];
                                break;
                            }

                        }
                    }
                    Debug.Log("era pra ser falso");
                    pegaCelula = false;   
                    equipAnterior = false;                   
                }


            }
            else
            {
                for (int i = 0; i < Slots[indiceAtual].GetComponent<SlotBehaviour>().typeToSubRestrict.Length; i++)
                {
                    Debug.Log("auxItem = " + inventario.indiceItem[indiceAnterior]);
                    Debug.Log("Indice Anteior 1 =" + indiceAnterior);

                    if (inventario.indiceItem[indiceAnterior]!=-1)
                    {
                        if (Slots[indiceAtual].GetComponent<SlotBehaviour>().typeToSubRestrict[i] == auxItem.Itens[inventario.indiceItem[indiceAnterior]].subTypeItem)
                        {
                            Debug.Log("Indice Anteior 2 =" + indiceAnterior);
                            Debug.Log("subTypeItem =" + auxItem.Itens[inventario.indiceItem[indiceAnterior]].subTypeItem);
                            Debug.Log("indiceItem =" + inventario.indiceItem[indiceAnterior]);

                            celulaAux2.indiceItem[0] = inventario.indiceItem[indiceDaCelula];
                            celulaAux2.quantidade[0] = inventario.quantidade[indiceDaCelula];

                            celulaAux2.cooldown[0] = inventario.cooldown[indiceDaCelula];
                            celulaAux2.cooldownAtual[0] = inventario.cooldownAtual[indiceDaCelula];

                            inventario.indiceItem[indiceDaCelula] = celulaAux1.indiceItem[0];
                            inventario.quantidade[indiceDaCelula] = celulaAux1.quantidade[0];

                            inventario.cooldown[indiceDaCelula] = celulaAux1.cooldown[0];
                            inventario.cooldownAtual[indiceDaCelula] = celulaAux1.cooldownAtual[0];

                            inventario.indiceItem[indiceAnterior] = celulaAux2.indiceItem[0];
                            inventario.quantidade[indiceAnterior] = celulaAux2.quantidade[0];
                            inventario.cooldown[indiceAnterior] = celulaAux2.cooldown[0];
                            inventario.cooldownAtual[indiceAnterior] = celulaAux2.cooldownAtual[0];
                            break;
                            //Debug.Log("troco equipamento" + celulaAux1.indiceItem[0]);

                        }

                    }
                }
                Debug.Log("era pra ser falso");
                pegaCelula = false;
 
            }
        }

       //celulaAux2.indiceItem[0] = celulaAux1.indiceItem[0];
       // celulaAux2.quantidade[0] = celulaAux1.quantidade[0];
       // celulaAux2.Aprimoramento[0] = celulaAux1.Aprimoramento[0];
       // celulaAux2.elemento[0] = celulaAux1.elemento[0];
       // celulaAux2.cooldown[0] = celulaAux1.cooldown[0];
       // celulaAux2.cooldownAtual[0] = celulaAux1.cooldownAtual[0];
        
    }

   

    public void troca(int indiceDaCelula)
    {
        celulaAux2.indiceItem[0] = inventario.indiceItem[indiceDaCelula];
        celulaAux2.quantidade[0] = inventario.quantidade[indiceDaCelula];
        celulaAux2.Aprimoramento[0] = inventario.Aprimoramento[indiceDaCelula];
        celulaAux2.elemento[0] = inventario.elemento[indiceDaCelula];
        celulaAux2.cooldown[0] = inventario.cooldown[indiceDaCelula];
        celulaAux2.cooldownAtual[0] = inventario.cooldownAtual[indiceDaCelula];

        inventario.indiceItem[indiceDaCelula] = celulaAux1.indiceItem[0];
        inventario.quantidade[indiceDaCelula] = celulaAux1.quantidade[0];
        inventario.Aprimoramento[indiceDaCelula] = celulaAux1.Aprimoramento[0];
        inventario.elemento[indiceDaCelula] = celulaAux1.elemento[0];
        inventario.cooldown[indiceDaCelula] = celulaAux1.cooldown[0];
        inventario.cooldownAtual[indiceDaCelula] = celulaAux1.cooldownAtual[0];

        inventario.indiceItem[indiceAnterior] = celulaAux2.indiceItem[0];
        inventario.quantidade[indiceAnterior] = celulaAux2.quantidade[0];
        inventario.Aprimoramento[indiceAnterior] = celulaAux2.Aprimoramento[0];
        inventario.elemento[indiceAnterior] = celulaAux2.elemento[0];
        inventario.cooldown[indiceAnterior] = celulaAux2.cooldown[0];
        inventario.cooldownAtual[indiceAnterior] = celulaAux2.cooldownAtual[0];

    }

     */

    public void JoysticMoviment()
    {


       
    }

    public void Bonusitens()
    {
        if (auxCharBaseStatus != null)
        {
            for (int i = 0; i < auxItem.Itens.Length; i++)
            {
                for (int s = 0; s < auxItem.Itens.Length; s++)
                {
                    auxCharBaseStatus.danoFisicoItens[s] = auxItem.Itens[inventario.indiceItem[s]].criticoBase;
                    auxCharBaseStatus.danoMagicoItens[s] = auxItem.Itens[inventario.indiceItem[s]].danoMagicoBase;
                    auxCharBaseStatus.defesaFisicaItens[s] = auxItem.Itens[inventario.indiceItem[s]].defesaFisicaBase;
                    auxCharBaseStatus.defesaMagicaItens[s] = auxItem.Itens[inventario.indiceItem[s]].defesaMagicaBase;

                    auxCharBaseStatus.criticoItens[s] = auxItem.Itens[inventario.indiceItem[s]].criticoBase;
                    auxCharBaseStatus.tempoRecargaItens[s] = auxItem.Itens[inventario.indiceItem[s]].tempoRecargaBase;
                    auxCharBaseStatus.velocidadeMovimentoItens[s] = auxItem.Itens[inventario.indiceItem[s]].velocidadeMovimentoBase;
                    auxCharBaseStatus.velocidadeAtaqueItens[s] = auxItem.Itens[inventario.indiceItem[s]].velocidadeAtaqueBase;

                    auxCharBaseStatus.PontosVidaItens[s] = auxItem.Itens[inventario.indiceItem[s]].PontosVida;
                    auxCharBaseStatus.PontosEssenciaItens[s] = auxItem.Itens[inventario.indiceItem[s]].PontosEssencia;
                }

            }
        }
    }



}
