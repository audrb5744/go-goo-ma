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
  void Update()
    {
      XPControll xpControll = GameObject.Find("XPControll").GetComponent<XPControll>();
      xpSlider.value = xpControll.xp;
      xpSlider.maxValue = xpControll.needxp;
      xpSlider.value = Mathf.Clamp(xpSlider.value, xpSlider.minValue, xpSlider.maxValue);
    }

  void OnSliderValueChanged(float value)
  {
    xpSlider.value = value;
    if (value == 0)
    {
      Color fillAreaColor = xpSlider.fillRect.GetComponent<Image>().color;
      fillAreaColor.a = 0;
      xpSlider.fillRect.GetComponent<Image>().color = fillAreaColor;
    }
    else
    {
      Color fillAreaColor = xpSlider.fillRect.GetComponent<Image>().color;
      fillAreaColor.a = 1;
      xpSlider.fillRect.GetComponent<Image>().color = fillAreaColor;
    }

  }
}
