using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Spincracter : MonoBehaviour
{
    public GameObject Pau, Sto,e,gameover;
    public Text score;
    public bool pausespin;
    public float speedx,rotate1,scoresayı;
    // Start is called before the first frame update
    void Start()
    {
        pausespin = false;
        Pau.SetActive(true);
        Sto.SetActive(false);
        gameover.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        GameObject e = GameObject.Find("spincup");
        score.text = "" + scoresayı.ToString("F0");
        if (pausespin == true)
        {
            speedx = 0.1f;
            gameObject.transform.Translate(0, 0, speedx);
        }
        if (pausespin == false)
        {
            speedx = 0;
            gameObject.transform.Translate(0, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.Rotate(0,0,rotate1);
        }
        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.Rotate(0, 0, -rotate1);
        }
    }
    public void Buttons(string paneladi)
    {
        if(paneladi == "starting")
        {
            pausespin = true;
            Sto.SetActive(true);
            Pau.SetActive(false);
        }
        if (paneladi == "stoping")
        {
            pausespin = false;
            Pau.SetActive(true);
            Sto.SetActive(false);
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "duvars")
        {
            scoresayı +=  0.5f;
        }
        if (other.tag == "death")
        {
            gameover.SetActive(true);
            pausespin = false;
        }
    }
}
