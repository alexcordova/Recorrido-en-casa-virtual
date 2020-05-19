using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System.IO;

public class MenuTexturas : MonoBehaviour
{
    public GameObject menuTexturas;
    public float gazeTime = 2f;
    private bool gazedAt;
    private float timer;

    void Update()
    {
        if (gazedAt)
        {
            timer += Time.deltaTime;

            if (timer >= gazeTime)
            {
                ExecuteEvents.Execute(gameObject, new PointerEventData(EventSystem.current), ExecuteEvents.pointerDownHandler);
                gazedAt = false;
            }

        }
    }

    public void PointerEnter()
    {
        Debug.Log("Pointer Enter");
        gazedAt = true;

    }

    public void PointerExit()
    {
        Debug.Log("Pointer Exit");
        gazedAt = false;
        timer = 0f;
    }

    public void AbrirMenu()
    {
        menuTexturas.SetActive(true);
    }

    public void CerrarMenu()
    {
        menuTexturas.SetActive(false);
    }
}
