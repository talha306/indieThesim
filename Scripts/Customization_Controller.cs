using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Customization_Controller : MonoBehaviour
{
    public Sprite[] Shirts,shorts,shoes,socks;

    public GameObject upper_body, lower_body , Feet, lower_legs;
   
    // button for shirt changes 
    public void Shirt_changer(int num) 
    {
        upper_body.transform.GetComponent<Image>().sprite = Shirts[num] ;
    }

    public void Shorts_Changer(int num)
    {
        lower_body.transform.GetComponent<Image>().sprite = shorts[num];
    }
    

    public void Shoes_changer(int num)
    {
        Feet.transform.GetComponent<Image>().sprite = shoes[num];
    }

    public void Shocks_Changer(int num)
    {
        lower_legs.GetComponent<Image>().sprite = socks[num];
    }

    public void Auto_Customization()
    {
        if(Shirts[0] || shorts[0] || shoes[0] || socks[0])
        {
            upper_body.GetComponent<Image>().sprite = Shirts[0];
            lower_legs.GetComponent<Image>().sprite = socks[0];
            lower_body.GetComponent<Image>().sprite = shorts[0];
            Feet.GetComponent<Image>().sprite = shoes[0];
        }

        if(Shirts[1] || shorts[1] || shoes[1] || socks[1])
        {
            upper_body.GetComponent<Image>().sprite = Shirts[1];
            lower_legs.GetComponent<Image>().sprite = socks[1];
            lower_body.GetComponent<Image>().sprite = shorts[1];
            Feet.GetComponent<Image>().sprite = shoes[1];
        }

        if (Shirts[2] || shorts[2] || shoes[2] || socks[2])
        {
            upper_body.GetComponent<Image>().sprite = Shirts[2];
            lower_legs.GetComponent<Image>().sprite = socks[2];
            lower_body.GetComponent<Image>().sprite = shorts[2];
            Feet.GetComponent<Image>().sprite = shoes[2];
        }

        if (Shirts[3] || shorts[3] || shoes[3] || socks[3])
        {
            upper_body.GetComponent<Image>().sprite = Shirts[3];
            lower_legs.GetComponent<Image>().sprite = socks[3];
            lower_body.GetComponent<Image>().sprite = shorts[3];
            Feet.GetComponent<Image>().sprite = shoes[3];
        }

        if (Shirts[4] || shorts[4] || shoes[4] || socks[4])
        {
            upper_body.GetComponent<Image>().sprite = Shirts[4];
            lower_legs.GetComponent<Image>().sprite = socks[4];
            lower_body.GetComponent<Image>().sprite = shorts[4];
            Feet.GetComponent<Image>().sprite = shoes[4];
        }

        if (Shirts[5] || shorts[5] || shoes[5] || socks[5])
        {
            upper_body.GetComponent<Image>().sprite = Shirts[5];
            lower_legs.GetComponent<Image>().sprite = socks[5];
            lower_body.GetComponent<Image>().sprite = shorts[5];
            Feet.GetComponent<Image>().sprite = shoes[5];
        }

        if (Shirts[6] || shorts[6] || shoes[6] || socks[6])
        {
            upper_body.GetComponent<Image>().sprite = Shirts[6];
            lower_legs.GetComponent<Image>().sprite = socks[6];
            lower_body.GetComponent<Image>().sprite = shorts[6];
            Feet.GetComponent<Image>().sprite = shoes[6];
        }

        if (Shirts[7] || shorts[7] || shoes[7] || socks[7])
        {
            upper_body.GetComponent<Image>().sprite = Shirts[7];
            lower_legs.GetComponent<Image>().sprite = socks[7];
            lower_body.GetComponent<Image>().sprite = shorts[7];
            Feet.GetComponent<Image>().sprite = shoes[7];
        }

        if (Shirts[8] || shorts[8] || shoes[8] || socks[8])
        {
            upper_body.GetComponent<Image>().sprite = Shirts[8];
            lower_legs.GetComponent<Image>().sprite = socks[8];
            lower_body.GetComponent<Image>().sprite = shorts[8];
            Feet.GetComponent<Image>().sprite = shoes[8];
        }

        if (Shirts[9] || shorts[9] || shoes[9] || socks[9])
        {
            upper_body.GetComponent<Image>().sprite = Shirts[9];
            lower_legs.GetComponent<Image>().sprite = socks[9];
            lower_body.GetComponent<Image>().sprite = shorts[9];
            Feet.GetComponent<Image>().sprite = shoes[9];
        }

        if (Shirts[10] || shorts[10] || shoes[10] || socks[10])
        {
            upper_body.GetComponent<Image>().sprite = Shirts[10];
            lower_legs.GetComponent<Image>().sprite = socks[10];
            lower_body.GetComponent<Image>().sprite = shorts[10];
            Feet.GetComponent<Image>().sprite = shoes[10];
        }

        if (Shirts[11] || shorts[11] || shoes[11] || socks[11])
        {
            upper_body.GetComponent<Image>().sprite = Shirts[11];
            lower_legs.GetComponent<Image>().sprite = socks[11];
            lower_body.GetComponent<Image>().sprite = shorts[11];
            Feet.GetComponent<Image>().sprite = shoes[11];
        }

        if (Shirts[12] || shorts[12] || shoes[12] || socks[12])
        {
            upper_body.GetComponent<Image>().sprite = Shirts[12];
            lower_legs.GetComponent<Image>().sprite = socks[12];
            lower_body.GetComponent<Image>().sprite = shorts[12];
            Feet.GetComponent<Image>().sprite = shoes[12];
        }

        if (Shirts[13] || shorts[13] || shoes[13] || socks[13])
        {
            upper_body.GetComponent<Image>().sprite = Shirts[13];
            lower_legs.GetComponent<Image>().sprite = socks[13];
            lower_body.GetComponent<Image>().sprite = shorts[13];
            Feet.GetComponent<Image>().sprite = shoes[13];
        }

        if (Shirts[14] || shorts[14] || shoes[14] || socks[14])
        {
            upper_body.GetComponent<Image>().sprite = Shirts[14];
            lower_legs.GetComponent<Image>().sprite = socks[14];
            lower_body.GetComponent<Image>().sprite = shorts[14];
            Feet.GetComponent<Image>().sprite = shoes[14];
        }
        if (Shirts[15] || shorts[15] || shoes[15] || socks[15])
        {
            upper_body.GetComponent<Image>().sprite = Shirts[15];
            lower_legs.GetComponent<Image>().sprite = socks[15];
            lower_body.GetComponent<Image>().sprite = shorts[15];
            Feet.GetComponent<Image>().sprite = shoes[15];
        }
    }

    public void back_togame_play()
    {
        SceneManager.LoadScene("Custmozation");
    }

}