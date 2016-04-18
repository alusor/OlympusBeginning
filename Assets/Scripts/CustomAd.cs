using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CustomAd : MonoBehaviour {

    public List<Sprite> Ads;

    // Use this for initialization
    void Start ()
    {
        Debug.Log("ads");
        Sprite fab = Ads[Random.Range(0, Ads.Count)];
        Instantiate(fab, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update () {
	
	}
}
