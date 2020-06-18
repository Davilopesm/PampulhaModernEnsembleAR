using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{
  public int sceneId;

  private void Update() {
    if (Input.GetKey(KeyCode.Escape)){
      Screen.orientation = ScreenOrientation.Portrait;
      Screen.autorotateToPortrait = true;
      Screen.autorotateToPortraitUpsideDown = true;
      SceneManager.LoadScene(0);
    }
  }

  public void setScene(){
    Debug.Log("INSIDE SET SCENE: " + this.sceneId);
    if ( this.sceneId == 2) {
      Screen.orientation = ScreenOrientation.LandscapeLeft;
      Screen.autorotateToPortrait = false;
      Screen.autorotateToPortraitUpsideDown = false;
    }
    SceneManager.LoadScene(this.sceneId); 
  }
}
