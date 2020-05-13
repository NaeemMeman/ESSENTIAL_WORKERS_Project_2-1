using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public Sprite finishFlag;
    private SpriteRenderer finishSpriteRenderer;
    public bool finishReached;
    public string nextLevel;

    // Start is called before the first frame update
    void Start()
    {
        finishSpriteRenderer=GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Player"){
            Application.LoadLevel(nextLevel);
        }
    }
}




