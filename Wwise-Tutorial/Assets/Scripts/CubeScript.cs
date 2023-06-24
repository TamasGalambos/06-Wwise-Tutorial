using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    [Header("Wwise Variablen")]
    public AK.Wwise.Event cubeSound; 

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            cubeSound.Post(gameObject);
        }
    }
}
