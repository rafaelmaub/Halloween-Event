using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PumpkinLogic : MonoBehaviour
{

    GameManager gameManager;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        gameManager.totalPumpkins++;
    }

    private void Update()
    {
        //Rotate
        transform.Rotate(0, 30 * Time.deltaTime, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            gameManager.PickUpPumpkin();
            Destroy(gameObject);
        }
    }
    //On Trigger Enter
    //Tell GameManager for pumpkin collected
    //Destroy this game object
}
