using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruits : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.transform.parent != null)
        {
            if (this.gameObject.transform.parent.tag == "Bucket")
            {
                this.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
            }
        }
         
    }

    public void DestroyMe()
    {
        Destroy(this.gameObject);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Ground")
        {
            Destroy(this.gameObject);
        }
        if (collision.transform.tag == "Bucket")
        {
            Debug.Log("バケツに当たったよ！");
            this.gameObject.transform.parent = collision.transform;
        }
    }
}
