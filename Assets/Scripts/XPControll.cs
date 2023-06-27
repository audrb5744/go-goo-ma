using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XPControll : MonoBehaviour
{
  public float xp = 0f;
  public float needxp = 3f;
  public int level = 1;
  private Slider xpSlider;

void Start()
{
    xpSlider.onValueChanged.AddListener(OnSliderValueChanged);
}

void OnSliderValueChanged(float value)
{
    if (value == 0)
    {
        Color fillAreaColor = xpSlider.fillRect.GetComponent<Image>().color;
        fillAreaColor.a = 0; // Set alpha to 0 to make the fill area invisible
        xpSlider.fillRect.GetComponent<Image>().color = fillAreaColor;
    }
    else
    {
        Color fillAreaColor = xpSlider.fillRect.GetComponent<Image>().color;
        fillAreaColor.a = 1; // Set alpha to 1 to make the fill area visible
        xpSlider.fillRect.GetComponent<Image>().color = fillAreaColor;
    }
}


void Update()
     {
      xpSlider.value = 3;
     }

}
