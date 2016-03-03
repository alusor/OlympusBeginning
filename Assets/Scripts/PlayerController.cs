﻿using UnityEngine;
using System.Collections;

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

    //Atributos de colision
    public LayerMask Mask;
    public GameObject groundCollider;
    public float radiusGroundCollider;



    // Use this for initialization
    void Start () {
        r = this.GetComponent<Rigidbody2D>();
        t = this.GetComponent<Transform>();
	}
    void FixedUpdate() { }
	// Update is called once per frame
	void Update () {
        MovePlayer();
	}
    void MovePlayer() {
        xvelocity = 0;
        if (Input.GetKey(KeyCode.A))
        {
            xvelocity = hSpeed * -1;
            t.localScale = new Vector3(-1f, 1, 1);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            xvelocity = hSpeed;
            t.localScale = new Vector3(1f,1,1);
        }
        r.velocity = new Vector2(xvelocity,r.velocity.y);   
    
    }
}
