using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonata4 : MonoBehaviour
{
    private float CarSpeed = 2f;
    public GameObject CanRun;
    public bool Control2;

    void Start()
    {
        Control2 = false;
        transform.position = new Vector2(-0.40f, 4.21f);
        transform.Rotate(0, 0, 270);
        CanRun = GameObject.Find("semaforo3");
    }

    void Update()
    {
        if (CanRun.GetComponent<semaforo2>().CarsCanRun || Control2)
        {
            transform.Translate(new Vector2(2f, 0) * CarSpeed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "destroyer")
        {
            Destroy(this.gameObject);
        }

        if (collision.tag == "keepRunningBox")
        {
            Control2 = true;
        }
    }
}
