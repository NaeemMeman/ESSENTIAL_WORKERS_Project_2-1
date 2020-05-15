using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{
	Text score;
	
    // Start is called before the first frame update
    void Start()
    {
        score = gameObject.GetComponent<Text>();
		score.text = GlobalManager.score.ToString();
    }
}
