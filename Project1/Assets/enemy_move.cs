using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_move : MonoBehaviour
{

    public float speed;
    public bool MoveRight;
    


    // Update is called once per frame
    void Update()
    {
        // if move right bool is true mean he is will move to the right.
        if(MoveRight) {
            transform.Translate(2 * Time.deltaTime * speed , 0,0);
            transform.localScale = new Vector2(-3,3);
        }
        else {
            transform.Translate(-2 * Time.deltaTime * speed , 0,0);
            transform.localScale = new Vector2(3,3);
           
        }
    }
    
    void OnTriggerEnter2D(Collider2D trig)
    {
        if(trig.gameObject.CompareTag("turn-patrol")){
            if(MoveRight){
                MoveRight = false;
            }
            else{
                MoveRight = true;
            }
        }
    }
}
