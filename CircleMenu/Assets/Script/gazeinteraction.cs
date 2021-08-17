using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class gazeinteraction : MonoBehaviour
{
    public float gazeTime = 2f;
    private float timer;
    private bool gazedAt;

    void Update()
    {
        if (gazedAt)
        {
            timer += Time.deltaTime;
            if(timer >= gazeTime)
            {
                //execute pointerdown handler
                ExecuteEvents.Execute(gameObject, new PointerEventData(EventSystem.current), ExecuteEvents.pointerDownHandler);
                timer = 0f;
            }
        }
        
    }

    public void PointerEnter()
    {
        gazedAt = true;
        Debug.Log("PointerEnter");
    }
    public void PointerExit()
    {
        gazedAt = false;
        Debug.Log("PointerExit");
    }
    public void PointerDown()
    {
       
        Debug.Log("PointerDown");
    }
}
