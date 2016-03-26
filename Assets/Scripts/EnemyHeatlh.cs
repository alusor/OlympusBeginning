﻿using UnityEngine;
using System.Collections;

public class EnemyHeatlh : MonoBehaviour {
    public int damage;
    public int health;
    // Use this for initialization
    void Start () {
	
	}

    public void makeDamage(int damage)
    {
        if (health > damage)
        {
            health -= damage;
            Debug.Log(health);
        }
        else {
            Destroy(this.gameObject);
        }

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            FindObjectOfType<GameManager>().onPlayerMakeDamange(damage);
			other.GetComponent<SpriteRenderer> ().color = new Color (1,1,1,.5f);
        }
    }
	void OnTriggerExit2D(Collider2D other){
		if (other.gameObject.tag == "Player") {
			other.GetComponent<SpriteRenderer> ().color = new Color (1,1,1,1);
		}
	}
}
