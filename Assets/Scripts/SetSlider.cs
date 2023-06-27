using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetSlider : MonoBehaviour
{
  public Slider xpSlider;
  XPControll xpControll = GameObject.Find("XPControll").GetComponent<XPControll>();

  void Start()
  {
    OnSliderValueChanged(0f);
  }

  void Update()
  {
    OnSliderValueChanged(xpControll.xp);
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
