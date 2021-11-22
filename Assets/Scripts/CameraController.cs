using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] GameObject[] cameras;
    private KeyCode[] cameraKeys = new KeyCode[] {KeyCode.F1, KeyCode.F2, KeyCode.F3};
    void Start()
    {

    }

    void Update()
    {
        Array();
    }
    private void Array()
    {
        for (int i = 0; i < cameraKeys.Length; i++)
        {
            if (Input.GetKeyDown(cameraKeys[i]))
            {
                for (int j = 0; j < cameras.Length; j++)
                {
                    cameras[j].SetActive((i == j) ? true : false);
                }
            }
        }
    }

} 
