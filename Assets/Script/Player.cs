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
    // Start is called before the first frame update
    void Start()
    {
        Camera = GameObject.Find("MainCamera");
        maincam = Camera.GetComponent<MainCam>();
        BucketBottom = GameObject.Find("Bucket");
        bucket = BucketBottom.GetComponent<Bucket>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.transform.LookAt(maincam.TargetPosition, transform.up);
        }
        if (maincam != null)
        {
            var MovePosition = new Vector3(Mathf.Clamp(maincam.TargetPosition.x, -5.0f, 5.0f), maincam.TargetPosition.y, Mathf.Clamp(maincam.TargetPosition.z, -5.0f, 5.0f));
            this.transform.position = Vector3.MoveTowards(transform.position, MovePosition, 10 * Time.deltaTime);
            
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
