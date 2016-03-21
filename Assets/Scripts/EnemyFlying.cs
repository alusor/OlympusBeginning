using UnityEngine;
using System.Collections;

public class EnemyFlying : MonoBehaviour {

    private PlayerController Player;
    public float moveSpeed;
    public float PlayerRange;
    public LayerMask PlayerLayer;
    public bool PlayerInRange;

    public bool facingAway;
    public bool followMarioGhost;

	// Use this for initialization
	void Start () {
        Player = FindObjectOfType<PlayerController>();
	}
	
	// Update is called once per frame
	void Update () {

        PlayerInRange = Physics2D.OverlapCircle(transform.position, PlayerRange, PlayerLayer);

        if (!followMarioGhost)
        {
            if (PlayerInRange)
            {
                transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, moveSpeed * Time.deltaTime);
                return;
            }
        }

        if ((Player.transform.position.x < transform.position.x && Player.transform.localScale.x < 0) || (Player.transform.position.x > transform.position.x && Player.transform.localScale.x > 0))
        {
            facingAway = true;
        }
        else
        {
            facingAway = false;
        }
        if (PlayerInRange && facingAway)
        {
            transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, moveSpeed * Time.deltaTime);
        }
    }

    void OnDrawGizmosSelected() {
        Gizmos.DrawSphere(transform.position, PlayerRange);
    }
}
