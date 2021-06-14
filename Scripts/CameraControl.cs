using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject target;
    public Vector3 offset = new Vector3(0, 0, -1);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (target)
        {
            transform.position = new Vector3(transform.position.x * offset.x,
                transform.position.y * offset.y,
                transform.position.z * offset.z);


        }
    }
}
