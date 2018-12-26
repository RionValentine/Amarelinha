using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MobaMovimentePlayer : MonoBehaviour {

    public GameObject alvoAtq;
    public GameObject meshChar;
    public float speedMovimenteCurrent;
    public float speedMovimente;
    public float walkRange;
    public Transform newPosition;
    public float speedRot = 0.02f;
    public bool button1;
    public bool button0;
    public Animator anim;
    
    public int animAtual;
    public float magnitude;
    public bool skill1;
    public bool skill2;
    public bool skill3;
    public bool ult;

    public RuntimeAnimatorController[] animators;
    public AnimatorClipInfo[] clip;
    public CharBaseStatus auxCharBaseStatus;
    public float encremento;
    //public InputHandler auxInputHandler;
    public NavMeshAgent agent;
    public GameObject centro;
    public GameObject point;
    public bool incapacidato;

    public bool ataqueBasico;
    public Animation aniim;
    // Use this for initialization
    void Start () {
        newPosition = this.transform;
        MovimentHero();
        anim.runtimeAnimatorController = animators[animAtual];
        
    }
	
	// Update is called once per frame
	void Update ()
    {
        agent.destination = newPosition.transform.position;
        MovimentHero();
        ClickAndMovementeHero();
        SkillController();
        CombatController();
       // Debug.Log("Nome da Animação" + anim.GetCurrentAnimatorStateInfo(0).IsName("AtaqueBase1"));
    }

    public void MovimentHero()
    {
        anim.SetFloat("Magnitude", magnitude);
        anim.SetBool("AtaqueBasico", ataqueBasico);
        anim.SetBool("Incapacidato", incapacidato);        

        if (Vector3.Distance(newPosition.transform.position, this.transform.position) > walkRange && !incapacidato && !ataqueBasico)
            {
                if (auxCharBaseStatus.velocidadeMovimento < 5.1f)
                {
                    speedMovimenteCurrent = 8;
                    magnitude = 1;
                }

                if (auxCharBaseStatus.velocidadeMovimento > 5 && auxCharBaseStatus.velocidadeMovimento < 10)
                {
                    speedMovimenteCurrent = 12;
                    magnitude = 2;
                }

                if (auxCharBaseStatus.velocidadeMovimento > 10)
                {
                    speedMovimenteCurrent = 20;
                    magnitude = 3;
                }
            }
            else 
            {              
                magnitude = 0;
                speedMovimenteCurrent= 0;
            }
     
           
            if (alvoAtq != null)
            {
            if (Vector3.Distance(alvoAtq.transform.position, this.transform.position) < (auxCharBaseStatus.ataqueRange + encremento) && !incapacidato)
                {
                    ataqueBasico = true;
                Quaternion transRot2 = Quaternion.LookRotation(newPosition.transform.position - this.transform.position, Vector3.up);
                transRot2.x = 0;
                transRot2.z = 0;
               transform.rotation = Quaternion.Slerp(transRot2, transform.rotation, speedRot);

            }
            else
                {
                    ataqueBasico = false;
                }
            }
            else
            {
                if (!anim.GetCurrentAnimatorStateInfo(0).IsName("AtaqueBase1") || !anim.GetCurrentAnimatorStateInfo(0).IsName("AtaqueBase2"))
                {
                  //  Debug.Log("AtaqueBase1 Cancelado");
                    ataqueBasico = false;
                }
            }

        

       

        agent.speed = speedMovimenteCurrent;
        // Quaternion transRot2 = Quaternion.LookRotation(newPosition - this.transform.position, Vector3.up);
        //  transRot2.x = 0;
        // transRot2.z = 0;
        // meshChar.transform.rotation = Quaternion.Slerp(transRot2, meshChar.transform.rotation, speedRot);
    }

    public void ClickAndMovementeHero()
    {
        bool RMB = Input.GetMouseButton(1);
        button1 = RMB;
        if (RMB)
        {
            alvoAtq = null;
            ataqueBasico = false;
            //anim.Stop();

            anim.Play("Movimento", 0,0f);
   
             
         
            walkRange = 2;
            RaycastHit hit;
            
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hit) && hit.transform.tag =="Ground")
            {
                //newPosition = hit.transform;
                Debug.Log("clicou terreno");
                GameObject newpoint = Instantiate(point, hit.point, transform.rotation);
                newPosition = newpoint.transform;
            }
        }
    }

    public void SkillController()
    {
        clip = anim.GetCurrentAnimatorClipInfo(0);
        if (clip == null)
        {
            Debug.Log("nao tem animação");
        }
        // Debug.Log(clip[0].clip.name);
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("Skill1"))
        {
            Debug.Log("Skill1");
            skill1 = false;                
        }
       
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("Skill2"))
        {
            Debug.Log("Skill2");
            skill2 = false;
        }
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("Skill3"))
        {
            Debug.Log("Skill3");
            skill3 = false;
        }
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("Ult"))
        {
            Debug.Log("Skill4");
            ult = false;
        }


        if (Input.GetButtonDown("Skill1"))
        {
            skill1 = true;
        }

        if (Input.GetButtonDown("Skill2"))
        {
            skill2 = true;
        }

        if (Input.GetButtonDown("Skill3"))
        {
            skill3 = true;
        }

        if (Input.GetButtonDown("Skill4"))
        {
            ult = true;
        }

        anim.SetBool("Skill1", skill1);
        anim.SetBool("Skill2", skill2);
        anim.SetBool("Skill3", skill3);
        anim.SetBool("Ult", ult);

        if (anim.GetCurrentAnimatorStateInfo(0).IsName("Skill1") || anim.GetCurrentAnimatorStateInfo(0).IsName("Skill2") || anim.GetCurrentAnimatorStateInfo(0).IsName("Skill3") || anim.GetCurrentAnimatorStateInfo(0).IsName("ult") || anim.GetCurrentAnimatorStateInfo(0).IsName("AtaqueBase1") || anim.GetCurrentAnimatorStateInfo(0).IsName("AtaqueBase2"))
        {
            
            incapacidato = true;
        }
        else
        {
            incapacidato = false;
        }
        /*
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("AtaqueBase1") "_Skill1") || clip[0].clip.name == (auxCharBaseStatus.nameChamp + "_Skill2") || clip[0].clip.name == (auxCharBaseStatus.nameChamp + "_Skill3") || clip[0].clip.name == (auxCharBaseStatus.nameChamp + "_Ult") )
        {
            anim.GetCurrentAnimatorStateInfo(0).IsName("AtaqueBase1")
            incapacidato = true;
        }
        else
        {
            incapacidato = false;           
        }
        */
    }

    public void Incapacitadores()
    {

    }

    public void CombatController()
    {



        bool LMB = Input.GetMouseButtonDown(0);
        button0 = LMB;
        if (LMB)
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

           // walkRange = auxCharBaseStatus.ataqueDistance;

            if (Physics.Raycast(ray, out hit) && hit.transform.tag == "Player")
            {               
                Debug.Log("clicou Jogador");

                if(hit.transform.GetComponent<CapsuleCollider>())
                {
                    Debug.Log("tem capsule colider");
                    encremento = ((hit.transform.localScale.x + hit.transform.localScale.z) / 2) + 1f;
                }

                if (hit.transform.GetComponent<BoxCollider>())
                {
                    Debug.Log("tem Box colider");
                    encremento = ((hit.transform.localScale.x + hit.transform.localScale.z) / 2) + 1f;
                }

                // newPosition = hit.point;
                // GameObject newpoint = Instantiate(point, hit.point+new Vector3(1,1,1), transform.rotation);
                  alvoAtq = hit.transform.gameObject;
                  newPosition = hit.transform;
                Debug.Log("clicou Jogador");
            }
        }



    }



    public void LateUpdate()
    {
        centro.transform.position = this.transform.position;
    }
}
