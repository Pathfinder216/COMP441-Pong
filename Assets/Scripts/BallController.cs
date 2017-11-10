using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private float speed = 5f;
    private Vector3 movement;

	// Use this for initialization
	void Start () {
        movement = new Vector3(1f, 0, Random.Range(-1f, 1f)) * speed;
    }
	
	// Update is called once per frame
	void Update () {
        transform.position += movement * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        string tag = other.tag;
        if (tag == "wall")
        {
            movement.z *= -1;
        }
        else if (tag == "paddle")
        {
            movement.x *= -1;
        }
    }
}
