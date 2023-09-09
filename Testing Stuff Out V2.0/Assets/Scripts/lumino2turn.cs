using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lumino2turn : MonoBehaviour
{
    // Start is called before the first frame update

        public Transform mainCamera;


    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(0, mainCamera.transform.eulerAngles.y, 0);
    }
}
