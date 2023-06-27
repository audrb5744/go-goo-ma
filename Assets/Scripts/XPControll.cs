using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XPControll : MonoBehaviour
{
  public float xp = 0f;
  public float needxp = 3f;
  public int level = 1;
  public Slider xpSlider;


void Update()
     {
      xpSlider.value = xp;
     }

}
