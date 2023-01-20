using UnityEngine;
using UnityEngine.UI;

public class XROriginSwitcher : MonoBehaviour
{
    public GameObject currentXROrigin;
    public GameObject nextXROrigin;
    private Button button;

    private void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(SwitchXROrigin);
    }

    private void SwitchXROrigin()
    {
        currentXROrigin.SetActive(false);
        nextXROrigin.SetActive(true);

        GameObject temp = currentXROrigin;
        currentXROrigin = nextXROrigin;
        nextXROrigin = temp;
    }
}