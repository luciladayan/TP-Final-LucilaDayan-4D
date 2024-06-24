using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCRIPTBANCO : MonoBehaviour
{
    public GameObject[] objetos;
    public int currentObjectIndex = -1;

    void Start()
    {
        DeactivateAllObjects();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            ActivatePreviousObject();
        }
        else if ((Input.GetKeyDown(KeyCode.RightArrow)))
        {
            ActivateNextObject();
        }

    }

    public void ActivateNextObject()
    {
        currentObjectIndex++;
        if (currentObjectIndex >= objetos.Length)
        {
            currentObjectIndex = 0;
        }
        DeactivateAllObjects();
        objetos[currentObjectIndex].SetActive(true);
    }

    public void ActivatePreviousObject()
    {
        currentObjectIndex--;
        if (currentObjectIndex < 0)
        {
            currentObjectIndex = objetos.Length - 1;
        }
        DeactivateAllObjects();
        objetos[currentObjectIndex].SetActive(true);
    }

    void DeactivateAllObjects()
    {
        foreach (GameObject g in objetos)
        {
            g.SetActive(false);
        }
    }

}