using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Users;

// add this into built-in button you can create from menu: UI/Button
public class DeviceChange : MonoBehaviour
{
    public static bool keyBoard;
    void Awake()
    {
        PlayerInput input = FindObjectOfType<PlayerInput>();
        updateButtonImage(input.currentControlScheme);
    }

    void OnEnable()
    {
        InputUser.onChange += onInputDeviceChange;
    }

    void OnDisable()
    {
        InputUser.onChange -= onInputDeviceChange;
    }

    void onInputDeviceChange(InputUser user, InputUserChange change, InputDevice device)
    {
        if (change == InputUserChange.ControlSchemeChanged)
        {
            updateButtonImage(user.controlScheme.Value.name);
        }
    }

    void updateButtonImage(string schemeName)
    {
        // assuming you have only 2 schemes: keyboard and gamepad
        if (schemeName.Equals("Gamepad"))
        {
            keyBoard = false;
        }
        else
        {
            keyBoard = true;
        }
    }
}