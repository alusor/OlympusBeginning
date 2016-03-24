using UnityEngine;
using System.Collections;

public class EnemyPatrol : MonoBehaviour {

    public float moveSpeed;
    public bool moveRight;

    public Transform wallCheck;
    public float wallRadius;
    public LayerMask Wall;
    bool hittingWall;

    public int damage;
    public int health;

    bool NotAtEdge;
    public Transform edgeCheck;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        hittingWall = Physics2D.OverlapCircle(wallCheck.position, wallRadius, Wall);

        NotAtEdge = Physics2D.OverlapCircle(edgeCheck.position, wallRadius, Wall);

        if (hittingWall ||!NotAtEdge) moveRight = !moveRight;

        if (moveRight)
        {
            transform.localScale = new Vector3(-3f, 1.5f, 1f);//CHANGE TO 1
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
        else
        {
            transform.localScale = new Vector3(3f, 1.5f, 1f);//
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
	
	}
    public void makeDamage(int damage) {
        if (health >= damage) {
            health -= damage;
            Debug.Log(health);
        }
        else{
            Destroy(this.gameObject);
        }

    }
    void OnTriggerEnter2D(Collider2D other) {        
        if (other.gameObject.tag == "Player") {
            FindObjectOfType<GameManager>().onPlayerMakeDamange(damage);
        }
    }
}
