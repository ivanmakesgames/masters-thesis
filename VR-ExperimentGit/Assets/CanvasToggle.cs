using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.XR;
using System.Linq;

public class CanvasToggle : MonoBehaviour
{
    public Canvas canvas;
    private InputAction selectButton;
    private UnityEngine.InputSystem.XR.XRController leftController;

    private void Awake()
    {
        canvas.gameObject.SetActive(false);    
    // get the left controller device by checking the layout and the name
        leftController = InputSystem.devices.OfType<UnityEngine.InputSystem.XR.XRController>().FirstOrDefault(x => x.name == "Touch Left");

        // create a new action that maps to the "select" button of the left controller
        selectButton = new InputAction(binding: "<XRController>/select", interactions: "Press");

        // listen to the "performed" event of the action
        selectButton.performed += ToggleCanvas;

        // enable the action
        selectButton.Enable();
    }

    private void OnDestroy()
    {
        // disable the action when the script is destroyed
        selectButton.Disable();
    }

    private void ToggleCanvas(InputAction.CallbackContext context)
    {
        // toggle the canvas active state
        canvas.gameObject.SetActive(!canvas.gameObject.activeSelf);

        if(canvas.gameObject.activeSelf)
            Debug.Log("Canvas appeared");
        else
            Debug.Log("Canvas disappeared");
    }
}