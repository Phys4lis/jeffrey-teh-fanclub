using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YPosition : MonoBehaviour
{
    // Start is called before the first frame update
    Transform temporaryTransform;
    void Start()
    {
        temporaryTransform = GameObject.Find("lumino").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(temporaryTransform.position.x, temporaryTransform.position.y + 4, temporaryTransform.position.z-12);
    }
}
