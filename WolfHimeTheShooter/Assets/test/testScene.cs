using HedgehogTeam.EasyTouch;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testScene : MonoBehaviour {
    [SerializeField]
    QuickSwipe swipe;
    [SerializeField]
    Transform pl;
	// Use this for initialization
	void Start () {
        swipe.onSwipeAction.AddListener(TestGesture);
	}

    private void TestGesture(Gesture ges)
    {
        pl.transform.position += new Vector3(ges.deltaPosition.x, ges.deltaPosition.y, 0) * 0.01f;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
