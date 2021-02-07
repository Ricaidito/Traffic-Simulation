using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class semaforo2 : MonoBehaviour
{
    public GameObject RedLight;
    public GameObject YellowLight;
    public GameObject GreenLight;
    public bool CarsCanRun;

    void Start()
    {
        StartCoroutine(SistemaLuces());
    }

    void Semaforo2Rojo()
    {
        RedLight.SetActive(true);
        YellowLight.SetActive(false);
        GreenLight.SetActive(false);
        CarsCanRun = false;
    }

    void Semaforo2Amarillo()
    {
        RedLight.SetActive(false);
        YellowLight.SetActive(true);
        GreenLight.SetActive(false);
        CarsCanRun = true;
    }

    void Semaforo2Verde()
    {
        RedLight.SetActive(false);
        YellowLight.SetActive(false);
        GreenLight.SetActive(true);
        CarsCanRun = true;
    }

    IEnumerator SistemaLuces()
    {
        while (true)
        {
            Semaforo2Rojo();
            yield return new WaitForSeconds(5);
            Semaforo2Verde();
            yield return new WaitForSeconds(3);
            Semaforo2Amarillo();
            yield return new WaitForSeconds(2);
        }
    }
}
