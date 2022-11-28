using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public static CameraFollow Instance;
    public GameObject target;
    public float xoffset, yoffset, zoffset;

    private void Awake()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.transform.position + new Vector3(xoffset, yoffset, zoffset);
        transform.LookAt(target.transform.position);

        
    }
}
