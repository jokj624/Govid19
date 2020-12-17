using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ItemGet : MonoBehaviour
{
    public static Slider healthBarSlider;  //reference for slider
    public static Text hptxt, coronatxt, itemtxt;
    public AudioSource audio2, audio3;
    void Start()
    {
       
        hptxt = GameObject.Find("hp_txt").GetComponent<Text>();
        coronatxt = GameObject.Find("corona_txt").GetComponent<Text>();
        itemtxt = GameObject.Find("item_txt").GetComponent<Text>();
        healthBarSlider=GameObject.Find("Slider").GetComponent<Slider>();
    }

    //Check if player enters/stays on the fire
    void OnCollisionEnter(Collision other)
    {
        
        if (other.gameObject.tag == "item")
        {
            if(healthBarSlider.value <100&& healthBarSlider.value > 0) healthBarSlider.value += 5f;
            playItem();
            itemtxt.text = "ITEM GET!";
            hptxt.text = "+5";
            Invoke("setnull", 1f);
            Destroy(other.gameObject); // delete other object
        }

        //if player triggers fire object and health is greater than 0
        if (other.gameObject.tag == "corona"&& healthBarSlider.value > 0)
        {
          
            playIncorrect();
            healthBarSlider.value -= 5f;  //reduce health
            coronatxt.text = "CORONA!";
            hptxt.text = "-5";
            Invoke("setnull", 1f);

        }
        if(healthBarSlider.value == 0)
        {
            Init.GameOver();
        }

    }
    void setnull()
    {
        itemtxt.text = "";
        coronatxt.text = "";
        hptxt.text = "";
         
    }
    public void playIncorrect()
    {
        audio2.Play();
    }
    public void playItem()
    {
        audio3.Play();
    }
}
