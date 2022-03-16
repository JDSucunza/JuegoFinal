using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorSonido : MonoBehaviour
{
    private Agente agent;
    public int rangoSonidosFuertes;

    public int rangoSonidosSuaves;

    private Collider[] collidersSonidosFuertes;

    private Collider [] collidedrsSonidosSuaves;

    public LayerMask layers;
    
    void Awake (){
        agent = GetComponent <Agente>();
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // El unico layer es el player por ahora.
        collidersSonidosFuertes = Physics.OverlapSphere (transform.position, rangoSonidosFuertes, layers);
        collidedrsSonidosSuaves = Physics.OverlapSphere (transform.position, rangoSonidosSuaves, layers);
        
        if (EscuchoAlPlayerCorriendo ()){
            Debug.Log ("Escuche Al Player, lo voy a buscar.");
        } else if (EscuchoCercaAlPlayer()){
                Debug.Log ("Reaccion al Player cerca.");
            }
    
    }

    

    private bool EscuchoAlPlayerCorriendo (){
        return (PlayerEnRangoCorriendo() && EstaCorriendo ());
    }
    private bool PlayerEnRangoCorriendo(){
        return (collidersSonidosFuertes.Length > 0);
    }

    private bool EstaCorriendo (){
        return (agent.playerMovimiento.corriendo);
    }

    private bool EscuchoCercaAlPlayer (){
        return (collidedrsSonidosSuaves.Length > 0);
    }

    void OnDrawGizmos (){
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere (transform.position, rangoSonidosFuertes);
        Gizmos.color = Color.black;
        Gizmos.DrawWireSphere (transform.position, rangoSonidosSuaves);
    }

}
