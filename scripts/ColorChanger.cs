using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    private Renderer rend;
    [SerializeField] private Color selectColor = Color.green;
    private Color originalColor;

    private void Awake()
    {
        rend = GetComponent<Renderer>();
        if (rend != null)
        {
            originalColor = rend.material.color;
        }
    }

    public void OnSelectEntered()
    {
        if (rend != null)
            rend.material.color = selectColor;
    }

    public void OnSelectExited()
    {
        if (rend != null)
            rend.material.color = originalColor;
    }
}