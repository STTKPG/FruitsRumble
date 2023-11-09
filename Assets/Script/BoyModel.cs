using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoyModel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void BoyRotate(Vector3 TouchPos)
    {
        this.transform.LookAt(TouchPos, transform.up);
    }
}
