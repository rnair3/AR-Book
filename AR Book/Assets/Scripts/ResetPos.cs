using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPos : MonoBehaviour
{
    Vector3 originalPos;
    // Start is called before the first frame update
    void Start()
    {
        originalPos = transform.localPosition;
    }

    
    private void OnTriggerEnter(Collider other)
    {
        transform.localPosition = originalPos;
    }
}
