using UnityEngine;
using UnityEngine.InputSystem;

public class WristUI : MonoBehaviour
{
    public InputActionAsset inputActions;

    private GameObject _wristUI;
    private InputAction _menu;

    private void Start()
    {
        _wristUI = gameObject;
        _wristUI.SetActive(false);
        _menu = inputActions.FindActionMap("XRI LeftHand").FindAction("Menu");
        _menu.Enable();
        _menu.performed += ToggleMenu;
    }

    private void OnDestroy()
    {
        _menu.performed -= ToggleMenu;
    }

    public void ToggleMenu(InputAction.CallbackContext context)
    {
        _wristUI.SetActive(!_wristUI.activeSelf);
    }
}