using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class Twins : MonoBehaviour
{
    public string PickUpName;
    private Rigidbody rb;
    private int count;
    public GameObject Text;

    // Start is called before the first frame update
    void Start()
    {
        // Assign the Rigidbody component to our private rb variable
        rb = GetComponent<Rigidbody>();
        // Set the count to zero 
        count = 0;
        Text=GameObject.FindGameObjectWithTag("Text");
        

    }



    void OnTriggerEnter(Collider other)
    {
       
        // ..and if the GameObject you intersect has the tag 'Pick Up' assigned to it..
        if (!other.gameObject.CompareTag(PickUpName))
        {
            other.gameObject.SetActive(false);

            // Add one to the score variable 'count'
            count = count + 1;          
        }

        if (count >= 3)
        { Text.SetActive(true); }
        else
        { Text.SetActive(false); }
        
    }
    
}
