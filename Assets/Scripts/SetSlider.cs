using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetSlider : MonoBehaviour
{
  public Slider xpSlider;

  private void Start() {
    xpSlider = GetComponent<Slider>(); 
  }

  void Update(){
      xpSlider.value = XPControll.xp;
      xpSlider.maxValue = XPControll.needxp;
      xpSlider.value = Mathf.Clamp(xpSlider.value, xpSlider.minValue, xpSlider.maxValue);
    }


}
