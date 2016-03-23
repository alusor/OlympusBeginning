using UnityEngine;
using System.Collections;
using System;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Transform))]
[RequireComponent(typeof(BoxCollider2D))]
public class PlayerController : MonoBehaviour {
    //Propiedades del jugador
    private Transform t;
    [SerializeField]
    private Rigidbody2D r;
    [SerializeField]
    public float vSpeed;
    [SerializeField]
    public float hSpeed;
    private bool isJump;
    float xvelocity;
    public GameObject shot;
    public Transform shotPosition;

    //Atributos de colision
    //Para saltar es necesario que los objetos con los que esta colisionando tengan la capa ground.
    public LayerMask Mask;
    public Transform groundCollider;
    public float radiusGroundCollider;
    public bool outsideForce;

    public float BaseSpeed;
    float previousAxispos;

    // Use this for initialization
    void Start () {
        r = this.GetComponent<Rigidbody2D>();
        t = this.GetComponent<Transform>();
	}
    void FixedUpdate() {
        isJump = Physics2D.OverlapCircle(groundCollider.position,radiusGroundCollider,Mask);
    }
	// Update is called once per frame
	void Update () {
        MovePlayer();

        Bash();
    }

    void MovePlayer() {
        xvelocity = Input.GetAxis("Horizontal");
        if (xvelocity < 0) {
            t.localScale = new Vector3(-1f, 1, 1);
        }   
        if (xvelocity > 0)
        {
            t.localScale = new Vector3(1f, 1f, 1f);
        }
        if (Input.GetButtonDown("Jump")&&isJump) {
            r.velocity = new Vector2(r.velocity.x, vSpeed);
        }
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("Disparo");
            GameObject temp = Instantiate(shot,shotPosition.position,Quaternion.identity) as GameObject;
            temp.GetComponent<gunShot>().setDirecion(t.localScale.x);
            
        }
        r.velocity = new Vector2(xvelocity*hSpeed,r.velocity.y);   
    
    }


    private void Bash()
    {
        if (isJump && (Input.GetAxisRaw("Horizontal") != previousAxispos))
        {
            BaseSpeed = 0;
            outsideForce = false;
        }
        previousAxispos = Input.GetAxisRaw("Horizontal");

        if (!outsideForce)
        {

            if (Input.GetAxisRaw("Horizontal") != 0)
            {
                //anim.SetBool("Moving", true);
                r.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * hSpeed + BaseSpeed, r.velocity.y);
                
            }
            else {
                //anim.SetBool("Moving", false);
                r.velocity = new Vector2(BaseSpeed, r.velocity.y);
            }
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        outsideForce = false;
        if (other.gameObject.tag == "Platform")
            BaseSpeed = other.gameObject.GetComponent<Rigidbody2D>().velocity.x;
        if (other.gameObject.tag == "Enemie")
        {
            Debug.Log("ouch");
        }
    }
    
}
