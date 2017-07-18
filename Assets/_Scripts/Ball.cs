using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    public float speed;

    public bool IsRolling { get{ return isRolling; } }
    public bool HasBeenLaunched { get{ return hasBeenLaunched; } }

    [SerializeField] Rigidbody rb;
    [SerializeField] AudioSource rollingSource;
    private bool isRolling = false;
    private bool hasBeenLaunched = false;

	void Start ()
    {
        rb.useGravity = false;
    }

    public void Launch(Vector3 newVelocity)
    {
        isRolling = true;
        hasBeenLaunched = true;
        rb.useGravity = true;
        rb.velocity = newVelocity;
        rollingSource.Play();
    }

    void Update () {
		
	}
}
