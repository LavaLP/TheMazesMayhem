using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sequence : MonoBehaviour
{
    //All public references.
    public GameObject Camera1;
    public GameObject Trigger;
    public GameObject SequenceCanvas;
    public GameObject CollectableCanvas;
    public GameObject Player;
    public GameObject TeleportPad;
    public GameObject Door2;
    public GameObject YellowBlocker;
    public GameObject RedBlocker;
    public GameObject BlueBlocker;
    public GameObject YellowText;
    public GameObject RedText;
    public GameObject BlueText;

    //This bool allows the script to turn on the camera privately when suggested.
    private bool cameraOn;
    //Private int helps keep track of buttons being pressed.
    private int count = 0;

    public void Update()
    {
        //If Private bool is true enter Sequence puzzle screen.
        if (cameraOn == true)
        {
            Camera1.SetActive(true);
            SequenceCanvas.SetActive(true);
            CollectableCanvas.SetActive(false);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            Player.transform.position = TeleportPad.transform.position;
        }
    }

    public void ClickButton(int buttonClicked)
    {
        //Yellow Button
        if (buttonClicked == 2)
        {
            //If correct button is pressed move to next button to be clicked.
            YellowBlocker.SetActive(true);
            YellowText.SetActive(true);
            count++;
        }
        //If incorrect button is pressed in sequence reset puzzle back to beginning state.
        else if (buttonClicked == 2 && count == 1)
        {
            YellowBlocker.SetActive(false);
            YellowText.SetActive(false);
            RedBlocker.SetActive(false);
            RedText.SetActive(false);
            count = 0;
        }
        else if (buttonClicked == 2 && count == 2)
        {
            YellowBlocker.SetActive(false);
            YellowText.SetActive(false);
            RedBlocker.SetActive(false);
            RedText.SetActive(false);
            BlueBlocker.SetActive(false);
            BlueText.SetActive(false);
            count = 0;
        }

        //Red Button
        if (buttonClicked == 3 && count == 1)
        {
            //If correct button is pressed move to next button to be clicked.
            RedBlocker.SetActive(true);
            RedText.SetActive(true);
            count++;
        }
        //If incorrect button is pressed in sequence reset puzzle back to beginning state.
        else if (buttonClicked == 3 && count == 2)
        {
            YellowBlocker.SetActive(false);
            YellowText.SetActive(false);
            RedBlocker.SetActive(false);
            RedText.SetActive(false);
            count = 0;
        }
        else if (buttonClicked == 3 && count == 3)
        {
            YellowBlocker.SetActive(false);
            YellowText.SetActive(false);
            RedBlocker.SetActive(false);
            RedText.SetActive(false);
            BlueBlocker.SetActive(false);
            BlueText.SetActive(false);
            count = 0;
        }

        //Blue Button
        if (buttonClicked == 4 && count == 2)
        {
            //If correct button is pressed move to next button to be clicked.
            BlueBlocker.SetActive(true);
            BlueText.SetActive(true);
            count++;
        }
        //If incorrect button is pressed in sequence reset puzzle back to beginning state.
        else if (buttonClicked == 4 && count == 1)
        {
            YellowBlocker.SetActive(false);
            YellowText.SetActive(false);
            RedBlocker.SetActive(false);
            RedText.SetActive(false);
            count = 0;
        }
        else if (buttonClicked == 4 && count == 3)
        {
            YellowBlocker.SetActive(false);
            YellowText.SetActive(false);
            RedBlocker.SetActive(false);
            RedText.SetActive(false);
            BlueBlocker.SetActive(false);
            BlueText.SetActive(false);
            count = 0;
        }

        //Green Button
        if (buttonClicked == 5 && count == 3)
        {
            //If button is clicked raise the number count.
            count++;
        }
        //If incorrect button is pressed in sequence reset puzzle back to beginning state.
        else if (buttonClicked == 5 && count == 1)
        {
            YellowBlocker.SetActive(false);
            YellowText.SetActive(false);
            RedBlocker.SetActive(false);
            RedText.SetActive(false);
            count = 0;
        }
        else if (buttonClicked == 5 && count == 2)
        {
            YellowBlocker.SetActive(false);
            YellowText.SetActive(false);
            RedBlocker.SetActive(false);
            RedText.SetActive(false);
            BlueBlocker.SetActive(false);
            BlueText.SetActive(false);
            count = 0;
        }

        //If number count is at 4 (Last number) let the player into the end zone and reset player back to defult (FPSCharacter).
        if (count == 4)
        {
            Door2.SetActive(false);
            Camera1.SetActive(false);
            SequenceCanvas.SetActive(false);
            Trigger.SetActive(false);
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }

    //If player enters the trigger turn Sequence camera (and sequence game/screen) on
    public void OnTriggerEnter(Collider other)
    {
        cameraOn = true;
    }

    //If player Exits the trigger the Sequence camera (and sequence game/screen) is turned off.
    public void OnTriggerExit(Collider other)
    {
        cameraOn = false;
    }
}
