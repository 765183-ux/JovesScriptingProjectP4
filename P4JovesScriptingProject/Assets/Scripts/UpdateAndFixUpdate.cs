using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateAndFixUpdate : MonoBehaviour
{
    void FixedUpdate()
    {
        Debug.Log("FixedUpdate time :" + Time.deltaTime);
    }
     

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Update time :" + Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update time :" + Time.deltaTime);
    }
}
