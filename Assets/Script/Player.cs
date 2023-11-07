using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    private GameObject Camera;
    MainCam maincam;
    private GameObject BucketBottom;
    Bucket bucket;
    private Rigidbody PlayerRB;
    // Start is called before the first frame update
    void Start()
    {
        Camera = GameObject.Find("MainCamera");
        maincam = Camera.GetComponent<MainCam>();
        BucketBottom = GameObject.Find("Bucket");
        bucket = BucketBottom.GetComponent<Bucket>();
        PlayerRB = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerRB.AddForce(new Vector3(0, 0, 1) * 50 * Time.deltaTime);
        if (Input.GetMouseButtonDown(0))
        {
            this.transform.LookAt(maincam.TargetPosition, transform.up);
        }
        if (maincam != null)
        {
            var MovePosition = new Vector3(Mathf.Clamp(maincam.TargetPosition.x, -5.0f, 5.0f), maincam.TargetPosition.y, Mathf.Clamp(maincam.TargetPosition.z, -5.0f, 5.0f));
            var TestPos = Vector3.MoveTowards(transform.position, MovePosition, 10 * Time.deltaTime);
            //Debug.Log("X:" + TestPos.x + "Y:" + TestPos.y + "Z:" + TestPos.z);
            
            
            
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Belt")
        {
            bucket.UnPacking();
        }
    }


}
