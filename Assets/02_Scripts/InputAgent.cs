using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InputAgent : MonoBehaviour
{
    [SerializeField] KeyCode LeftMove;
    [SerializeField] KeyCode RightMove;
    [SerializeField] KeyCode UpMove;

    public UnityEvent<KeyCode, KeyCode> playerInput;
    public UnityEvent<KeyCode> playerJump;

    private void Update()
    {
        PlayerInput();
        PlayerJmp();
    }

    private void PlayerInput()
    {
        playerInput?.Invoke(LeftMove, RightMove);
    }

    private void PlayerJmp()
    {
        playerJump?.Invoke(UpMove);
    }
}
