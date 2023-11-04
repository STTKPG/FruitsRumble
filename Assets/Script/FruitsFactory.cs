using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitsFactory : MonoBehaviour
{
    public GameObject Fruits;
    private float Timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer > 5)
        {
            var createposition = new Vector3(Random.Range(-5.0f, 5.0f), this.transform.position.y, Random.Range(-5.0f, 5.0f));
            Instantiate(Fruits, createposition,this.transform.rotation);
            Timer = 0;
        }
        Timer += Time.deltaTime;
    }
}
