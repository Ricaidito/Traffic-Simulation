using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonata2 : MonoBehaviour
{
    private float CarSpeed = 2f;
    public GameObject CanRun;
    public bool Control1;

    void Start()
    {
        Control1 = false;
        transform.position = new Vector2(7.46f, 0.45f);
        transform.Rotate(0, 0, 180);
        CanRun = GameObject.Find("semaforo1");
    }

    void Update()
    {
        if (CanRun.GetComponent<semaforo1>().CarsCanRun || Control1)
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
            Control1 = true;
        }
    }
}
