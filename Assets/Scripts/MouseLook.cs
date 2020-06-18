using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MouseLook : MonoBehaviour
{
  public Joystick joystick;
  private float mouseSensitivity = 80f;
  public Transform playerBody;
  float xRotation = 0f;

  private bool IsPointerOverUIObject() {
    if (Input.GetMouseButtonDown(0)) return true;

    if (EventSystem.current.IsPointerOverGameObject()) return true;

    for (int touchIndex = 0; touchIndex < Input.touchCount; touchIndex++)
    {
      Touch touch = Input.GetTouch(touchIndex);
      if (EventSystem.current.IsPointerOverGameObject(touch.fingerId))
      return true;
    }
    return false;
  }

	void Update () {
    // if (IsPointerOverUIObject()) return;

    // float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
    // float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

    float mouseX = joystick.Horizontal * mouseSensitivity * Time.deltaTime;
		float mouseY = joystick.Vertical * mouseSensitivity * Time.deltaTime;


    xRotation -= mouseY;
    xRotation = Mathf.Clamp(xRotation, -90f, 90f);


    transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
    playerBody.Rotate(Vector3.up * mouseX);
	}
}
 