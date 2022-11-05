using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create_Balloon : MonoBehaviour
{
    public GameObject balloon1;//Balon i�in gerekli oyun nesnesi de�i�kenleri
    public GameObject balloon2;
    public GameObject balloon3;
    public GameObject balloon4;
    float time1 = 1.1f, counter1 = 1.1f;//S�re-saya� de�i�kenleri
    float time2 = 4.3f, counter2 = 4.3f;
    float time3 = 7.9f, counter3 = 7.9f;
    float time4 = 10f, counter4 = 10f;
    Game_Control control2;//Ba�ka script'deki de�i�kenleri kullanmak i�in gerekli de�i�ken
    void Start()
    {
        control2 = GameObject.Find("GameObject").GetComponent<Game_Control>();//Gerekli oyun nesnesini (GameObject isimli nesneyi) bul
    }
    void Update()
    {
        float x = 1.0f;//Katsay� de�i�keni
        if (control2.time_counter < 50)
        {
            x = (int)(control2.time_counter / 10) - 6;
            x *= -1;
            x /= 1.8f;//S�re her 10 saniye azald���nda x de�erini artt�r�r
        }
        counter1 -= Time.deltaTime;//Sayac� azalt
        if (counter1 < 0 && control2.time_counter > 0)//(Turuncu balon) Saya� s�f�rdan k���kse ve s�re s�f�rdan b�y�kse
        {
            GameObject go1 = Instantiate(balloon1, new Vector3(Random.Range(0.75f, 5.55f), -0.8f, 0), Quaternion.Euler(0, 0, 0));//Balon �ret
            go1.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, Random.Range(55f*x, 65f*x), 0));//Balona kuvvet uygulamak i�in gerekli
            counter1 = time1;//S�reyi sayaca e�itle       
        }
        counter2 -= Time.deltaTime;//Sayac� azalt
        if (counter2 < 0 && control2.time_counter > 0 && control2.time_counter < 53)//Sar� balon
        {
            GameObject go2 = Instantiate(balloon2, new Vector3(Random.Range(0.75f, 5.55f), -0.8f, 0), Quaternion.Euler(0, 0, 0));//Balon �ret
            go2.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, Random.Range(65f * x, 80f * x), 0));//Balona kuvvet uygulamak i�in gerekli
            counter2 = time2;//S�reyi sayaca e�itle
        }
        counter3 -= Time.deltaTime;//Sayac� azalt
        if (counter3 < 0 && control2.time_counter > 0 && control2.time_counter < 43)//K�rm�z� balon  
        {            
            GameObject go3 = Instantiate(balloon3, new Vector3(Random.Range(0.75f, 5.55f), -0.8f, 0), Quaternion.Euler(0, 0, 0));//Balon �ret
            go3.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, Random.Range(80f * x, 100f * x), 0));//Balona kuvvet uygulamak i�in gerekli
            counter3 = time3;//S�reyi sayaca e�itle
        }
        counter4 -= Time.deltaTime;//Sayac� azalt
        if (counter4 < 0 && control2.time_counter > 0 && control2.time_counter < 35)//Mavi balon 
        {
            GameObject go4 = Instantiate(balloon4, new Vector3(Random.Range(0.75f, 5.55f), -0.8f, 0), Quaternion.Euler(0, 0, 0));//Balon �ret
            go4.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, Random.Range(90f * x, 110f * x), 0));//Balona kuvvet uygulamak i�in gerekli       
            counter4 = time4;//S�reyi sayaca e�itle
        }
    }
}
