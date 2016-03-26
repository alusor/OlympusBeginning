using UnityEngine;
using System.Collections;

public class SetItem : MonoBehaviour {
    public Transform head;
    public Transform hans;

    public Sprite[] item;
	// Use this for initialization
	void Start () {
        head.gameObject.AddComponent<SpriteRenderer>();
        hans.gameObject.AddComponent<SpriteRenderer>();


    }
	
	// Update is called once per frame
	void Update () {
	    
	}

    public void setComponent(int id) {
        switch (id) {
            case 1:
                head.gameObject.GetComponent<SpriteRenderer>().sprite = item[0];
                head.GetComponent<SpriteRenderer>().sortingLayerName = "Foreground";
                break;
            case 2:
                break;
            case 3:
                head.gameObject.GetComponent<SpriteRenderer>().sprite = item[2];
                head.GetComponent<SpriteRenderer>().sortingLayerName = "Foreground";
                break;
            case 4:
                hans.gameObject.GetComponent<SpriteRenderer>().sprite = item[3];
                hans.GetComponent<SpriteRenderer>().sortingLayerName = "Foreground";
                break;
            case 5:
                hans.gameObject.GetComponent<SpriteRenderer>().sprite = item[4];
                hans.GetComponent<SpriteRenderer>().sortingLayerName = "Foreground";
                break;
            default:
                break;

        }

    }
}
