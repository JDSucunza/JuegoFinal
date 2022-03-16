using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnRangoDeVision : MonoBehaviour
{
    
    public LayerMask layers;
    private Agente agent;

    public int distanciaVision;
    public float anguloDeVision = 0.5f;

    void Awake (){
        this.agent = GetComponent <Agente> ();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (EstaEnAnguloDeVision()){
            Debug.Log ("El player esta en angulo de vision");
        }
    }

    private bool EstaEnAnguloDeVision (){
        Vector3 vectorApj = this.agent.player.transform.position - this.transform.position;
        vectorApj.Normalize();
        float dot = Vector3.Dot (this.transform.forward, vectorApj);
        Collider[] colliders = Physics.OverlapSphere (this.transform.position, this.distanciaVision, this.layers);
        return (dot > anguloDeVision && colliders.Length > 0);

    }


}
