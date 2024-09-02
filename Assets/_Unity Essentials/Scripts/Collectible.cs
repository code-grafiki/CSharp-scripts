using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Callbacks;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public float rotationSpeed;
    public GameObject onCollectEffect;
    

    void Start()
    {

    }

    void Update()
    {
        transform.Rotate(0,rotationSpeed,0);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
        //destroy the collectible
        Destroy(gameObject);

        //instantiate the particle effect
        Instantiate(onCollectEffect, transform.position, transform.rotation); 
        }
        
    }
}
