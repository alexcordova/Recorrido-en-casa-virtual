﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System.IO;

public class RegresarAlMenuFachadas : MonoBehaviour
{
    public float gazeTime = 2f;

    private float timer;

    private bool gazedAt;

    private bool msj;

    public GameObject panelMenuTexturas;
    public GameObject panelMenuFachadas;

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

    public void PointerDown()
    {
        panelMenuTexturas.SetActive(true);
        panelMenuFachadas.SetActive(false);
    }
}
