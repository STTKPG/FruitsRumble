using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CartAct : MonoBehaviour
{
    private Quaternion CartRot;
    private Vector3 TargetPos;
    private Vector3 BoyPos;
    // Start is called before the first frame update
    void Start()
    {
        CartRot = transform.localRotation;
        TargetPos = new Vector3(0, 0, 0);
        BoyPos = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {

        //CartRot = Quaternion.LookRotation(TargetPos, Vector3.up);
        //CartRot = Quaternion.Slerp(this.transform.rotation, CartRot, Time.deltaTime);
        transform.RotateAround(BoyPos, Vector3.up, /*CartRot.eulerAngles.y*/10);
        Debug.Log(CartRot.eulerAngles.y);
    }

    public void CartRotate(Vector3 targetpos)
    {
        TargetPos = targetpos;
    }

    public void SetBoyPos(Vector3 boypos)
    {
        BoyPos = boypos;
    }
}
