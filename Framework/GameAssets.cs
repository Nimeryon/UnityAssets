using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameAssets : MonoBehaviour
{
    private static GameAssets _i;

    public static GameAssets Instance
    {
        get
        {
            if (_i == null) _i = (Instantiate(Resources.Load("GameAssets")) as GameObject).GetComponent<GameAssets>();
            return _i;
        }
    }

    // Variables

    // Input system
    /*[Header("Input")]
    InputController controls;
    public Vector2 movementInput;*/
    private void Awake()
    {
        /*controls = new InputController();
        controls.Player.Movement.performed += _ => movementInput = _.ReadValue<Vector2>();*/
    }

    /*private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }*/
}
