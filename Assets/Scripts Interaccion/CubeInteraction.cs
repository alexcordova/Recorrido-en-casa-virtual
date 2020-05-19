using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System.IO;
//using TwinCAT.Ads;

using System;


public class CubeInteraction : MonoBehaviour
{

    public float gazeTime = 2f;

    private float timer;

    private bool gazedAt;

    private bool msj;

    public GameObject pasos;

    //TcAdsClient cliente;

   

    // Use this for initialization
    void Start()
    {
        /*
        cliente = new TcAdsClient();
        cliente.Connect("10.10.10.89.1.1",25001);

        AmsAddress serveraddress = new AmsAddress("10.10.10.190.1.1", 851);

        cliente.Connect(serveraddress.NetId, serveraddress.Port);

        if (cliente.IsConnected) Debug.Log("Conectado");
        */

     }

    // Update is called once per frame
    void Update()
    {

        if (gazedAt)
        {

            //Debug.Log ("gazedAt TRUE");
            timer += Time.deltaTime;
            //Debug.Log (timer);
            ///*
            Transform child = transform.GetChild(0);
            Vector3 newScale = new Vector3((timer / gazeTime) * 3, child.localScale.y, child.localScale.z);
            //Vector3 newPosition = new Vector3 (-0.5f+(timer/gazeTime)/2, child.localPosition.y, child.localPosition.z);

            child.localScale = newScale;
            //child.localPosition = newPosition;
            //*/

            if (timer >= gazeTime)
            {
                ExecuteEvents.Execute(gameObject, new PointerEventData(EventSystem.current), ExecuteEvents.pointerDownHandler);
                timer = 0f;
                gazedAt = false;
                child.localScale = new Vector3(0, 0.1f, 0.1f);
                //GetComponent<Collider>().enabled = false; //Desactiva la colision
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
        Transform child = transform.GetChild(0);
        child.localScale = new Vector3(0, 0.1f, 0.1f);
        timer = 0f;
    }

    public void PointerDown()
    {
        Debug.Log("Pointer Down");
        GameObject.Find("Player").GetComponent<MoveTowards>().target = this.gameObject.transform.GetChild(0);
        
        //msj = true;
        //cliente.WriteSymbol("MAIN.encender",msj,true); 
    }
}