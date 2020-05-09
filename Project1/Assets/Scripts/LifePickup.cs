using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifePickup : MonoBehaviour
{
    public int LifeToAdd;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.GetComponent<PlayerController> () == null)
            return;

        LifeManage.AddLife (LifeToAdd);
        
    }
}
