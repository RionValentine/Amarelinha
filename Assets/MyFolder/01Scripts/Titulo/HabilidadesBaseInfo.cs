using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



[System.Serializable]
public class Habilidade
{
    public string HabilidadeNome;
    public int custoCompra;

    public int indice;
    public Sprite iconBase;
    public string Descricao;

    
}



public class HabilidadesBaseInfo : MonoBehaviour
{
    public Habilidade[] habilidades;
    public Vector3 posicaoInstanciar ;
    public GameObject  habilidadeInstanciado   ;





    // Use this for initialization
    void Start()
    {
        ListadeHabilidades();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ListadeHabilidades()
    {
        for (int i = 0; i < habilidades.Length; i++)
        {
            ///////////////////////////////////////////////////////////////////////////////////////////////
            habilidades[i].indice = i;
            habilidades[i].HabilidadeNome = "Absorção de Critico";
            habilidades[i].iconBase = Resources.Load<Sprite>("Habilidades/" + habilidades[i].HabilidadeNome);
            habilidades[i].custoCompra = 0;

            habilidades[i].Descricao = "Adiciona o nível do personagem x5 em porcentagem de redução de dano critico (máx. +50%).";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            habilidades[i].indice = i;
            habilidades[i].HabilidadeNome = "Anti-Magia";
            habilidades[i].iconBase = Resources.Load<Sprite>("Habilidades/" + habilidades[i].HabilidadeNome);
            habilidades[i].custoCompra = 300;

            habilidades[i].Descricao = "Adiciona o nível do personagem em bônus para resistir a todo tipo de magia que exija teste (máx. +20).";
            i++;           

            ///////////////////////////////////////////////////////////////////////////////////////////////
            habilidades[i].indice = i;
            habilidades[i].HabilidadeNome = "Aprimoramento Arcano";
            habilidades[i].iconBase = Resources.Load<Sprite>("Habilidades/" + habilidades[i].HabilidadeNome);
            habilidades[i].custoCompra = 300;

            habilidades[i].Descricao = "O personagem pode evoluir uma magia gastando ações e mana extra igual ao  nível do personagem.";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            habilidades[i].indice = i;
            habilidades[i].HabilidadeNome = "Armas Gemeas";
            habilidades[i].iconBase = Resources.Load<Sprite>("Habilidades/" + habilidades[i].HabilidadeNome);
            habilidades[i].custoCompra = 300;

            habilidades[i].Descricao = "Personagem ganha um ataque extra e dano quando usar uma arma leve em cada mão.";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            habilidades[i].indice = i;
            habilidades[i].HabilidadeNome = "Ataque Furtivo";
            habilidades[i].iconBase = Resources.Load<Sprite>("Habilidades/" + habilidades[i].HabilidadeNome);
            habilidades[i].custoCompra = 300;

            habilidades[i].Descricao = "Quando desferir um ataque furtivo,  adiciona +1 dado da arma a cada 10 níveis do personagem.";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            habilidades[i].indice = i;
            habilidades[i].HabilidadeNome = "Aumento de Evasão";
            habilidades[i].iconBase = Resources.Load<Sprite>("Habilidades/" + habilidades[i].HabilidadeNome);
            habilidades[i].custoCompra = 300;

            habilidades[i].Descricao = "Adiciona o nível do personagem em testes de esquiva (máx. +20).";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            habilidades[i].indice = i;
            habilidades[i].HabilidadeNome = "Aumento de Mana";
            habilidades[i].iconBase = Resources.Load<Sprite>("Habilidades/" + habilidades[i].HabilidadeNome);
            habilidades[i].custoCompra = 300;

            habilidades[i].Descricao = "Adiciona o nível do personagem em bônus de mana Extra.";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            habilidades[i].indice = i;
            habilidades[i].HabilidadeNome = "Aumento de Vitalidade";
            habilidades[i].iconBase = Resources.Load<Sprite>("Habilidades/" + habilidades[i].HabilidadeNome);
            habilidades[i].custoCompra = 300;

            habilidades[i].Descricao = "Adiciona o nível do personagem em bônus de Vida Extra.";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            habilidades[i].indice = i;
            habilidades[i].HabilidadeNome = "Aura do Coração de Ferro";
            habilidades[i].iconBase = Resources.Load<Sprite>("Habilidades/" + habilidades[i].HabilidadeNome);
            habilidades[i].custoCompra = 300;

            habilidades[i].Descricao = "Adiciona o nível do personagem em bônus nos testes de Vontade em uma área a volta do personagem (máx. +20).";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            habilidades[i].indice = i;
            habilidades[i].HabilidadeNome = "Auxilio";
            habilidades[i].iconBase = Resources.Load<Sprite>("Habilidades/" + habilidades[i].HabilidadeNome);
            habilidades[i].custoCompra = 300;

            habilidades[i].Descricao = "Adiciona o nível do personagem em bônus de movimento para ir até um aliado ferido (máx. +20).";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            habilidades[i].indice = i;
            habilidades[i].HabilidadeNome = "Banquete Sordido";
            habilidades[i].iconBase = Resources.Load<Sprite>("Habilidades/" + habilidades[i].HabilidadeNome);
            habilidades[i].custoCompra = 300;

            habilidades[i].Descricao = "caso a vida e mana estiverem cheia ao Consumir um corpo pode armazena pontos de acescência igual o nível .";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            habilidades[i].indice = i;
            habilidades[i].HabilidadeNome = "Caça Predileta";
            habilidades[i].iconBase = Resources.Load<Sprite>("Habilidades/" + habilidades[i].HabilidadeNome);
            habilidades[i].custoCompra = 300;

            habilidades[i].Descricao = "Ganha bônus sobre criaturas com descrição animal ou Bestas";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            habilidades[i].indice = i;
            habilidades[i].HabilidadeNome = "Companheiro Animal";
            habilidades[i].iconBase = Resources.Load<Sprite>("Habilidades/" + habilidades[i].HabilidadeNome);
            habilidades[i].custoCompra = 300;

            habilidades[i].Descricao = "Treinar um animal para ser seu companheiro de caça, o animal deve ter nível igual o menos do personagem.";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            habilidades[i].indice = i;
            habilidades[i].HabilidadeNome = "Comunhão com Abismo";
            habilidades[i].iconBase = Resources.Load<Sprite>("Habilidades/" + habilidades[i].HabilidadeNome);
            habilidades[i].custoCompra = 300;

            habilidades[i].Descricao = "O personagem consegue utilizar o caminho magico trevas.";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            habilidades[i].indice = i;
            habilidades[i].HabilidadeNome = "Comunhão Magica";
            habilidades[i].iconBase = Resources.Load<Sprite>("Habilidades/" + habilidades[i].HabilidadeNome);
            habilidades[i].custoCompra = 300;

            habilidades[i].Descricao = "Adiciona o nível do personagem /2 em bônus de um caminho magico escolhido (máx. +10).";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            habilidades[i].indice = i;
            habilidades[i].HabilidadeNome = "Contra Ataque";
            habilidades[i].iconBase = Resources.Load<Sprite>("Habilidades/" + habilidades[i].HabilidadeNome);
            habilidades[i].custoCompra = 300;

            habilidades[i].Descricao = "O personagem pode realizar um teste de ataque depois de ser bem-sucedido em um teste de aparar (máx. +20).";
            i++; 

            ///////////////////////////////////////////////////////////////////////////////////////////////
            habilidades[i].indice = i;
            habilidades[i].HabilidadeNome = "Criar Armadura";
            habilidades[i].iconBase = Resources.Load<Sprite>("Habilidades/" + habilidades[i].HabilidadeNome);
            habilidades[i].custoCompra = 300;

            habilidades[i].Descricao = "Adiciona o nível do personagem em bônus dano com armas de Fogo (máx. +20).";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            habilidades[i].indice = i;
            habilidades[i].HabilidadeNome = "Criação Aprimorada";
            habilidades[i].iconBase = Resources.Load<Sprite>("Habilidades/" + habilidades[i].HabilidadeNome);
            habilidades[i].custoCompra = 300;

            habilidades[i].Descricao = "Adiciona o nível do personagem nos testes para criação de um tipo de item (máx. +20).";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            habilidades[i].indice = i;
            habilidades[i].HabilidadeNome = "Critico Devastador";
            habilidades[i].iconBase = Resources.Load<Sprite>("Habilidades/" + habilidades[i].HabilidadeNome);
            habilidades[i].custoCompra = 300;

            habilidades[i].Descricao = "Adiciona o nível em bônus em porcentagem no dano critico (máx. +20%), e faz o inimigo ficar atordoado.";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            habilidades[i].indice = i;
            habilidades[i].HabilidadeNome = "Critico Potente";
            habilidades[i].iconBase = Resources.Load<Sprite>("Habilidades/" + habilidades[i].HabilidadeNome);
            habilidades[i].custoCompra = 300;

            habilidades[i].Descricao = "Adiciona o nível do personagem x5 em porcentagem de dano critico (máx. +50%).";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            habilidades[i].indice = i;
            habilidades[i].HabilidadeNome = "Familiar";
            habilidades[i].iconBase = Resources.Load<Sprite>("Habilidades/" + habilidades[i].HabilidadeNome);
            habilidades[i].custoCompra = 300;

            habilidades[i].Descricao = "O personagem tem uma criatura magica que o obedece, criado através de um ritual. ";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            habilidades[i].indice = i;
            habilidades[i].HabilidadeNome = "Foco Elemental";
            habilidades[i].iconBase = Resources.Load<Sprite>("Habilidades/" + habilidades[i].HabilidadeNome);
            habilidades[i].custoCompra = 300;

            habilidades[i].Descricao = "";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            habilidades[i].indice = i;
            habilidades[i].HabilidadeNome = "Furia Elevada";
            habilidades[i].iconBase = Resources.Load<Sprite>("Habilidades/" + habilidades[i].HabilidadeNome);
            habilidades[i].custoCompra = 300;

            habilidades[i].Descricao = "Adiciona o nível do personagem /2 em bônus dano e IPF quando estiver com a fúria ativa.";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            habilidades[i].indice = i;
            habilidades[i].HabilidadeNome = "Gran Fortitude";
            habilidades[i].iconBase = Resources.Load<Sprite>("Habilidades/" + habilidades[i].HabilidadeNome);
            habilidades[i].custoCompra = 300;

            habilidades[i].Descricao = "Adiciona o nível do personagem /2 em bônus de um para dificultar receber critico (máx. +5).";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            habilidades[i].indice = i;
            habilidades[i].HabilidadeNome = "Habilidoso";
            habilidades[i].iconBase = Resources.Load<Sprite>("Habilidades/" + habilidades[i].HabilidadeNome);
            habilidades[i].custoCompra = 300;

            habilidades[i].Descricao = "Adiciona o nível do personagem em bônus nos testes de operar Mecanismo (máx. +20).";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            habilidades[i].indice = i;
            habilidades[i].HabilidadeNome = "Investida Ninja";
            habilidades[i].iconBase = Resources.Load<Sprite>("Habilidades/" + habilidades[i].HabilidadeNome);
            habilidades[i].custoCompra = 300;

            habilidades[i].Descricao = "Adiciona o nível do personagem em bônus para se mover até o alvo que tenha uma marca.";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            habilidades[i].indice = i;
            habilidades[i].HabilidadeNome = "Ligação Espiritual";
            habilidades[i].iconBase = Resources.Load<Sprite>("Habilidades/" + habilidades[i].HabilidadeNome);
            habilidades[i].custoCompra = 300;

            habilidades[i].Descricao = "Adiciona o nível do personagem em bônus para ultrapassar o nível máximo de suas magias (máx. +20).";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            habilidades[i].indice = i;
            habilidades[i].HabilidadeNome = "Marca Arcana";
            habilidades[i].iconBase = Resources.Load<Sprite>("Habilidades/" + habilidades[i].HabilidadeNome);
            habilidades[i].custoCompra = 300;

            habilidades[i].Descricao = "Se houver algum inimigo perto do alvo que desferiu um ataque, eles serão marcados e receberam mais dano";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            habilidades[i].indice = i;
            habilidades[i].HabilidadeNome = "Memoria Onirica";
            habilidades[i].iconBase = Resources.Load<Sprite>("Habilidades/" + habilidades[i].HabilidadeNome);
            habilidades[i].custoCompra = 300;

            habilidades[i].Descricao = "Adiciona o nível do personagem em teste de conhecimento ou para lembrar de algo (máx. +20).";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            habilidades[i].indice = i;
            habilidades[i].HabilidadeNome = "Mente Potente";
            habilidades[i].iconBase = Resources.Load<Sprite>("Habilidades/" + habilidades[i].HabilidadeNome);
            habilidades[i].custoCompra = 300;

            habilidades[i].Descricao = "Adiciona o nível do personagem para resistir a controles mentais (máx. +20).";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            habilidades[i].indice = i;
            habilidades[i].HabilidadeNome = "Metamorfose I";
            habilidades[i].iconBase = Resources.Load<Sprite>("Habilidades/" + habilidades[i].HabilidadeNome);
            habilidades[i].custoCompra = 300;

            habilidades[i].Descricao = "Permite que o druida tenha a forma de um animal de pequeno ou médio porte.";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            habilidades[i].indice = i;
            habilidades[i].HabilidadeNome = "Movimento Estendido";
            habilidades[i].iconBase = Resources.Load<Sprite>("Habilidades/" + habilidades[i].HabilidadeNome);
            habilidades[i].custoCompra = 300;

            habilidades[i].Descricao = "Adiciona o nível/5 do personagem em bônus de movimento (máx. +20).";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            habilidades[i].indice = i;
            habilidades[i].HabilidadeNome = "Foco em Adaga";
            habilidades[i].iconBase = Resources.Load<Sprite>("Habilidades/" + habilidades[i].HabilidadeNome);
            habilidades[i].custoCompra = 300;

            habilidades[i].Descricao = "Adiciona o nível do personagem em bônus dano com armas de pequeno porte (máx. +20).";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            habilidades[i].indice = i;
            habilidades[i].HabilidadeNome = "Foco em Arma";
            habilidades[i].iconBase = Resources.Load<Sprite>("Habilidades/" + habilidades[i].HabilidadeNome);
            habilidades[i].custoCompra = 300;

            habilidades[i].Descricao = "Adiciona o nível do personagem no dano com Armas em geral";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            habilidades[i].indice = i;
            habilidades[i].HabilidadeNome = "Foco em Arma a Distancia";
            habilidades[i].iconBase = Resources.Load<Sprite>("Habilidades/" + habilidades[i].HabilidadeNome);
            habilidades[i].custoCompra = 300;

            habilidades[i].Descricao = "Adiciona o nível do personagem no dano com Armas de Longo alcance como Arcos e bestas (máx. +20).";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            habilidades[i].indice = i;
            habilidades[i].HabilidadeNome = "Foco em Arma de Haste";
            habilidades[i].iconBase = Resources.Load<Sprite>("Habilidades/" + habilidades[i].HabilidadeNome);
            habilidades[i].custoCompra = 300;

            habilidades[i].Descricao = "Adiciona o nível do personagem no dano com Armas de haste tipo Lanças Martelo de duas mãos";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            habilidades[i].indice = i;
            habilidades[i].HabilidadeNome = "Foco em Arma Mistica";
            habilidades[i].iconBase = Resources.Load<Sprite>("Habilidades/" + habilidades[i].HabilidadeNome);
            habilidades[i].custoCompra = 300;

            habilidades[i].Descricao = "Adiciona o nível do personagem em bônus dano com armas de pequeno porte (máx. +20).";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            habilidades[i].indice = i;
            habilidades[i].HabilidadeNome = "Foco em Arma sem Corte";
            habilidades[i].iconBase = Resources.Load<Sprite>("Habilidades/" + habilidades[i].HabilidadeNome);
            habilidades[i].custoCompra = 300;

            habilidades[i].Descricao = "Adiciona o nível do personagem no dano com Armas sem corte como Massas e materlos(máx. +20).";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            habilidades[i].indice = i;
            habilidades[i].HabilidadeNome = "Foco em Armadura Leve";
            habilidades[i].iconBase = Resources.Load<Sprite>("Habilidades/" + habilidades[i].HabilidadeNome);
            habilidades[i].custoCompra = 300;

            habilidades[i].Descricao = "Adiciona o nível do personagem em bônus de IPF de Robes Magicos e Tunicas (máx. +20).";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            habilidades[i].indice = i;
            habilidades[i].HabilidadeNome = "Foco em Armadura Media";
            habilidades[i].iconBase = Resources.Load<Sprite>("Habilidades/" + habilidades[i].HabilidadeNome);
            habilidades[i].custoCompra = 300;

            habilidades[i].Descricao = "Adiciona o nível do personagem em bônus de IPF de armaduras Leves (máx. +20).";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            habilidades[i].indice = i;
            habilidades[i].HabilidadeNome = "Foco em Armadura Pesada";
            habilidades[i].iconBase = Resources.Load<Sprite>("Habilidades/" + habilidades[i].HabilidadeNome);
            habilidades[i].custoCompra = 300;

            habilidades[i].Descricao = "Adiciona o nível do personagem em bônus de IPF de armaduras pesadas (máx. +20).";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            habilidades[i].indice = i;
            habilidades[i].HabilidadeNome = "Foco em Escudo";
            habilidades[i].iconBase = Resources.Load<Sprite>("Habilidades/" + habilidades[i].HabilidadeNome);
            habilidades[i].custoCompra = 300;

            habilidades[i].Descricao = "Adiciona o nível do personagem em bônus nos testes de apara ou bloquear com escudo (máx. +20).";
            i++;


            ///////////////////////////////////////////////////////////////////////////////////////////////
            habilidades[i].indice = i;
            habilidades[i].HabilidadeNome = "Foco em Espada";
            habilidades[i].iconBase = Resources.Load<Sprite>("Habilidades/" + habilidades[i].HabilidadeNome);
            habilidades[i].custoCompra = 300;

            habilidades[i].Descricao = "Adiciona o nível do personagem no dano com Espada (máx. +20).";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            habilidades[i].indice = i;
            habilidades[i].HabilidadeNome = "Foco em Manopla";
            habilidades[i].iconBase = Resources.Load<Sprite>("Habilidades/" + habilidades[i].HabilidadeNome);
            habilidades[i].custoCompra = 300;

            habilidades[i].Descricao = "Adiciona o nível do personagem nos testes de ataque Corpo a corpo (máx. +20).";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            habilidades[i].indice = i;
            habilidades[i].HabilidadeNome = "Piloto";
            habilidades[i].iconBase = Resources.Load<Sprite>("Habilidades/" + habilidades[i].HabilidadeNome);
            habilidades[i].custoCompra = 300;

            habilidades[i].Descricao = "Adiciona o nível do personagem em bônus para pilotar um tipo bônus entra nos testes de condução (máx. +20).";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            habilidades[i].indice = i;
            habilidades[i].HabilidadeNome = "Queda Lenta";
            habilidades[i].iconBase = Resources.Load<Sprite>("Habilidades/" + habilidades[i].HabilidadeNome);
            habilidades[i].custoCompra = 300;

            habilidades[i].Descricao = "Adiciona o nível em metros para cair sem tomar dano (máx. +20).";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            habilidades[i].indice = i;
            habilidades[i].HabilidadeNome = "Rastreamento Aprimorado";
            habilidades[i].iconBase = Resources.Load<Sprite>("Habilidades/" + habilidades[i].HabilidadeNome);
            habilidades[i].custoCompra = 300;

            habilidades[i].Descricao = "Adiciona o nível do personagem em bônus nos testes de rastrear (máx. +20).";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            habilidades[i].indice = i;
            habilidades[i].HabilidadeNome = "Recolher Flecha";
            habilidades[i].iconBase = Resources.Load<Sprite>("Habilidades/" + habilidades[i].HabilidadeNome);
            habilidades[i].custoCompra = 300;

            habilidades[i].Descricao = "Faz com que o personagem faça seus ataques de forma que  possa reutilizar as fechas disparadas.";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            habilidades[i].indice = i;
            habilidades[i].HabilidadeNome = "Recuperação de Mana";
            habilidades[i].iconBase = Resources.Load<Sprite>("Habilidades/" + habilidades[i].HabilidadeNome);
            habilidades[i].custoCompra = 300;

            habilidades[i].Descricao = "Adiciona o nível do personagem em bônus na recuperação de mana.";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            habilidades[i].indice = i;
            habilidades[i].HabilidadeNome = "Salto Potente";
            habilidades[i].iconBase = Resources.Load<Sprite>("Habilidades/" + habilidades[i].HabilidadeNome);
            habilidades[i].custoCompra = 300;

            habilidades[i].Descricao = "Adiciona o nível do personagem em bônus em teste e em metros de salto (máx. +20).";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            habilidades[i].indice = i;
            habilidades[i].HabilidadeNome = "Santuario";
            habilidades[i].iconBase = Resources.Load<Sprite>("Habilidades/" + habilidades[i].HabilidadeNome);
            habilidades[i].custoCompra = 300;

            habilidades[i].Descricao = "Cria uma aura que protege uma área absorvendo nível do personagem x Auto-Controle em dano.";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            habilidades[i].indice = i;
            habilidades[i].HabilidadeNome = "Semente";
            habilidades[i].iconBase = Resources.Load<Sprite>("Habilidades/" + habilidades[i].HabilidadeNome);
            habilidades[i].custoCompra = 300;

            habilidades[i].Descricao = "Permite que coloque sementes em locais estratégicos para usar as habilidades de druida.";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            habilidades[i].indice = i;
            habilidades[i].HabilidadeNome = "Sentidos Agulçados";
            habilidades[i].iconBase = Resources.Load<Sprite>("Habilidades/" + habilidades[i].HabilidadeNome);
            habilidades[i].custoCompra = 300;

            habilidades[i].Descricao = "Adiciona o nível do personagem nos testes de um sentido (máx. +20).";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            habilidades[i].indice = i;
            habilidades[i].HabilidadeNome = "Sorte";
            habilidades[i].iconBase = Resources.Load<Sprite>("Habilidades/" + habilidades[i].HabilidadeNome);
            habilidades[i].custoCompra = 300;

            habilidades[i].Descricao = "Adiciona o nível do personagem em bônus nas rolagens de tesouro deixado por monstros (máx. +20).";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            habilidades[i].indice = i;
            habilidades[i].HabilidadeNome = "Sustentação Superior";
            habilidades[i].iconBase = Resources.Load<Sprite>("Habilidades/" + habilidades[i].HabilidadeNome);
            habilidades[i].custoCompra = 300;

            habilidades[i].Descricao = "Adiciona o nível do personagem na Sustentação Corporal em Quilos (máx. +20).";
            i++;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            habilidades[i].indice = i;
            habilidades[i].HabilidadeNome = "Visão Cadaverica";
            habilidades[i].iconBase = Resources.Load<Sprite>("Habilidades/" + habilidades[i].HabilidadeNome);
            habilidades[i].custoCompra = 300;

            habilidades[i].Descricao = "Poder ver os inimigos que estiverem abaixo da metade dos pontos de vida e criaturas não vivas.";
            
        }
    }
 }
