using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{
  public int sceneId;

  private void Update() {
    if (Input.GetKey(KeyCode.Escape)){
      SceneManager.LoadScene(this.sceneId);
    }
  }

  public void setScene(){
    Debug.Log("INSIDE SET SCENE: " + this.sceneId);
    SceneManager.LoadScene(this.sceneId);
    
  }
}
