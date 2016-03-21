using UnityEngine;
using System.Collections;

public class OriBash : MonoBehaviour {

    public float reachRadius = 5f;
    RaycastHit2D[] objectsNear;
    Vector3 direction;
    public float speed = 20f;
    public bool canBash;
    GameObject bashableObj;
    public float maxtime = 1f;
    public Transform arrow;
    public GameObject effect;
    Vector3 playerPos;
    // Use this for initialization
    void Start () {
        arrow.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {


        playerPos = this.GetComponent<Transform>().position;

        if (Input.GetButtonDown("Fire2"))
        {


            objectsNear = Physics2D.CircleCastAll(transform.position, reachRadius, Vector3.forward);
            {
                foreach (RaycastHit2D obj in objectsNear)
                {
                    if (obj.collider.gameObject.GetComponent<bashable>() != null)
                    {
                            

                        bashableObj = obj.collider.gameObject;
                        StartCoroutine("Counter");
                        Time.timeScale = 0;

                        canBash = true;
                        arrow.position = bashableObj.transform.position;
                        arrow.Translate(0, 0, 10);

                        arrow.gameObject.SetActive(true);
                        break;



                    }

                }
            }
        }
        else if (Input.GetButtonUp("Fire2") && canBash)
        {
            Time.timeScale = 1;

            
            //Check Lanza
            direction = (Camera.main.ScreenToWorldPoint(Input.mousePosition) - bashableObj.transform.position);//Lo unico que estas haciendo es obteniendo la misma posision del jugador ._. 
            direction.z = 0;
            direction = direction.normalized;

            transform.position = bashableObj.transform.position + direction * 5.2f;//Lo unico que estas haciendo es decirle que se mueva hacia donde esta el proyectil, pero la direccion siempre va a ser 0 por lo de arriba

            GetComponent<PlayerController>().outsideForce = true;
            GetComponent<Rigidbody2D>().velocity = direction * speed;

            canBash = false;
            arrow.gameObject.SetActive(false);


        }
        else if (Input.GetButton("Fire2") && canBash)
        {

            //Check Apunta
            Vector3 diff = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;//Lo mismo de arriba.... 
            //Nunca va a apuntar//girar por que nunca le estas diciendo hacia que direccion con el mando/teclado.
            diff.Normalize();

            float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
            arrow.transform.rotation = Quaternion.Euler(0f, 0f, rot_z);
            Instantiate(effect, bashableObj.transform.position, Quaternion.identity);
            
        }
    }

    IEnumerator Counter()
    {
        //yield return new WaitForSeconds()
        float pauseTime = Time.realtimeSinceStartup + maxtime;

        while (Time.realtimeSinceStartup < pauseTime)
        {

            yield return null;

        }

        if (Time.timeScale == 0)
        {
            Time.timeScale = 1f;
            canBash = false;
            arrow.gameObject.SetActive(false);

        }
        
    }

    void OnDrawGizmos()
    {

        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, reachRadius);

    }
}
