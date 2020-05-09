using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpSpeed =5f;
    public float speed = 5f;
    private float movement = 0f;
    private Rigidbody2D rigidBody;

    public Transform groundCheckPoint;
    public float groundCheckRadius;
    public LayerMask groundLayer;
    
    private bool isTouchingGround;
    private Animator playerAnimation;
    public Vector3 respawnPoint;
    public LevelManager gameLevelManager;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody=GetComponent<Rigidbody2D> ();
        playerAnimation=GetComponent<Animator> ();
        respawnPoint=transform.position;
        gameLevelManager=FindObjectOfType<LevelManager> ();
    }

    // Update is called once per frame
    void Update()
    {
        isTouchingGround = Physics2D.OverlapCircle (groundCheckPoint.position, groundCheckRadius, groundLayer);
        movement= Input.GetAxis ("Horizontal");
        if(movement > 0f){
            rigidBody.velocity = new Vector2(movement * speed, rigidBody.velocity.y);
            transform.localScale = new Vector2(0.3668365f,0.310434f);
        }
        else if (movement < 0f){
             rigidBody.velocity = new Vector2(movement * speed, rigidBody.velocity.y);
             transform.localScale = new Vector2(-0.3668365f,0.310434f);
        }
        else
        {
            rigidBody.velocity =new Vector2(0 , rigidBody.velocity.y);
        }
        if(Input.GetButtonDown("Jump") && isTouchingGround){
            rigidBody.velocity = new Vector2(rigidBody.velocity.x,jumpSpeed);
        }
        playerAnimation.SetFloat ("Speed",Mathf.Abs(rigidBody.velocity.x));
        playerAnimation.SetBool ("OnGround", isTouchingGround);
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.tag =="FallDetector"){
            gameLevelManager.Respawn();
        }
        if(other.tag == "Checkpoint"){
            respawnPoint=other.transform.position;
        }
    }

    public IEnumerator Knockback (float knockDur, float knockbackPwr, Vector3 knockbackDir){
        float timer =0;
        while (knockDur>timer){
            timer +=Time.deltaTime;
            rigidBody.AddForce(new Vector3(knockbackDir.x * -100, knockbackDir.y * knockbackPwr, transform.position.z));
        }
        yield return 0;
    }
}
