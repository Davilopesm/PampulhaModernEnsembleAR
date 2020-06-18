using System.Collections;
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
    image.SetActive(false);
    Screen.orientation = ScreenOrientation.LandscapeLeft;
    Screen.autorotateToPortrait = false;
    Screen.autorotateToPortraitUpsideDown = false;
	}

  private void Start() 
  {
    image = GameObject.Find("Image");
  }

}
