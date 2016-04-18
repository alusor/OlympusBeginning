using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WebRequestRegister : MonoBehaviour {
	public static WebRequestRegister WRR;
	public Text t;
	private string nam;
	private int score;
	public string url;
	private WWW webRequest;
	private string type;
	public void setData(int s, string n, string t){
		nam = n;
		score = s;
		type = t;
		Debug.Log("Empezar procesos");
		if(setupUrl()==0){
			Debug.Log("Url valida");
			StartCoroutine("makeRequest");
			
		}
		
	}
	private int setupUrl(){
		if(type=="select"||type=="insert")
		{
			url = url+"type=" + type + "&username="+nam;	
		}
		else if(type=="update"){
			url = url+"type=" + type + "&username="+nam+"&score="+score;
			}else{
				return 1;
				}
			
		return 0;
	}
	// Use this for initialization
	IEnumerator makeRequest () {
		Debug.Log(url);
	webRequest = new WWW(url);
	yield return webRequest;
	Debug.Log("Respuesta  "+ webRequest.text);
	t.text = webRequest.text;
	}

}
