using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System.IO;


using System;

public class InstructiveInteraction : MonoBehaviour {

    public float gazeTime = 2f;

    private float timer;

    private bool gazedAt;

    private bool msj;

    //TcAdsClient cliente;

    public GameObject P1;
    public GameObject P2;
    public GameObject P3;
    public GameObject miraAqui;

    public GameObject PanelBienvenida;

    // Use this for initialization
    void Start()
    {
       
    }

    // Update is called once per frame
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
        Debug.Log("Pointer Down");
        P1.SetActive(false);
        P2.SetActive(true);
        StartCoroutine(Delay());
        StartCoroutine(Delay2());
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(6);
        P2.SetActive(false);
        miraAqui.transform.position = new Vector3(miraAqui.transform.position.x, miraAqui.transform.position.y, -1100);
        P3.SetActive(true);
    }

    IEnumerator Delay2()
    {
        yield return new WaitForSeconds(12);
        PanelBienvenida.SetActive(false);
    }
}