using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManaqer : MonoBehaviour
{
    private GameObject Camera;
    MainCam maincam;
    private GameObject BucketBottom;
    Bucket bucket;
    private Rigidbody PlayerRB;
    BoyAct boyact;
    CartAct cartact;
    [SerializeField]
    private GameObject Boy;
    [SerializeField]
    private GameObject Cart;

    // Start is called before the first frame update
    void Start()
    {
        Camera = GameObject.Find("MainCamera");
        maincam = Camera.GetComponent<MainCam>();
        BucketBottom = GameObject.Find("Bucket");
        bucket = BucketBottom.GetComponent<Bucket>();
        PlayerRB = this.GetComponent<Rigidbody>();
        boyact = Boy.GetComponent<BoyAct>();
        cartact = Cart.GetComponent<CartAct>();
    }

    // Update is called once per frame
    void Update()
    {
        //PlayerRB.AddForce(new Vector3(0, 0, 1) * 50 * Time.deltaTime);
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("ìÆÇ¢ÇƒÇÈÇÊÅI");
            boyact.BoyRotate(maincam.TargetPosition);
            cartact.CartRotate(maincam.TargetPosition);
        }
        if (maincam != null)
        {
            var MovePosition = new Vector3(Mathf.Clamp(maincam.TargetPosition.x, -5.0f, 5.0f), maincam.TargetPosition.y, Mathf.Clamp(maincam.TargetPosition.z, -5.0f, 5.0f));
            this.transform.position = Vector3.MoveTowards(transform.position, MovePosition, 10 * Time.deltaTime);

            //Debug.Log("X:" + TargetPos.x + "Y:" + TargetPos.y + "Z:" + TargetPos.z);

        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Belt")
        {
            bucket.UnPacking();
        }
    }


}
