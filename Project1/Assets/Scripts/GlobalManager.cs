using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalManager : MonoBehaviour
{
    public static GlobalManager Instance;
	
	public static int score = 0;
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
		GlobalManager.score = LevelManager.coins * (LifeManage.Life + 1);
	}

}
