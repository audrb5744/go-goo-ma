using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SetLevelTxt : MonoBehaviour
{
  public TMP_Text levelTxt;

  private void Start() {
    levelTxt = GetComponent<TMP_Text>(); 
  }
  void Update()
    {
      XPControll xpControll = GameObject.Find("XPControll").GetComponent<XPControll>();
      levelTxt.text = xpControll.level.ToString();
    }
}
