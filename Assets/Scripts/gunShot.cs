using UnityEngine;
using System.Collections;

public class gunShot : MonoBehaviour {
    private Transform t;
    private Rigidbody2D r;
    public int shootSpeed;
    public int damage;
	// Use this for initialization
	void Start () {
        t = this.GetComponent<Transform>();
        r = this.GetComponent<Rigidbody2D>();
        Destroy(this, 15f);
	}
	
	// Update is called once per frame
	void Update () {
        r.velocity = new Vector2(shootSpeed, r.velocity.y);
    }
    public void setDirecion(float x) {
        if (x < 0) {
            shootSpeed *= -1;
            t.localScale = new Vector3(-1f, 1, 1);

        }
    }
    void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Enemy")) {
            
            other.GetComponent<EnemyHeatlh>().makeDamage(damage);
            Destroy(this.gameObject);
        }
    }   
}
