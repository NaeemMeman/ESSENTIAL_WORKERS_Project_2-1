using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    private string stringLevel;

    public void Level(string _Level){
        stringLevel = _Level;
        Application.LoadLevel (stringLevel);
        GlobalManager.score = 0;
        GlobalManager.coins = 0;
        GlobalManager.life = 3;
    }

    public void Quit(){
        Application.Quit();
    }
   
}
