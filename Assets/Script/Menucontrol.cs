using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menucontrol : MonoBehaviour
{
    Spincracter characters;
    public GameObject scriptcharacter;
    public Text scoresayı;
    public GameObject[] spinengel;
    // Start is called before the first frame update
    void Start()
    {
        characters = scriptcharacter.GetComponent<Spincracter>();
        spinengel[0] = GameObject.Find("Spinengel");
        spinengel[1] = GameObject.Find("Spinengel (1)");
        spinengel[2] = GameObject.Find("Spinengel (2)");
    }

    // Update is called once per frame
    void Update()
    {
        scoresayı.text = "" + characters.scoresayı.ToString("F0");
    }
    public void ButtonControl(string paneladi)
    {
        if (paneladi == "restart")
        {
            characters.scoresayı = 0;
            characters.gameover.SetActive(false);
            scriptcharacter.transform.position = new Vector3(0,0,0);
            characters.pausespin = false;
            characters.Pau.SetActive(true);
            characters.Sto.SetActive(false);
            Debug.Log("ytr");
            spinengel[0].transform.position = new Vector3(0, 0, 20);
            spinengel[1].transform.position = new Vector3(0, 0, 40);
            spinengel[2].transform.position = new Vector3(0, 0, 60);
        }
    }
}
