using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
    public PlayerController player;
    public Camera main;
    public float cameraSpeed;
	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void FixedUpdate() {
        main.GetComponent<Transform>().position = Vector3.Lerp(main.GetComponent<Transform>().position,new Vector3(player.GetComponent<Transform>().position.x, player.GetComponent<Transform>().position.y, main.GetComponent<Transform>().position.z),cameraSpeed*Time.deltaTime);
    }
}
