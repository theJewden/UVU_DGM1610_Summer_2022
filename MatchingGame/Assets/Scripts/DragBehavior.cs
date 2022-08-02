using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DragBehavior : MonoBehaviour
{
    private Camera cameraObj;
    public bool draggable = true;
    public Vector3 dragPosition, offset;
    public UnityEvent startDragEvent;
    public UnityEvent endDragEvent;

    void Start()
    {
        cameraObj = Camera.main;
    }

    public IEnumerator OnMouseDown()
    {
        offset = transform.position - cameraObj.ScreenToWorldPoint(Input.mousePosition);
        draggable = true;
        startDragEvent.Invoke();
        yield return new WaitForFixedUpdate();

        while (draggable)
        {
            yield return new WaitForFixedUpdate();
            dragPosition = cameraObj.ScreenToWorldPoint(Input.mousePosition) + offset;
            transform.position = dragPosition;
        }
    }

    private void OnMouseUp()
    {
        draggable = false;
        endDragEvent.Invoke();
    }
}


