using UnityEngine;
using UnityEngine.EventSystems;

// Class = MonoBehaviour
// IPointerEnterHandler and IPointerExitHandler are interfaces.
public class UICursorCapture : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool cursorOverUI = false;

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Pointer Enter");
        cursorOverUI = true;
    }

    // Must implement for IPointerExitHandler
    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("Pointer Exit");
        cursorOverUI = false;
    }
}
