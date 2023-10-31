using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 MousePosition = Input.mousePosition;
            Vector3 TargetPosition = Camera.main.ScreenToWorldPoint(MousePosition);
            Debug.Log(TargetPosition);
        }
    }
}