using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Game_Control : MonoBehaviour
{
    public Text time_text, balloon_text, last_text, point_text;//Veri deðiþkenleri
    public float time_counter = 65f;//Süre deðiþkeni
    public int balloon_counter = 0;//Patlatýlan balon deðiþkeni
    public GameObject last_explosion1;//Son patlama efekti için gerekli deðiþkenler
    public GameObject last_explosion2;
    public GameObject last_explosion3;
    public GameObject last_explosion4;
    public AudioClip sound1;//Ses için gerekli deðiþken  
    public AudioClip sound2;//Mavi balonun patlama sesi için gerekli 
    public Button click;//Oyun bittikten sonra çýkacak buton deðiþkeni
    void Start()
    {       
        balloon_text.text = "Total Score: " + balloon_counter;//Patlatýlan balon sayýsýný yazdýr
    }
    void Update()
    {
        if (time_counter > 0)//Süre sýfýrdan büyükse
        {
            time_counter -= Time.deltaTime;//Süreyi 1 azalt
            time_text.text = "Time: " + (int)time_counter;//Süreyi yazdýr
        }
        else//Süre sýfýrdan küçük olursa
        {
            last_text.text = "Game Over";//Oyun bitti yazdýr 
            point_text.text = "Your Score: " + balloon_counter;//Toplam puaný yazdýr
            if (balloon_counter > PlayerPrefs.GetInt("HighScore")) //Puan en yüksek skordan yüksek ise
            {
                PlayerPrefs.SetInt("HighScore", balloon_counter);//Puaný en yüksek skora ata
            }     
            click.gameObject.SetActive(true);//Butonu aktif hale getir
            GameObject[] go1 = GameObject.FindGameObjectsWithTag("Balloon1");//Balloon1 etiketli nesneleri bul ve diziye ekle
            GameObject[] go2 = GameObject.FindGameObjectsWithTag("Balloon2");//Balloon2 etiketli nesneleri bul ve diziye ekle
            GameObject[] go3 = GameObject.FindGameObjectsWithTag("Balloon3");//Balloon3 etiketli nesneleri bul ve diziye ekle
            GameObject[] go4 = GameObject.FindGameObjectsWithTag("Balloon4");//Balloon4 etiketli nesneleri bul ve diziye ekle
            for (int i = 0; i < go1.Length; i++) 
            {
                Instantiate(last_explosion1, go1[i].transform.position, go1[i].transform.rotation);//Son patlama efektini balonlarýn pozisyonuna eþitle
                Destroy(go1[i]);//Nesneleri yok et(patlat)
            }
            for (int i = 0; i < go2.Length; i++)
            {
                Instantiate(last_explosion2, go2[i].transform.position, go2[i].transform.rotation);//Son patlama efektini balonlarýn pozisyonuna eþitle
                Destroy(go2[i]);//Nesneleri yok et(patlat)
            }
            for (int i = 0; i < go3.Length; i++)
            {
                Instantiate(last_explosion3, go3[i].transform.position, go3[i].transform.rotation);//Son patlama efektini balonlarýn pozisyonuna eþitle
                Destroy(go3[i]);//Nesneleri yok et(patlat)
            }
            for (int i = 0; i < go4.Length; i++)
            {
                Instantiate(last_explosion4, go4[i].transform.position, go4[i].transform.rotation);//Son patlama efektini balonlarýn pozisyonuna eþitle
                Destroy(go4[i]);//Nesneleri yok et(patlat)
            }
        }
    }
    public void Add1()//Turuncu balon için
    {
        balloon_counter++;//Puaný 1 arttýr
        balloon_text.text = "Total Score: " + balloon_counter;//Puaný yazdýr
        GetComponent<AudioSource>().PlayOneShot(sound1);//Patlama için gerekli sesi çal
    }
    public void Add2()//Sarý balon için
    {
        balloon_counter+=2;//Puaný 2 arttýr
        balloon_text.text = "Total Score: " + balloon_counter;//Puaný yazdýr
        GetComponent<AudioSource>().PlayOneShot(sound1);//Patlama için gerekli sesi çal
    }
    public void Add3()//Kýrmýzý balon için
    {
        balloon_counter += 3;//Puaný 3 arttýr
        balloon_text.text = "Total Score: " + balloon_counter;//Puaný yazdýr
        GetComponent<AudioSource>().PlayOneShot(sound1);//Patlama için gerekli sesi çal
    }
    public void Add4()//Mavi balon için
    {
        time_counter += 4;//Süreyi 4 arttýr
        time_text.text = "Time: " + time_counter;//Süreyi yazdýr
        GetComponent<AudioSource>().PlayOneShot(sound2);//Patlama için gerekli sesi çal
    }
}
