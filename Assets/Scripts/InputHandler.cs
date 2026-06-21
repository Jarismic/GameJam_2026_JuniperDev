using UnityEngine;
using UnityEngine.InputSystem;

public class InputHandler : MonoBehaviour
{
    public void OnLaunch(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            PlayerEvents.OnLaunch?.Invoke();
        }
    }
}
