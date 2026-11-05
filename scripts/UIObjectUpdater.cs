using UnityEngine;
using TMPro;

public class UIObjectUpdater : MonoBehaviour
{
    [SerializeField] private TMP_Text statusText;
    [SerializeField] private string heldMessage = "¡Objeto agarrado!";
    [SerializeField] private string releasedMessage = "Objeto soltado";

    public void OnGrabbed()
    {
        if (statusText != null)
            statusText.text = heldMessage;
    }

    public void OnReleased()
    {
        if (statusText != null)
            statusText.text = releasedMessage;
    }
}