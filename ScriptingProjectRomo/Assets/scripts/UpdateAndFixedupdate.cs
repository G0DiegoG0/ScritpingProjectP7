using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateAndFixedupdate : MonoBehaviour
{
    void FixedUpdate()
    {
        Debug.Log("Fixedupdate time :" + Time.deltaTime);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("fixedUpdate time :" + Time.deltaTime);
    }
}
