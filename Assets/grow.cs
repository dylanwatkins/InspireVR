using UnityEngine;
using System.Collections;

public class grow : MonoBehaviour {

	float newScale;
	float ratio;
	
	void Start(){
		ratio = Time.deltaTime;
		InvokeRepeating("ChangeScale",1f,1f);
	}
	
	void Update(){
		float newVal = Mathf.Lerp(transform.localScale.y,newScale,ratio);
		transform.localScale = new Vector3(newVal,newVal,newVal);
	}
	void ChangeScale(){
		newScale = Time.time * 10;
	}

}
