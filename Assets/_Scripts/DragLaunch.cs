using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Ball))]
public class DragLaunch : MonoBehaviour {
    private Vector2 startPos;
    private Vector2 endPos;
    // private System.DateTime startTime;
    // private System.DateTime endTime;
    private float startTime;
    private float endTime;

    [SerializeField] Ball ball;
	void Start () {

	}

    public void MoveStart(float amt)
    {
        if (ball.HasBeenLaunched || ball.IsRolling)
        {
            return;
        }
        ball.transform.Translate(new Vector3(amt, 0, 0));
    }

	public void DragStart()
    {
        if (ball.HasBeenLaunched)
        {
            return;
        }
        startPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        // startTime = System.DateTime.Now;
        startTime = Time.time;
    }

    public void DragEnd()
    {
        if (ball.HasBeenLaunched)
        {
            return;
        }
        endPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        // endTime = System.DateTime.Now;
        endTime = Time.time;

        float dragDur = endTime - startTime;
        float launchSpdX = (endPos.x - startPos.x) / dragDur;
        // float launchSpeedY = (endPos.y - startPos.y) / dragDur;
        float launchSpdZ = (endPos.y - startPos.y) / dragDur;
        Vector3 launchVel = new Vector3(-launchSpdX, 0, -launchSpdZ);

        ball.Launch(launchVel);
    }
}
