using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text score_text;//En y�ksek skoru yazd�rmak i�in gerekli de�i�ken
    void Start()
    {
        score_text.text = "Highest Score: " + PlayerPrefs.GetInt("HighScore").ToString();//En y�ksek skoru yazd�r
    }
}
