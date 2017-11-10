using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTwoInput : MonoBehaviour {
	
	public enum InputKey
	{
		W = KeyCode.W,
		A = KeyCode.A,
		Up = KeyCode.UpArrow,
		Down = KeyCode.DownArrow
	}


	public InputKey up;
	public InputKey down;
	public static float playerSpeed = 9f;
	private CharacterController characterCtrl;
	// Use this for initialization
	void Start () {
		characterCtrl = GetComponent<CharacterController> ();
	}

	// Update is called once per frame
	void Update ()
    {
        Vector3 movement = Vector3.zero;
        if (Input.GetKey (KeyCode.W))
        {
            movement += new Vector3 (0, 0, playerSpeed * Time.deltaTime);
        }
        else if (Input.GetKey (KeyCode.S))
        {
            movement += new Vector3 (0, 0, playerSpeed * -1 * Time.deltaTime);
        }
        characterCtrl.Move(movement);
    }
}
