using UnityEngine;
using System.Collections;

public class TouchControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		foreach(Touch a in Input.touches){
			Debug.Log(a.position.x);
		}
		/*if(Input.touchCount>0)
			Debug.Log(Input.GetTouch(0).position.x);*/
	}
}
