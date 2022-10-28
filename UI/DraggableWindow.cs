using UnityEngine;
using UnityEngine.EventSystems;

public class DraggableWindow : MonoBehaviour,  IPointerEnterHandler, IPointerExitHandler
{
    public bool selected = false, inDrag = false;
    public GameObject highlight;
    Vector3 offsetToMouse;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && !inDrag)
            inDrag = true;
        else if (Input.GetMouseButtonUp(0) && inDrag)
            inDrag = false;

        if (inDrag)
            HandleMouseDrag();
    }

    void HandleMouseDrag()
    {
        transform.position = Input.mousePosition + 
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        selected = true;
        highlight.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        selected = false;
        highlight.SetActive(false);
    }
}
