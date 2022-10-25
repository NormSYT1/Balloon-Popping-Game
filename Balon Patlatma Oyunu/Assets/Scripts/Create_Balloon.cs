using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create_Balloon : MonoBehaviour
{
    public GameObject balloon1;//Balon için gerekli oyun nesnesi deðiþkenleri
    public GameObject balloon2;
    public GameObject balloon3;
    public GameObject balloon4;
    float time1 = 1.1f, counter1 = 1.1f;//Süre-sayaç deðiþkenleri
    float time2 = 4.3f, counter2 = 4.3f;
    float time3 = 7.9f, counter3 = 7.9f;
    float time4 = 10f, counter4 = 10f;
    Game_Control control2;//Baþka script'deki deðiþkenleri kullanmak için gerekli deðiþken
    void Start()
    {
        control2 = GameObject.Find("GameObject").GetComponent<Game_Control>();//Gerekli oyun nesnesini (GameObject isimli nesneyi) bul
    }
    void Update()
    {
        float x = 1.0f;//Katsayý deðiþkeni
        if (control2.time_counter < 50)
        {
            x = (int)(control2.time_counter / 10) - 6;
            x *= -1;
            x /= 1.8f;//Süre her 10 saniye azaldýðýnda x deðerini arttýrýr
        }
        counter1 -= Time.deltaTime;//Sayacý azalt
        if (counter1 < 0 && control2.time_counter > 0)//(Turuncu balon) Sayaç sýfýrdan küçükse ve süre sýfýrdan büyükse
        {
            GameObject go1 = Instantiate(balloon1, new Vector3(Random.Range(0.75f, 5.55f), -0.8f, 0), Quaternion.Euler(0, 0, 0));//Balon üret
            go1.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, Random.Range(55f*x, 65f*x), 0));//Balona kuvvet uygulamak için gerekli
            counter1 = time1;//Süreyi sayaca eþitle       
        }
        counter2 -= Time.deltaTime;//Sayacý azalt
        if (counter2 < 0 && control2.time_counter > 0 && control2.time_counter < 53)//Sarý balon
        {
            GameObject go2 = Instantiate(balloon2, new Vector3(Random.Range(0.75f, 5.55f), -0.8f, 0), Quaternion.Euler(0, 0, 0));//Balon üret
            go2.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, Random.Range(65f * x, 80f * x), 0));//Balona kuvvet uygulamak için gerekli
            counter2 = time2;//Süreyi sayaca eþitle
        }
        counter3 -= Time.deltaTime;//Sayacý azalt
        if (counter3 < 0 && control2.time_counter > 0 && control2.time_counter < 43)//Kýrmýzý balon  
        {            
            GameObject go3 = Instantiate(balloon3, new Vector3(Random.Range(0.75f, 5.55f), -0.8f, 0), Quaternion.Euler(0, 0, 0));//Balon üret
            go3.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, Random.Range(80f * x, 100f * x), 0));//Balona kuvvet uygulamak için gerekli
            counter3 = time3;//Süreyi sayaca eþitle
        }
        counter4 -= Time.deltaTime;//Sayacý azalt
        if (counter4 < 0 && control2.time_counter > 0 && control2.time_counter < 35)//Mavi balon 
        {
            GameObject go4 = Instantiate(balloon4, new Vector3(Random.Range(0.75f, 5.55f), -0.8f, 0), Quaternion.Euler(0, 0, 0));//Balon üret
            go4.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, Random.Range(90f * x, 110f * x), 0));//Balona kuvvet uygulamak için gerekli       
            counter4 = time4;//Süreyi sayaca eþitle
        }
    }
}
