using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectable : MonoBehaviour
{
    private bool _canPickUpItem = false;
    public GameObject Player;
    public GameObject Item;

    private void Update()
    {
        //If bool is true activate if statement.
        if (_canPickUpItem == true)
        {
            //If E is pressed whilst "_canPickUpItem" is true disable "Item".
            if (Input.GetKeyDown(KeyCode.E))
            {
                Item.SetActive(false);
            }
        }
    }

    //Once trigger is entered "_canPickUpItem" is true.
    public void OnTriggerEnter(Collider other)
    {
        _canPickUpItem = true;
    }

    //One trigger is exited "_canPickUpItem" goes back to false
    private void OnTriggerExit(Collider other)
    {
        _canPickUpItem = false;
    }
}
