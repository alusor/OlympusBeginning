using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
    public PlayerController player;
    public Camera main;
    public float cameraSpeed;
    public checkPoint actualCheckPoint;
    public int playerHealth;
    public int playerLives;
    private int score;
    public bool LoadingCamera = false;
    

	// Use this for initialization
	void Start () {
        score = 0;
	}

    public void setScore(int x) {
        score += x;
    }
    public int getScore()
    {
        return score;
    }

    // Update is called once per frame
    void FixedUpdate() {
       

        if (LoadingCamera)
        {
            if (player.GetComponent<Transform>().localScale.x > 0)
            {
                main.GetComponent<Transform>().position = Vector3.Lerp(main.GetComponent<Transform>().position, new Vector3(player.GetComponent<Transform>().position.x + 5f, player.GetComponent<Transform>().position.y + 13f, main.GetComponent<Transform>().position.z), cameraSpeed * Time.deltaTime * .5f);
            }
            else
                main.GetComponent<Transform>().position = Vector3.Lerp(main.GetComponent<Transform>().position, new Vector3(player.GetComponent<Transform>().position.x - 5f, player.GetComponent<Transform>().position.y + 13f, main.GetComponent<Transform>().position.z), cameraSpeed * Time.deltaTime * .5f);
        }
        //Camara de nivel
        else
        {
            if (player.GetComponent<Transform>().localScale.x > 0)
            {
                main.GetComponent<Transform>().position = Vector3.Lerp(main.GetComponent<Transform>().position, new Vector3(player.GetComponent<Transform>().position.x + 5f, player.GetComponent<Transform>().position.y + 3f, main.GetComponent<Transform>().position.z), cameraSpeed * Time.deltaTime * .5f);
            }
            else
                main.GetComponent<Transform>().position = Vector3.Lerp(main.GetComponent<Transform>().position, new Vector3(player.GetComponent<Transform>().position.x - 5f, player.GetComponent<Transform>().position.y + 3f, main.GetComponent<Transform>().position.z), cameraSpeed * Time.deltaTime * .5f);
        }
    }

    public void setCheckPointPlayer(checkPoint get) {
        actualCheckPoint = get;
        

    }

    public void onDie() {
        if (playerLives > 0) {
            playerLives -= 1;
            player.GetComponent<Transform>().position = actualCheckPoint.GetComponent<Transform>().position;
            playerHealth = 100;
        }
        else{
            Debug.Log("Perdiste");
            Time.timeScale = 0f;
        }
    }

    public void onPlayerMakeDamange(int damage) {
        if (playerHealth <= damage)
        {
            playerHealth = 0;
            onDie();
        }
        else { playerHealth -= damage;
            Debug.Log(playerHealth);
        }
        
    }
}
