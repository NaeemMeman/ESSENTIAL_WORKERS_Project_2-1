using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bombscript : MonoBehaviour
{
    private PlayerController gamePlayer;
    // Start is called before the first frame update
    void Start()
    {
        gamePlayer= GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("Player")){
            StartCoroutine(gamePlayer.Knockback(0.02f, 100, gamePlayer.transform.position));
        }
    }
}
