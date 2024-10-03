using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public GameObject gate;
    public GameObject restartGameScreen;
    public GameObject WinGameScreen;
    public int totalPumpkins;
    private int amountOfPumpkins;

    //reference to door
    //reference to amount of pumpkins
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Count game timer

    }

    public void PlayerCaught() //When entered the Ghost trigger
    {

    }

    public void PlayerEscaped() //When entered the escape trigger (outside graveyard)
    {

    }

    public void PickUpPumpkin()
    {
        amountOfPumpkins = amountOfPumpkins + 1;
        if(amountOfPumpkins == totalPumpkins)
        {
            //WIN GAME
            gate.SetActive(false);
        }

    }
    //Method PickUpPumpkin()
    //Increase Count
    //If == 3 then open door
}
