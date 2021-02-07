using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class semaforo1 : MonoBehaviour
{
    public GameObject RedLight;
    public GameObject YellowLight;
    public GameObject GreenLight;
    public bool CarsCanRun;

    void Start()
    {
        StartCoroutine(SistemaLuces());
    }

    void Semaforo1Rojo() 
    {
        RedLight.SetActive(true);
        YellowLight.SetActive(false);
        GreenLight.SetActive(false);
        CarsCanRun = false;
    }
    
    void Semaforo1Amarillo()
    {
        RedLight.SetActive(false);
        YellowLight.SetActive(true);
        GreenLight.SetActive(false);
        CarsCanRun = true;
    }
    
    void Semaforo1Verde()
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
            Semaforo1Verde();
            yield return new WaitForSeconds(3);
            Semaforo1Amarillo();
            yield return new WaitForSeconds(2);
            Semaforo1Rojo();
            yield return new WaitForSeconds(5);
        }
    }
}
