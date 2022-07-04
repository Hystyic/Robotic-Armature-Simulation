using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueGen : MonoBehaviour
{
    public GameObject blueobject;
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(blueobject,this.transform.position,Quaternion.identity);
        }

    }
}
