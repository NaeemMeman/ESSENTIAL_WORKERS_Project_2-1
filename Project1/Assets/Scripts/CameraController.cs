using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    public float offset;
    private Vector3 playerPosition;
    public float offsetSmoothing;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerPosition = new Vector3(player.transform.position.x, player.transform.position.y,transform.position.z);

        if (player.transform.localScale.x>0f){
            playerPosition= new Vector3(playerPosition.x + offset, playerPosition.y, playerPosition.z);
        }
        else{
            playerPosition= new Vector3(playerPosition.x - offset, playerPosition.y, playerPosition.z);
        }
        transform.position = Vector3.Lerp(transform.position,playerPosition,offsetSmoothing * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other){
        if (other.tag == "FallDetector"){
            // what will happen when player enters the FallDetector zone
        }
    }
}
