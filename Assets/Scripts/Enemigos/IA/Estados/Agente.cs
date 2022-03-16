using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Agente : MonoBehaviour
{
    [HideInInspector]
    public NavMeshAgent nma;
   
    [HideInInspector]
    public Animator anim;
    //--------------------------------------------------------------------------------------------
    // Sensores:
    [HideInInspector]
    public DetectorSonido detectarSonido; 
    //--------------------------------------------------------------------------------------------
    // Estados:
    [HideInInspector]
    public Idle estadoIdle;
    [HideInInspector]
    public Recorrer estadoRecorrer;
    [HideInInspector]
    public IdleAlerta estadoIdleAlerta;
    //--------------------------------------------------------------------------------------------
    //Player:
    [HideInInspector]
    public GameObject player;
    //[HideInInspector]
    //public PlayerController playerController;
    
    //public RaycastFollowPlayer raycastFollowPlayer;
    
    public bool rayoPegoAlPlayer = false;

    
    [HideInInspector]
    public Movimiento playerMovimiento;
    
    
    private void Awake (){
      
      this.nma = GetComponent <NavMeshAgent> ();
      this.anim = GetComponent <Animator> ();
      //--------------------------------------------------------------------------------------------
      //Sensores:
      this.detectarSonido = GetComponent <DetectorSonido> ();

      //--------------------------------------------------------------------------------------------
      //Estados:
      this.estadoIdleAlerta = GetComponent <IdleAlerta> ();
      this.estadoIdle = GetComponent <Idle>();
      this.estadoRecorrer = GetComponent <Recorrer>();
      //--------------------------------------------------------------------------------------------
      //Player:
      
      this.player = GameObject.FindGameObjectWithTag ("Player");
      
      //  this.playerController = GetComponent <PlayerController> ();
      // this.raycastFollowPlayer = GetComponentInChildren <RaycastFollowPlayer> ();
      this.playerMovimiento = player.GetComponent <Movimiento> ();
      
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
