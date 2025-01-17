using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Buscar : MonoBehaviour
{
    [HideInInspector]
    public Agente agent;
    // Start is called before the first frame update
    
    void OnEnable (){
        //Sonido cuando empiezo a buscar.
        //No activa las animaciones.
        this.agent.estadoIdle.enabled = false; 
        this.agent.estadoRecorrer.enabled = false;
        this.agent.anim.SetBool ("CrouchedWalk", true);
        this.agent.anim.SetBool ("Idle", false);
        this.agent.nma.SetDestination (agent.player.transform.position);
    }
    void Awake (){
        agent = GetComponent <Agente> ();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
