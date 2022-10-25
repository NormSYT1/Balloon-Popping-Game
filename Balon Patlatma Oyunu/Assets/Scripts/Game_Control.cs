using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Game_Control : MonoBehaviour
{
    public Text time_text, balloon_text, last_text, point_text;//Veri de�i�kenleri
    public float time_counter = 65f;//S�re de�i�keni
    public int balloon_counter = 0;//Patlat�lan balon de�i�keni
    public GameObject last_explosion1;//Son patlama efekti i�in gerekli de�i�kenler
    public GameObject last_explosion2;
    public GameObject last_explosion3;
    public GameObject last_explosion4;
    public AudioClip sound1;//Ses i�in gerekli de�i�ken  
    public AudioClip sound2;//Mavi balonun patlama sesi i�in gerekli 
    public Button click;//Oyun bittikten sonra ��kacak buton de�i�keni
    void Start()
    {       
        balloon_text.text = "Total Score: " + balloon_counter;//Patlat�lan balon say�s�n� yazd�r
    }
    void Update()
    {
        if (time_counter > 0)//S�re s�f�rdan b�y�kse
        {
            time_counter -= Time.deltaTime;//S�reyi 1 azalt
            time_text.text = "Time: " + (int)time_counter;//S�reyi yazd�r
        }
        else//S�re s�f�rdan k���k olursa
        {
            last_text.text = "Game Over";//Oyun bitti yazd�r 
            point_text.text = "Your Score: " + balloon_counter;//Toplam puan� yazd�r
            if(balloon_counter> PlayerPrefs.GetInt("HighScore"))//Puan en y�ksek skordan y�ksek ise
            {
                PlayerPrefs.SetInt("HighScore", balloon_counter);//Puan� en y�ksek skora ata
            }     
            click.gameObject.SetActive(true);//Butonu aktif hale getir
            GameObject[] go1 = GameObject.FindGameObjectsWithTag("Balloon1");//Balloon1 etiketli nesneleri bul ve diziye ekle
            GameObject[] go2 = GameObject.FindGameObjectsWithTag("Balloon2");//Balloon2 etiketli nesneleri bul ve diziye ekle
            GameObject[] go3 = GameObject.FindGameObjectsWithTag("Balloon3");//Balloon3 etiketli nesneleri bul ve diziye ekle
            GameObject[] go4 = GameObject.FindGameObjectsWithTag("Balloon4");//Balloon4 etiketli nesneleri bul ve diziye ekle
            for (int i = 0; i < go1.Length; i++) 
            {
                Instantiate(last_explosion1, go1[i].transform.position, go1[i].transform.rotation);//Son patlama efektini balonlar�n pozisyonuna e�itle
                Destroy(go1[i]);//Nesneleri yok et(patlat)
            }
            for (int i = 0; i < go2.Length; i++)
            {
                Instantiate(last_explosion2, go2[i].transform.position, go2[i].transform.rotation);//Son patlama efektini balonlar�n pozisyonuna e�itle
                Destroy(go2[i]);//Nesneleri yok et(patlat)
            }
            for (int i = 0; i < go3.Length; i++)
            {
                Instantiate(last_explosion3, go3[i].transform.position, go3[i].transform.rotation);//Son patlama efektini balonlar�n pozisyonuna e�itle
                Destroy(go3[i]);//Nesneleri yok et(patlat)
            }
            for (int i = 0; i < go4.Length; i++)
            {
                Instantiate(last_explosion4, go4[i].transform.position, go4[i].transform.rotation);//Son patlama efektini balonlar�n pozisyonuna e�itle
                Destroy(go4[i]);//Nesneleri yok et(patlat)
            }
        }
    }
    public void Add1()//Turuncu balon i�in
    {
        balloon_counter++;//Puan� 1 artt�r
        balloon_text.text = "Total Score: " + balloon_counter;//Puan� yazd�r
        GetComponent<AudioSource>().PlayOneShot(sound1);//Patlama i�in gerekli sesi �al
    }
    public void Add2()//Sar� balon i�in
    {
        balloon_counter+=2;//Puan� 2 artt�r
        balloon_text.text = "Total Score: " + balloon_counter;//Puan� yazd�r
        GetComponent<AudioSource>().PlayOneShot(sound1);//Patlama i�in gerekli sesi �al
    }
    public void Add3()//K�rm�z� balon i�in
    {
        balloon_counter += 3;//Puan� 3 artt�r
        balloon_text.text = "Total Score: " + balloon_counter;//Puan� yazd�r
        GetComponent<AudioSource>().PlayOneShot(sound1);//Patlama i�in gerekli sesi �al
    }
    public void Add4()//Mavi balon i�in
    {
        time_counter += 4;//S�reyi 4 artt�r
        time_text.text = "Time: " + time_counter;//S�reyi yazd�r
        GetComponent<AudioSource>().PlayOneShot(sound2);//Patlama i�in gerekli sesi �al
    }
}
