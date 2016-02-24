using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Transform))]
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
    void MovePlayer() { }
}
