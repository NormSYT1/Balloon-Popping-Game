using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button1 : MonoBehaviour
{
    public void Other_Scene()
    {
        SceneManager.LoadScene("GameScene");//Oyun sahnesine geç
    }
    public void Main_Scene()
    {
        SceneManager.LoadScene("MainMenu");//Ana menüye geç
    }
    public void Quit()
    {
        PlayerPrefs.DeleteKey("HighScore");//En yüksek skoru siler
        Application.Quit();//Oyunu kapat
    }
}
