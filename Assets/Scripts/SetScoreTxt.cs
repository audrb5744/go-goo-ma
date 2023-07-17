using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SetScoreTxt : MonoBehaviour
{
    public TMP_Text Score;

    private void Start()
    {
        Score = GetComponent<TMP_Text>();
    }
    void Update()
    {
        Score.text = Enemy.kills.ToString();
    }
}