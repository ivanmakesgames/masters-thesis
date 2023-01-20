using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SeatChanger : MonoBehaviour
{
    public XRRayInteractor rayInteractor; // assign this in the inspector
    public GameObject[] xrOrigins; // assign these in the inspector
    private int currentIndex = 0;

    private void Start()
    {
        // Disable all XR origins except for the first one
        for (int i = 1; i < xrOrigins.Length; i++)
            xrOrigins[i].SetActive(false);

        rayInteractor.onSelectEntered.AddListener(HandleSelectEnter);
    }

    private void HandleSelectEnter(XRBaseInteractable interactable)
    {
        // Check if the interactable is the button
        if (interactable == rayInteractor)
        {
            // Disable the current XR origin
            xrOrigins[currentIndex].SetActive(false);

            // Increment the current index
            currentIndex = (currentIndex + 1) % xrOrigins.Length;

            // Enable the next XR origin
            xrOrigins[currentIndex].SetActive(true);
        }
    }
}
