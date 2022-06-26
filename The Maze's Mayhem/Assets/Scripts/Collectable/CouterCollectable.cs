using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CouterCollectable : MonoBehaviour
{
    public Text CounterText;
    public Text Tutorial;
    public Text Start;
    public GameObject Door;
    public GameObject Door1;
    private int count = -1;
    private bool counter = true;

    public void Update()
    {
        //If bool is true activate if statement.
        if (counter == true)
        {
            //If E is pressed if statement activates.
            if (Input.GetKeyDown(KeyCode.E))
            {
                //Increase score whilst saying "you have collected".
                PlayerCounted();
                CounterText.text = count.ToString("You have collected " + count + "/9 items");
                //couter is set to false as the item and it's trigger deactivates so that when you enter the next trigger it counts.
                counter = false;
            }

            //If player gets 9/9 items message shows and opens 1 of the 2 exit doors and shows 2 messages to inform the Player.
            if (count > 8)
            {
                CounterText.text = count.ToString("You have collected all items. Half of the exit has been opened");
                Tutorial.text = count.ToString("Find the red door to escape this wretched maze");
                Door.SetActive(false);
            }

            //Make Tutorial text appear at beginning of the game.
            if (count == 0)
            {
                Tutorial.text = count.ToString("Press 'E' to collect items amongst the maze");
                Start.text = count.ToString(" ");
                Door1.SetActive(false);
            }

            //Make tutorial text disappear once 1st item is picked up.
            if (count == 1)
            {
                Tutorial.text = count.ToString(" ");
            }
        }
    }

    //Increase score by 1.
    public void PlayerCounted()
    {
        count++;
    }

    //Once trigger is entered "counter" is true.
    public void OnTriggerEnter(Collider other)
    {
        counter = true;
    }

    //One trigger is exited "counter" goes back to false.
    public void OnTriggerExit(Collider other)
    {
        counter = false;
    }
}

