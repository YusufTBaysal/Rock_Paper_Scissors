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
            sonuc.text = "Ta� geldi. Berabere!";
            skor.text = "Galibiyet : " + galibiyet + " Ma�lubiyet : " + maglubiyet;
        }
        if (deger == 2)
        {
            sonuc.text = "Ka��t geldi. Kaybettiniz!";
            maglubiyet++;
            skor.text = "Galibiyet : " + galibiyet + " Ma�lubiyet : " + maglubiyet;
        }
        if (deger == 3)
        {
            sonuc.text = "Makas geldi. Kazand�n�z!";
            galibiyet++;
            skor.text = "Galibiyet : " + galibiyet + " Ma�lubiyet : " + maglubiyet;
        }
        Debug.Log(sonuc.text);
    }

    void Kagit()
    {
        int deger = Random.Range(1, 4);
        if (deger == 1)
        {
            sonuc.text = "Ka��t geldi. Berabere!";
            skor.text = "Galibiyet : " + galibiyet + " Ma�lubiyet : " + maglubiyet;
        }
        if (deger == 2)
        {
            sonuc.text = "Makas geldi. Kaybettiniz!";
            maglubiyet++;
            skor.text = "Galibiyet : " + galibiyet + " Ma�lubiyet : " + maglubiyet;
        }
        if (deger == 3)
        {
            sonuc.text = "Ta� geldi. Kazand�n�z!";
            galibiyet++;
            skor.text = "Galibiyet : " + galibiyet + " Ma�lubiyet : " + maglubiyet;
        }
        Debug.Log(sonuc.text);
    }

    void Makas()
    {
        int deger = Random.Range(1, 4);
        if (deger == 1)
        {
            sonuc.text = "Makas geldi. Berabere!";
            skor.text = "Galibiyet : " + galibiyet + " Ma�lubiyet : " + maglubiyet;
        }
        if (deger == 2)
        {
            sonuc.text = "Ta� geldi. Kaybettiniz!";
            maglubiyet++;
            skor.text = "Galibiyet : " + galibiyet + " Ma�lubiyet : " + maglubiyet;
        }
        if (deger == 3)
        {
            sonuc.text = "Ka��t geldi. Kazand�n�z!";
            galibiyet++;
            skor.text = "Galibiyet : " + galibiyet + " Ma�lubiyet : " + maglubiyet;
        }
        Debug.Log(sonuc.text);
    }

}
