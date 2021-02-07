using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlTiempo : MonoBehaviour
{
    public void TNormal() 
    {
        Time.timeScale = 1;
    }

    public void TLento() 
    {
        Time.timeScale = 0.3f;
    }

    public void TRapido() 
    {
        Time.timeScale = 3;
    }
}
