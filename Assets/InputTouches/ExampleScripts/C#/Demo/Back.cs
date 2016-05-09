using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Back : MonoBehaviour {

	void OnGUI(){
		if(GUI.Button(new Rect(10, 10, 130, 35), "Back to Menu")){
            SceneManager.LoadScene("_Menu"); 
            //Application.LoadLevel("_Menu");
		}
	}
	
}
