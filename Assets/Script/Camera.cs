using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Camera : MonoBehaviour
{
    public float destroyfloat;
    public GameObject bir,plyr;
    public Transform player,spawn1;
    Spincracter playersc;
    // Start is called before the first frame update
    void Start()
    {
        playersc = plyr.GetComponent<Spincracter>();
        destroyfloat = 0;
        GameObject e = GameObject.Find("spincup");
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = new Vector3(-2.5f, 3,player.position.z-3);
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "duvars")
        {
            //spawn1.transform.position = new Vector3(0, 0, player.position.z + 5);
            //bir.transform.position = new Vector3(spawn1.position.x,spawn1.position.y,spawn1.position.z);
            playersc.pausespin = false;
            playersc.Pau.SetActive(true);
            playersc.Sto.SetActive(false);
        }
    }
}