using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{
  public void setScene(string sceneName){
    SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
  }
}
