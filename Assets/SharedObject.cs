using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharedObject : MonoBehaviour
{
    private bool deteccion1 = false;
    private bool deteccion2 = false;

    public GameObject objeto;
    void Update()
    {
        if(deteccion1&&deteccion2)
        {
            objeto.SetActive(true);
        }
        else
        {
            objeto.SetActive(false);
        }
    }

    public void detectado1(bool valor)
    {
        deteccion1 = valor;
    }
    public void detectado2(bool valor)
    {
        deteccion2 = valor;
    }
}
