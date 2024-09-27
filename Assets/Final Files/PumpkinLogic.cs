using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PumpkinLogic : MonoBehaviour
{
    private void Update()
    {
        //Rotate
        transform.Rotate(0, 30 * Time.deltaTime, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
    //On Trigger Enter
    //Tell GameManager for pumpkin collected
    //Destroy this game object
}
