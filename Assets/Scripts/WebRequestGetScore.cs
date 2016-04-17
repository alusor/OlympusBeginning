using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WebRequestGetScore : MonoBehaviour {
	public int score;
	WWW wr;
	public string url;
	// Use this for initialization
	IEnumerator Start () {
		wr =  new WWW(url);
		yield return wr;
		score = int.Parse(wr.text);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
