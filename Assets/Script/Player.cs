using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private GameObject Camera;
    MainCam maincam;
    // Start is called before the first frame update
    void Start()
    {
        Camera = GameObject.Find("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            maincam = Camera.GetComponent<MainCam>();
        }
        if (maincam != null)
        {
            this.transform.position = Vector3.MoveTowards(transform.position, maincam.TargetPosition, 10 * Time.deltaTime);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }
}
