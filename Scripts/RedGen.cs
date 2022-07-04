using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedGen : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject redobject;
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            Instantiate(redobject,this.transform.position,Quaternion.identity);
        }

    }
}
