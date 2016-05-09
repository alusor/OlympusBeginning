using UnityEngine;
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
            FindObjectOfType<ResourceM>().alterCoins(15);
            Destroy(this.gameObject);
        }

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            FindObjectOfType<GameManager>().onPlayerMakeDamange(damage);
            FindObjectOfType<ResourceM>().alterCoins(damage/2);
            StartCoroutine("Flash",other.gameObject);
            other.GetComponent<SpriteRenderer> ().color = new Color (1,1,1,.5f);
        }
    }
    IEnumerator Flash(GameObject a) {

        for (int i = 0; i < 10; i++) {
            a.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, .3f);
            
            yield return new WaitForSeconds(0.02f);
            a.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
            yield return new WaitForSeconds(0.02f);
        }
    }
	void OnTriggerExit2D(Collider2D other){
		if (other.gameObject.tag == "Player") {
			other.GetComponent<SpriteRenderer> ().color = new Color (1,1,1,1);
		}
	}
}
