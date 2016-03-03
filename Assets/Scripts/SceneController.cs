using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour {
    public void changeScene(string name) {
        SceneManager.LoadScene(name);
    }
}
