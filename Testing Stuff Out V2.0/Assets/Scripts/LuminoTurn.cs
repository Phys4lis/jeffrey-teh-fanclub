using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuminoTurn : MonoBehaviour
{
    // Start is called before the first frame update
    Transform temporaryTransform;
    void Start()
    {
        temporaryTransform = GameObject.Find("Main Camera").transform;

    }

    // Update is called once per frame
    void Update()
    {
        System.Console.WriteLine(temporaryTransform.rotation.y);
        transform.rotation = Quaternion.Euler(0, 90, 0);
    }
}
