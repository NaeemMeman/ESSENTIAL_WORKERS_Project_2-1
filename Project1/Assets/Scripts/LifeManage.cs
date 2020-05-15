using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeManage : MonoBehaviour
{
    public int LifeToAdd;
    Text text;
    public bool isDead;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text> ();
        isDead= false;
    }

    // Update is called once per frame
    void Update()
    {
        if(GlobalManager.life < 0)
            GlobalManager.life = 0;
        text.text = " " + GlobalManager.life;
        if(GlobalManager.life <= 0){
            Application.LoadLevel ("EndScene");
            isDead =true;
        }
    }
    public static void AddLife(int LifeToAdd){
        GlobalManager.life += LifeToAdd;
    }
    public static void Reset(){
        GlobalManager.life = 0;
    }
}
