using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Ponto5Script : MonoBehaviour
{
    // Start is called before the first frame update
  bool enable;
  GameObject itenToHide;
  public Button b1;
  private string SITE = "07";
  private string ROOF = "05";

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
 
      if(!go.name.Contains(this.SITE) && !go.name.Contains(this.ROOF) && !go.name.Contains(casaDeBaile.name)){
        go.gameObject.SetActive(this.enable);
      }
    }

  /*  GameObject[] allObjects = FindObjectsOfType<GameObject>();
    List<GameObject> objectsToDisable = new List<GameObject>(allObjects);
    foreach (GameObject go in allObjects) {
      if(!go.name.Contains(this.SITE) || !go.name.Contains(this.PIL)){
        objectsToDisable.Add(go);
      }
    }

    foreach(GameObject go in objectsToDisable){
      Debug.Log("ENTROU NO FOREACH ANTES DE BUGAR" +  go.GetType());
      // go.SetActive(this.enable);
    } */
    /*foreach(GameObject go in this.siteItens){
      go.SetActive(this.enable);
    }

    foreach(GameObject go in this.pilItens){
      go.SetActive(this.enable);
    }*/
  }
}
