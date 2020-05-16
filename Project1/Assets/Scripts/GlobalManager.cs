using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalManager : MonoBehaviour
{
    public static GlobalManager Instance;
	
	public static int score = 0;
	public static float life = 1.0f;
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
		if(GlobalManager.life < 0)
        {
			GlobalManager.score = (GlobalManager.coins + 1) * 1;
		}
		else
        {
			GlobalManager.score = (GlobalManager.coins + 1) * ((int)(GlobalManager.life * 5) + 1);
		}
		
	}

}
