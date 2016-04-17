using UnityEngine;
using System.Collections;

public class TouchControl : MonoBehaviour {
	// Use this for initialization
	PlayerController p;
	void Start () {
	p =  FindObjectOfType<PlayerController>();
	}

	// Update is called once per frame
	void Update () {
		foreach(Touch a in Input.touches){
			//Debug.Log(a.position.x);
			switch (a.phase)
			{


				default:
				break;
			}
			Vector3 te = Camera.main.ScreenToWorldPoint(a.position);
			if(p.transform.position.x>te.x){
				Debug.Log("Izquierda");
			}
			else{
					Debug.Log("Derecha");
				}
				//Debug.Log(a.deltaPosition);
				if(a.deltaPosition.y>2f){
					Debug.Log("Arriba");
				}else if(a.deltaPosition.y<-2f){
					Debug.Log("Ataque");
				}
		}

		/*if(Input.touchCount>0)
			Debug.Log(Input.GetTouch(0).position.x);*/
	}
}
