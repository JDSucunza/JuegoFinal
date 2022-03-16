using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PruebaRaycast : MonoBehaviour
{
    
    public float longitudRayo = 10f;

    public float radioEsfera = 10f;

    public LayerMask layers;
    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast (transform.position, Vector3.forward, out hit, 10f)){

            if (hit.transform.tag == "Player"){
                Debug.Log ("Choque con el Player");
            }
        }
    }

    void OnDrawGizmos (){
        Gizmos.color = Color.red;
        Gizmos.DrawRay (this.transform.position, transform.forward * longitudRayo);
        Gizmos.DrawWireSphere (transform.position, radioEsfera);
    }
}
