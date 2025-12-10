using UnityEngine;
using UnityEngine.InputSystem;

public class QuitApp : MonoBehaviour
{

    void Update()
    {
        if (Keyboard.current.escapeKey.isPressed)
        {
            Debug.Log("bye");
            Application.Quit();
        }

    }
}
