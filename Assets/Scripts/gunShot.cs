using UnityEngine;
using System.Collections;

public class gunShot : MonoBehaviour {
    private Transform t;
    private Rigidbody2D r;
	// Use this for initialization
	void Start () {
        t = this.GetComponent<Transform>();
        r = this.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
