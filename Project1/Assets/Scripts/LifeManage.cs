using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeManage : MonoBehaviour
{
    public static int Life;
    public int MaxLife;
    public int LifeToAdd;
    Text text;
    public bool isDead;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text> ();
        Life = MaxLife;
        isDead= false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Life<0)
            Life =0;
        text.text = " " + Life;
        if(Life<=0){
            Application.LoadLevel ("EndScene");
            isDead =true;
        }
    }
    public static void AddLife(int LifeToAdd){
        Life += LifeToAdd;
    }
    public static void Reset(){
        Life=0;
    }
}
