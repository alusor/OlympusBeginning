using UnityEngine;
using System.Collections;

public class ShowDemo : MonoBehaviour {
    private static float elapsed;
    public float duration = 1.0f;
    public float Zoom1 = 9;
    public float Zoom2 = 15;
    private bool Zoom;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update()
    {
        if (Zoom)
        {
            elapsed += Time.deltaTime / duration;
            Camera.main.orthographicSize = Mathf.Lerp(Zoom1, Zoom2, elapsed);
            
        }
        if (!Zoom)
        {
            elapsed += Time.deltaTime / duration;
            Camera.main.orthographicSize = Mathf.Lerp(Zoom2, Zoom1, elapsed);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Message")
        {
            Zoom = true;
            elapsed = 0.0f;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Message")
        {
            Zoom = false;
            elapsed = 0.0f;
        }
    }
}
