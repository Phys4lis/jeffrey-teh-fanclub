using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaintainingBalance : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.eulerAngles.x >= 40)
        {
            transform.rotation = Quaternion.Euler(transform.eulerAngles.x - 1, transform.eulerAngles.y, transform.eulerAngles.z);
        }
        if(transform.eulerAngles.y>= 70)
        {
            transform.rotation = Quaternion.Euler(transform.eulerAngles.x, transform.eulerAngles.y-1, transform.eulerAngles.z);
        }
        if(transform.eulerAngles.z >= 70)
        {
            transform.rotation = Quaternion.Euler(transform.eulerAngles.x, transform.eulerAngles.y, transform.eulerAngles.z - 1);
        }
    }
}
