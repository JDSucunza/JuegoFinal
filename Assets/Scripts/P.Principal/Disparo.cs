using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
     public float rayDistance = 20f;
    public LayerMask layers;
    public float cooldown = 0.5f;
    public float _cooldown;

    private void Update(){
        if(Input.GetButtonDown("Fire1") && this._cooldown <= 0){
            this._cooldown = this.cooldown;
            RaycastHit hit;
            bool choco = Physics.Raycast(Camera.main.transform.position, this.transform.forward, out hit, this.rayDistance, this.layers);
            Debug.DrawRay(this.transform.position, this.transform.forward * this.rayDistance, Color.red, duration: 2f);
            if(choco){
                if(hit.collider.CompareTag("Enemy")){
                    Debug.Log("Choque contra un enemigo");
                }
                if(hit.collider.CompareTag("Wall")){
                    Debug.Log("Choque contra una pared");
                }
            }
        } else {
            this._cooldown -= 1 * Time.deltaTime;
        }
    }
}
