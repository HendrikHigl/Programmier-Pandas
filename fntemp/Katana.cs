using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DualPantoFramework;

public class Katana : MonoBehaviour
{
    public GameObject player;
    private Rigidbody playerRb;
    private UpperHandle upperHandle;
    // Start is called before the first frame update
   void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        
        Debug.LogError("Start fertig");

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        
    }

    void OnCollisionEnter(Collision collision)
    {
        
    }
}
