using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Timer5min : MonoBehaviour {


	
	public Text aliveCount;
	public float count;
	public float currentTime;
	public float goalTime;
	public AudioClip winClip;
	private bool hasPlayed = false;
	
	
	
	void Start() {
		
		count = Time.time + 300;
		//GetComponent<AudioSource> () = winSound;
	}
	
	
	void Update()
	{
		count -= Time.deltaTime;
		currentTime = Mathf.Round(count);
		aliveCount.text = currentTime.ToString();
		
		
		
		if (count <= goalTime && !hasPlayed) 
		{
			//this.GetComponent<AudioSource>().Play();
			Sound();
			NextLevel();
			hasPlayed = true;
		}
		
	}
	
	void NextLevel() {
		Invoke ("LoadLevel", 3);
	}
	
	void LoadLevel(){
		Application.LoadLevel ("IVRSplash");
	}
	
	void Sound() {
		
		AudioSource.PlayClipAtPoint(winClip, new Vector3(0,0,0));
		
		
	}
	
}

