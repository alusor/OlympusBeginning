using UnityEngine;
using System.Collections;

public class checkPoint : MonoBehaviour {

    GameManager manager;
	// Use this for initialization
	void Start () {
        manager = FindObjectOfType<GameManager>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player"))
        {
            manager.setCheckPointPlayer(this);
        }
    }
}
