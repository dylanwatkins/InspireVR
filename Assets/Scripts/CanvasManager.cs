using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour {

	private GameObject goodMornCanvas, locationCanvas, timeCanvasBeach, timeCanvasMountains;
		
		void Awake() 
		{
			goodMornCanvas = GameObject.Find("GoodMorningCanvas");
			locationCanvas = GameObject.Find("LocationCanvas");
			timeCanvasBeach = GameObject.Find("TimeCanvasBeach");
			timeCanvasMountains = GameObject.Find("TimeCanvasMountains");
		}
		
		void Start()
		{
			goodMornCanvas.SetActive(true);
			locationCanvas.SetActive(false);
			timeCanvasBeach.SetActive(false);
			timeCanvasMountains.SetActive(false);
		}
		
		public void SwitchToLocation()
		{
			goodMornCanvas.SetActive(false);
			locationCanvas.SetActive(true);
			
		}
		public void SwitchToBeachTime()
		{
			locationCanvas.SetActive(false);
			timeCanvasBeach.SetActive(true);
		
		}

		public void SwitchToMountainTime()
		{
			locationCanvas.SetActive(false);
			timeCanvasMountains.SetActive(true);
	
		}
	
	
	

}