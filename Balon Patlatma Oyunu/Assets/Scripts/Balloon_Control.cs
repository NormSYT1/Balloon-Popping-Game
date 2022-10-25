using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Balloon_Control : MonoBehaviour
{
    public GameObject explosion;//Patlama efekti için gerekli oyun nesnesi deðiþkeni  
    Game_Control control1;//Baþka script'deki deðiþkenleri kullanmak için gerekli deðiþken
    void Start()
    {
        control1 = GameObject.Find("GameObject").GetComponent<Game_Control>();//Gerekli oyun nesnesini (GameObject isimli nesneyi) bul
    }
    void Update()
    {
        if (transform.position.y > 11.0f)//Nesne ekranýn dýþýna çýkarsa
        {
            Destroy(gameObject);//Nesneyi yok et
        }
    }
    void OnMouseDown()//Fareye týklandýðýnda
    {
        GameObject go = Instantiate(explosion, transform.position, transform.rotation);//Patlama efektini balonlarýn olduðu pozisyona eþitle        
        Destroy(this.gameObject);//Nesneyi(Balonu) yok et
        Destroy(go,0.267f);//Patlama efektini girilen saniyede  yok et       
        if (gameObject.tag == "Balloon1")//Etiket 'Balloon1' ise 
        {
            control1.Add1();//1.fonksiyonu çaðýr
        }
        else if (gameObject.tag == "Balloon2")//Etiket 'Balloon2' ise
        {
            control1.Add2();//2.fonksiyonu çaðýr
        }
        else if (gameObject.tag == "Balloon3")//Etiket 'Balloon3' ise
        {
            control1.Add3();//3.fonksiyonu çaðýr
        }
        else if (gameObject.tag == "Balloon4")//Etiket 'Balloon4' ise
        {
            control1.Add4();//4.fonksiyonu çaðýr
        }
    } 
}
