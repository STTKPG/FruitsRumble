using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Z_Test : MonoBehaviour
{
    Rigidbody RB;
    // Start is called before the first frame update
    void Start()
    {
        RB = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        var Test = new Vector3(0,0,10 * Time.deltaTime);
        RB.AddForce(Test);
    }
}
