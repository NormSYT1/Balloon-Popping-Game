using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text score_text;//En yüksek skoru yazdýrmak için gerekli deðiþken
    void Start()
    {
        score_text.text = "Highest Score: " + PlayerPrefs.GetInt("HighScore").ToString();//En yüksek skoru yazdýr
    }
}
