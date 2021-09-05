using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
using UnityEngine.Networking;

public class Player : NetworkBehaviour 
{
    void HandleMovement()
    {
        //if script is on local player
        if (isLocalPlayer)
        {
            float moveHorizontal = Input.GetAxis("Horizontal") * .1f;
            float moveVertical = Input.GetAxis("Vertical") * .1f;
            Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0);
            transform.position = transform.position + movement;
        }
    }

    void Update() 
    {
        HandleMovement();
    }
}


