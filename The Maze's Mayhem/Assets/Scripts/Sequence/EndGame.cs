using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public GameObject EndTeleportPad;
    public GameObject Trigger2;
    public GameObject EndCamera;
    public GameObject EndCanvas;
    public GameObject Player;

    private bool EndCameraOn;

    public void Update()
    {
        if (EndCameraOn == true)
        {
            EndCamera.SetActive(true);
            EndCanvas.SetActive(true);
            Player.transform.position = EndTeleportPad.transform.position;
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        EndCameraOn = true;
    }

    //If player Exits the trigger the Sequence camera (and sequence game/screen) is turned off.
    public void OnTriggerExit(Collider other)
    {
        EndCameraOn = false;
    }
}
