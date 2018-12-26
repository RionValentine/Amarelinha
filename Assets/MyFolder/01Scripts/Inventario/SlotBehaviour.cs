using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SlotBehaviour : MonoBehaviour {
    //public TYPE_ITEM typeToRestrict;
    public bool SlotEquip;
    public bool SlotShopping;
    public int indiceSlot;

    public int indiceItem;
    public int quantidadeItem;

    public int[] itenscraft;
    public int[] qntCraft;

    public int itemcraftFinal;
    public int qntCraftFinal;

    public InventarioController AuxInventarioController;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    public void TrocaItem()
    {
        
        if(!AuxInventarioController.pegaCelula)
        {
            AuxInventarioController.indiceAnterior = indiceSlot;
            
        }    
            
        AuxInventarioController.FPegaCelula(AuxInventarioController.inventario.indiceItem[AuxInventarioController.indiceAtual], AuxInventarioController.inventario.quantidade[AuxInventarioController.indiceAtual], AuxInventarioController.inventario.cooldownAtual[AuxInventarioController.indiceAtual], AuxInventarioController.indiceAtual);

        if (!AuxInventarioController.pegaCelula)
        {

            AuxInventarioController.pegaCelula = true;
           
        }


    }

    public void indiceSlotAtual()
    {
        Debug.Log("" + indiceSlot);
        AuxInventarioController.indiceAtual = indiceSlot;
    }
}