﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseImage : MonoBehaviour
{
  public GameObject image;
  void OnEnable()
	{
		Lean.Touch.LeanTouch.OnFingerTap += HandleFingerTap;
	}

	void OnDisable()
	{
		Lean.Touch.LeanTouch.OnFingerTap -= HandleFingerTap;
	}

	void HandleFingerTap(Lean.Touch.LeanFinger finger)
	{
		Debug.Log("You just tapped the screen with finger " + finger.Index + " at " + finger.ScreenPosition);
    image.SetActive(false);
	}

  private void Start() 
  {
    image = GameObject.Find("Image");
  }

}
