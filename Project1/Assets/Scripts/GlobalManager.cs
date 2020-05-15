using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalManager : MonoBehaviour
{
    public static GlobalManager Instance;
	
	public static int score = 0;
	public static int life = 3;
	public static int coins = 0;
	public static float volume = 1.0f;
	
	void Awake()
	{
		if(Instance == null)
		{
			DontDestroyOnLoad(gameObject);
			Instance = this;
		}
		else if(Instance != this)
		{
			Destroy(gameObject);
		}
	}

	void Update()
	{
		GlobalManager.score = coins * (life+1);
	}

}
