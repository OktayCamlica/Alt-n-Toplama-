using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public AudioClip altinSes, dusme;
    public OyunKontrol oyunK;
   
    float speed = 10;
    void Start()
    {
        oyunK = FindObjectOfType<OyunKontrol>();
     
    }


    void Update()
    {
        if (oyunK.oyunAktif)
        {
            float x = Input.GetAxis("Horizontal");
            float y = Input.GetAxis("Vertical");
            x *= Time.deltaTime * speed;
            y *= Time.deltaTime * speed;

            transform.Translate(x, 0f, y);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("altin"))      
        {
            AudioSource.PlayClipAtPoint(altinSes, transform.position);
            oyunK.AltinArttir();
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag.Equals("sonaltin"))
        {
            oyunK.oyunAktif = false;
            Destroy(collision.gameObject);
            

        }
        else if(collision.gameObject.tag.Equals("dusman"))
        {
            AudioSource.PlayClipAtPoint(dusme, transform.position);


            oyunK.oyunAktif = false;
        }
    }
}
