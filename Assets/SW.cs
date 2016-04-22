using UnityEngine;
using System.Collections;

public class SW : MonoBehaviour {

    public Transform cursorIndicator;
    public Transform swipeIndicator;

    void OnEnable()
    {
        IT_Gesture.onTouchPosE += OnOn;
        IT_Gesture.onMouse1E += OnOn;
        IT_Gesture.onSwipeEndE += OnSwipe;
    }

    void OnSwipe(SwipeInfo sw)
    {
        //Debug.Log("swipe"); :v
        if (sw.angle >= 45 && sw.angle < 135)
        {
            Debug.Log("swipe up");
        }
        else if (sw.angle >= 135 && sw.angle < 225)
        {
            Debug.Log("swipe left");
        }
        else if (sw.angle >= 225 && sw.angle < 315)
        {
            Debug.Log("swipe down");
        }
        else
        {
            Debug.Log("swipe right");
        }
    }
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    IEnumerator ShowSwipeIndicator(SwipeInfo sw)
    {
        //position the projectile object at the start point of the swipe
        Vector3 p = Camera.main.ScreenToWorldPoint(new Vector3(sw.startPoint.x, sw.startPoint.y, 5));
        swipeIndicator.position = p;

        float t = 0;
        while (t <= 1)
        {
            p = Vector2.Lerp(sw.startPoint, sw.endPoint, t);
            p = Camera.main.ScreenToWorldPoint(new Vector3(p.x, p.y, 5));
            //Debug.Log(sw.startPoint+"  "+sw.endPoint+"   "+p);
            swipeIndicator.position = p;
            t += 0.2f;
            yield return null;
        }
    }

    void OnOn(Vector2 pos)
    {
        //place the curose at the position where the tap/click take place
        Vector3 p = Camera.main.ScreenToWorldPoint(new Vector3(pos.x, pos.y, 5));
        cursorIndicator.position = p;
    }
}
