using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SetLevelTxt : MonoBehaviour
{
  public TMP_Text Level;

  private void Start() {
    Level = GetComponent<TMP_Text>(); 
  }
  void Update()
    {
      Level.text = XPControll.level.ToString();
    }
}
