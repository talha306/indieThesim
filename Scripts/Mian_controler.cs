using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Mian_controler : MonoBehaviour
{
    public float player_speed;
    private Animator anim;
    public Text mytext;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("rigth", false);
        anim.SetBool("down", false);
        anim.SetBool("top", false);
    }

    // Update is called once per frame
    void Update()
    {
        var movementx = SimpleInput.GetAxisRaw("Horizontal");
        var movementy = SimpleInput.GetAxisRaw("Vertical");
        transform.position += new Vector3(movementx, movementy, 0) * Time.deltaTime * player_speed;
        if (movementx > 0)
        {
            anim.SetBool("rigth", false);
        }
        if(movementx<0 || movementx==0)
        {
            anim.SetBool("rigth", true);
        }

        if (movementy > 0)
        {
            anim.SetBool("down", true);
            anim.SetBool("top", false);
        }
        if (movementy < 0)
        {
            anim.SetBool("top", true);
            anim.SetBool("down", false);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if( collision.gameObject.tag == "shop")
        {
            mytext.gameObject.SetActive(true);
            mytext.text = "How may i help u";
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        mytext.gameObject.SetActive(true);
        mytext.text = "Thank You";
        Invoke("time_to_Display", 5);
    }

    private void time_to_Display()
    {
        mytext.gameObject.SetActive(false);
        
    }

    public void previos_scene()
    {
        SceneManager.LoadScene("Lobby");
    }
}
