﻿using System.Collections;
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
  private string SITE = "07_";
  private string WINDOW = "03_WINDOW"; 
  private string WALL = "02_WALL_brise";
  private string MULLION = "mullion";

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
    GameObject casaDeBaile = GameObject.Find("CasaDeBaileOBJTxt");
    Transform[] children = casaDeBaile.GetComponentsInChildren<Transform>(true);
    foreach (Transform item in children) {
      GameObject go = item.gameObject;
 
      if(!go.name.Contains(this.SITE) 
      && !go.name.Contains(this.WINDOW) 
      && !go.name.Contains(this.WALL) 
      && !go.name.Contains(casaDeBaile.name)
      && !go.name.Contains(this.MULLION)
      ){
        go.gameObject.SetActive(this.enable);
      }
    }

  }
}
