using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public CharacterController controller;
	private float speed = 175f;
	public Joystick joystick;

	void Update()
	{
		// float x = Input.GetAxis("Horizontal");
		// float z = Input.GetAxis("Vertical");
		float x = joystick.Horizontal;
		float z = joystick.Vertical;

		Vector3 move = transform.right * x + transform.forward * z;

		controller.Move(move * speed * Time.deltaTime);
	}
}
