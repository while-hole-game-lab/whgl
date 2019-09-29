using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engel : MonoBehaviour
{
    public float karar;
    // Start is called before the first frame update
    void Start()
    {
        karar = Random.Range(0, 100);
    }

    // Update is called once per frame
    void Update()
    {
        if (karar >= 0 && karar <= 15)
        {
            gameObject.transform.eulerAngles -= new Vector3(0,0,0.5f);
        }
        if (karar >= 16 && karar <= 50)
        {
            gameObject.transform.eulerAngles = new Vector3(0, -180, 90);
        }
        if (karar >= 51 && karar <= 60)
        {
            gameObject.transform.eulerAngles = new Vector3(0, -180, 40);
        }
        if (karar >= 61 && karar <= 70)
        {
            gameObject.transform.eulerAngles = new Vector3(0, -180, 80);
        }
        if (karar >= 71 && karar <= 80)
        {
            gameObject.transform.eulerAngles = new Vector3(0, -180, 160);
        }
        if (karar >= 81 && karar <= 90)
        {
            gameObject.transform.eulerAngles = new Vector3(0, -180, 240);
        }
        if (karar >= 91 && karar <= 100)
        {
            gameObject.transform.eulerAngles = new Vector3(0, -180, 320);
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Camera")
        {
            gameObject.transform.position += new Vector3(0,0,60);
            karar = Random.Range(0,100);
        }
    }
}
