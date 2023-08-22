using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
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
        transform.Rotate(temporaryTransform.rotation.x - transform.rotation.x, temporaryTransform.rotation.y - transform.rotation.y, 0);
    }
}
