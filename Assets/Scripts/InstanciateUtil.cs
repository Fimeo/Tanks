using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciateUtil : MonoBehaviour
{
    public GameObject objectToInstanciate;

    public void InstanciateObject()
    {
        Instantiate(objectToInstanciate);
    }
}
