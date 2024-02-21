using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class game : MonoBehaviour
{
    public Text sonuc;
    public Text skor;
    int galibiyet = 0; 
    int maglubiyet = 0;


    public Button tas;
    public Button kagit;
    public Button makas;

    void Start()
    {
        tas.onClick.AddListener(Tas);
        kagit.onClick.AddListener(Kagit);
        makas.onClick.AddListener(Makas);
        
    }


    void Tas()
    {
        int deger = Random.Range(1, 4);
        if (deger == 1)
        {
            sonuc.text = "Taþ geldi. Berabere!";
            skor.text = "Galibiyet : " + galibiyet + " Maðlubiyet : " + maglubiyet;
        }
        if (deger == 2)
        {
            sonuc.text = "Kaðýt geldi. Kaybettiniz!";
            maglubiyet++;
            skor.text = "Galibiyet : " + galibiyet + " Maðlubiyet : " + maglubiyet;
        }
        if (deger == 3)
        {
            sonuc.text = "Makas geldi. Kazandýnýz!";
            galibiyet++;
            skor.text = "Galibiyet : " + galibiyet + " Maðlubiyet : " + maglubiyet;
        }
        Debug.Log(sonuc.text);
    }

    void Kagit()
    {
        int deger = Random.Range(1, 4);
        if (deger == 1)
        {
            sonuc.text = "Kaðýt geldi. Berabere!";
            skor.text = "Galibiyet : " + galibiyet + " Maðlubiyet : " + maglubiyet;
        }
        if (deger == 2)
        {
            sonuc.text = "Makas geldi. Kaybettiniz!";
            maglubiyet++;
            skor.text = "Galibiyet : " + galibiyet + " Maðlubiyet : " + maglubiyet;
        }
        if (deger == 3)
        {
            sonuc.text = "Taþ geldi. Kazandýnýz!";
            galibiyet++;
            skor.text = "Galibiyet : " + galibiyet + " Maðlubiyet : " + maglubiyet;
        }
        Debug.Log(sonuc.text);
    }

    void Makas()
    {
        int deger = Random.Range(1, 4);
        if (deger == 1)
        {
            sonuc.text = "Makas geldi. Berabere!";
            skor.text = "Galibiyet : " + galibiyet + " Maðlubiyet : " + maglubiyet;
        }
        if (deger == 2)
        {
            sonuc.text = "Taþ geldi. Kaybettiniz!";
            maglubiyet++;
            skor.text = "Galibiyet : " + galibiyet + " Maðlubiyet : " + maglubiyet;
        }
        if (deger == 3)
        {
            sonuc.text = "Kaðýt geldi. Kazandýnýz!";
            galibiyet++;
            skor.text = "Galibiyet : " + galibiyet + " Maðlubiyet : " + maglubiyet;
        }
        Debug.Log(sonuc.text);
    }

}
