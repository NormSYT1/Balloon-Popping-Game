using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button1 : MonoBehaviour
{
    public void Other_Scene()
    {
        SceneManager.LoadScene("SampleScene");//Oyun sahnesine ge�
    }
    public void Main_Scene()
    {
        SceneManager.LoadScene("MainMenu");//Ana men�ye ge�
    }
    public void Quit()
    {
        //PlayerPrefs.DeleteKey("HighScore");//En y�ksek skoru siler
        Application.Quit();//Oyunu kapat
    }
}
