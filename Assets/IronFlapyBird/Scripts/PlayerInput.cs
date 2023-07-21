using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    public BirdScript bird;
    public void OnFlap(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            bird.Flap();
        }
        
    }
}
