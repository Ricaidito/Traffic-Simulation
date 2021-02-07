using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonataSpawner : MonoBehaviour
{
    public GameObject sonata1;
    public GameObject sonata2;
    public GameObject sonata3;
    public GameObject sonata4;
    public semaforo1 semaforo1;
    public semaforo2 semaforo2;

    void Start()
    {
        InvokeRepeating("SpawnSonata", 1f, 1f);
    }

    void SpawnSonata() 
    {
        if (semaforo1.CarsCanRun)
        {
            Instantiate(sonata1, transform.position, Quaternion.identity);
            Instantiate(sonata2, transform.position, Quaternion.identity);
        }

        if (semaforo2.CarsCanRun)
        {
            Instantiate(sonata3, transform.position, Quaternion.identity);
            Instantiate(sonata4, transform.position, Quaternion.identity);
        }
    }
}
