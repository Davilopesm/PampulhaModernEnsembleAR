using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Ponto3Script : MonoBehaviour
{
   // Start is called before the first frame update
  bool enable;
  GameObject itenToHide;
  public Button b1;
  public string SITE = "07";
  public string WINDOW = "03_WINDOW"; 
  public string WALL = "02_WALL_brise";

  void Start()
  {
    this.enable = false;
  }

  public void hideThings()
  {
    this.getObjects();
    this.changeButton();
    this.enable = !this.enable;
  }

  public void changeButton()
  {
    if (!this.enable)
    {
      b1.image.color = Color.gray;
    }
    else
    {
      b1.image.color = Color.white;
    }
  }

  public void getObjects(){
    GameObject casaDeBaile = GameObject.Find("CasaDeBaile");
    Transform[] children = casaDeBaile.GetComponentsInChildren<Transform>(true);
    foreach (Transform item in children) {
      GameObject go = item.gameObject;
 
      if(!go.name.Contains(this.SITE) && !go.name.Contains(this.WINDOW) && !go.name.Contains(this.WALL) && !go.name.Contains(casaDeBaile.name)){
        go.gameObject.SetActive(this.enable);
      }
    }

  }
}
