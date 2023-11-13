using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CartAct : MonoBehaviour
{
    private Quaternion CartRot;
    private Vector3 BoyPos;
    // Start is called before the first frame update
    void Start()
    {
        CartRot = transform.localRotation; 
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(BoyPos,);
    }

    public void CartRotate(Vector3 boypos)
    {
        BoyPos = boypos;
    }
}
