using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenGen : MonoBehaviour
{
    public GameObject greenobject;
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.G))
        {
            Instantiate(greenobject,this.transform.position,Quaternion.identity);
        }

    }
}
