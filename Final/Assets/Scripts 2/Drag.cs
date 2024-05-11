using UnityEngine;
using UnityEngine.UI;

public class Drag : MonoBehaviour
{
    bool isBeingHeld; // Determines if object is being held
    Transform _transform; // Cache transform component

    void Start()
    {
        _transform = transform; // Cache transform component
    }

    void Update()
    {
        if (isBeingHeld)
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            _transform.localPosition = mousePos;
        }
    }

    void OnMouseDown()
    {
        isBeingHeld = true;
    }

    void OnMouseUp()
    {
        isBeingHeld = false;
    }
}
