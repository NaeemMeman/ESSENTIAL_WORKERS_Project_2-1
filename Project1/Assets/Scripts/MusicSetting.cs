using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSetting : MonoBehaviour
{
	private AudioSource audioSrc;
	
	void Start()
	{
		audioSrc = GetComponent<AudioSource>();
	}
	
	void Update()
	{
		audioSrc.volume = GlobalManager.volume;
	}
	
	public void SetVolume(float vol)
	{
		GlobalManager.volume = vol;
		audioSrc.volume = GlobalManager.volume;
	}

}
