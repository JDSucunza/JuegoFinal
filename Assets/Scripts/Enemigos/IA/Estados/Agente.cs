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
    // Lista de Estados:
    [HideInInspector]
    public Idle estadoIdle;
    [HideInInspector]
    public Recorrer estadoRecorrer;
    [HideInInspector]
    public Detectar estadoDetectar;
    //--------------------------------------------------------------------------------------------
    public GameObject player;

    //Guardar ultima posicion conocida.
    
    private void Awake (){
        estadoIdle = GetComponent <Idle>();
        estadoRecorrer = GetComponent <Recorrer>();
        estadoDetectar = GetComponent <Detectar> ();
        nma = GetComponent <NavMeshAgent> ();
        anim = GetComponent <Animator> ();
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
