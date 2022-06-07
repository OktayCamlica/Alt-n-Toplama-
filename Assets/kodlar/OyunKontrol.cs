using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OyunKontrol : MonoBehaviour
{

    public bool oyunAktif = true;
    public int altinSayisi = 0;
    public Text altinSayisiText;
    public Button baslaButonu;
  // public AudioSource arkaPlan;
    void Start()
    {
        GetComponent<AudioSource>().Play();
    }

  
    void Update()
    {
        
    }
  public  void AltinArttir()
    {
        altinSayisi += 1;
        altinSayisiText.text = "" + altinSayisi;
    }
        public void OyunaBasla()
    {
        oyunAktif = true;
        baslaButonu.gameObject.SetActive(false);
    }
        
}
