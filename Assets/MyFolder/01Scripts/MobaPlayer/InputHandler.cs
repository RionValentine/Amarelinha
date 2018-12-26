using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//namespace SA
//{
    public class InputHandler : MonoBehaviour
    {
    public InventarioController inventarioControle; 
       public float vertical;
       public float horizontal;

        [Header("Inputs")]
        public bool a_Input;
        public bool b_Input;
        public bool y_Input;
        public bool x_Input;

        public bool lb_Input;
        public float lt_axis;
        public bool  lt_Input;

        public bool rb_Input;
        public float rt_axis;
        public bool  rt_Input;

        public bool leftAxis_Down;
        public bool rightAxis_Down;

        public float cross_axisY;
        public bool cross_axisYUp;
        public bool cross_axisYDown;

        public float cross_axisX;
        public bool cross_axisXUp;
        public bool cross_axisXDown;

        public MenuController AuxMenuControlle;

    public float TempResposta;

   // public Targeting targting;

    public bool buttonOff;


        public bool InAnimation;
        // Use this for initialization
        void Start()
        {
        inventarioControle = GameObject.Find("GameController").GetComponent<InventarioController>();
        AuxMenuControlle = GameObject.Find("GameController").GetComponent<MenuController>();
        }

        // Update is called once per frame
        void FixedUpdate()
        {
        GetInput();
            if (!AuxMenuControlle.exibMenu)
            {                  
                UpdateStates();         
            }
        

        }

      void Update()
        {      
            if(inventarioControle==null)
            {
            inventarioControle = GameObject.Find("GameController").GetComponent<InventarioController>();
           
            }
                if (AuxMenuControlle == null)
                {           
                 AuxMenuControlle = GameObject.Find("GameController").GetComponent<MenuController>();
                }
    }


        void GetInput()
        {  

            vertical = Input.GetAxis("Vertical");
            horizontal = Input.GetAxis("Horizontal");

            b_Input = Input.GetButton("b_Input");
            a_Input = Input.GetButtonDown("a_Input");
            y_Input = Input.GetButtonDown("y_Input");
            x_Input = Input.GetButtonDown("x_Input");

            lb_Input = Input.GetButtonDown("LB_Input");
            rb_Input = Input.GetButtonDown("RB_Input");
       

          //  lb_Input = Input.GetButton("LB_Input");
          //  rb_Input = Input.GetButton("RB_Input");


         lt_axis = Input.GetAxis("LT_Input");
            lt_Input = Input.GetButton("LT_Input");
            if (lt_axis != 0)
                lt_Input = true;
           

            rt_axis = Input.GetAxis("RT_Input");
            rt_Input = Input.GetButton("RT_Input");
            if (rt_axis != 0)
                rt_Input = true;

       // cross_axisY = Input.GetAxis("cross_axisY");//Y
        if(cross_axisY > 0)
        {
            cross_axisYUp = true;
        }
        if (cross_axisY < 0)
        {
            cross_axisYDown = true;
        }
        //cross_axisX = Input.GetAxis("cross_axisX");//X
        if (cross_axisX > 0)
        {
            cross_axisXUp = true;
        }
        if (cross_axisX < 0)
        {
            cross_axisXDown = true;
        }

        rightAxis_Down = Input.GetButtonDown("RightA_Input");


           TempResposta += Time.deltaTime;

        if (TempResposta >=0.15f)
        {
            cross_axisX = Input.GetAxis("cross_axisX");//X
            cross_axisY = Input.GetAxis("cross_axisY");//Y
        }
        else
        {
            cross_axisX = 0;//X
            cross_axisY = 0;//Y
        }

        if (cross_axisX !=0 && !buttonOff)
        {
           // buttonOff = true;                           
        }

    }


    void UpdateStates()
        {  
            //playerMovimente.rollInput = b_Input;

/*                                  Olhar isso aqui
            if(!InAnimation)
            {
                playerMovimente.a = a_Input;
                playerMovimente.b = b_Input;
                playerMovimente.y = y_Input;
                playerMovimente.x = x_Input;
                playerMovimente.lb = lb_Input;
                playerMovimente.lt = lt_Input;
                playerMovimente.rb = rb_Input;
                playerMovimente.rt = rt_Input;
                playerMovimente.rightAxis= rightAxis_Down;
                playerMovimente.leftAxis = leftAxis_Down;
            }
            */



           if(rightAxis_Down)
            {
           // playerMovimente.LockOn = !playerMovimente.LockOn;
            //targting.TargetEnemy();
            //targting.AuxMovimente.LockOn = !targting.AuxMovimente.LockOn;
            }
        }
}
//}