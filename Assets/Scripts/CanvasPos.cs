using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasPos : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Camera.main.transform.position);
        transform.localScale = new Vector3(-1, 1, 1);
    }
}
