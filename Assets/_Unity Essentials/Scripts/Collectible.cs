using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public float rotationSpeed;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(0,rotationSpeed,0);
    }
    private void OnTriggerEnter(Collider other)
    {
        //destroy the collectible
        Destroy(gameObject);
    }
}
