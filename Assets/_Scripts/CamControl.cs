using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamControl : MonoBehaviour {
    public Ball ball;

    private Vector3 offsetToBall;
    private float camStopZ = 220.0f;

	void Start () {
		offsetToBall = gameObject.transform.position - ball.transform.position;
	}

	void Update () {
        if (gameObject.transform.position.z >= camStopZ) {
		    gameObject.transform.position = ball.transform.position + offsetToBall;
        }
	}
}
