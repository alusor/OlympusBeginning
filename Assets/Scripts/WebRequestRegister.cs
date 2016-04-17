using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WebRequestRegister : MonoBehaviour {
	public Text t;
	public string url;
	private WWW webRequest;
	// Use this for initialization
	IEnumerator Start () {
	webRequest = new WWW(url);
	yield return webRequest;
	t.text = webRequest.text;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
