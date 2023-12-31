using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCam : MonoBehaviour
{
    private Transform Player;
    private Camera MainCamera;
    public Vector3 TargetPosition;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
        MainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = MainCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit HitData = new RaycastHit();
            if(Physics.Raycast(ray,out HitData))
            {
                TargetPosition = HitData.point;
            }
            //var distance = Vector3.Distance(Player.position, MainCamera.transform.position);
            //var mouseposition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 14.5f);
            //TargetPosition = MainCamera.ScreenToWorldPoint(mouseposition);
            Debug.Log("X:" + TargetPosition.x + "Y:" + TargetPosition.y + "Z:" + TargetPosition.z);
        }
        //Debug.Log("X:" + TargetPosition.x + "Y:" + TargetPosition.y + "Z:" + TargetPosition.z);
        //Vector3 MousePosition = Input.mousePosition;
        ////Vector3 TargetPosition = Camera.main.ScreenToWorldPoint(MousePosition);
        //Debug.Log("X:"+MousePosition.x+"Y:"+MousePosition.y+"Z:"+MousePosition.z);
    }
}
