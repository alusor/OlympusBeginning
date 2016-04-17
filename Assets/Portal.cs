using UnityEngine;
using System.Collections;

[RequireComponent(typeof(BoxCollider2D))]
public class Portal : MonoBehaviour {
    public Transform portalB;
    public Transform a;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}


    void OnTriggerEnter2D(Collider2D other) {
        other.transform.position = portalB.position;
    }
}
