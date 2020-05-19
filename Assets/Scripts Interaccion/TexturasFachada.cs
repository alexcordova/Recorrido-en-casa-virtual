using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System.IO;
using UnityEngine.UI;

public class TexturasFachada : MonoBehaviour
{
    public float gazeTime = 2f;

    private float timer;

    private bool gazedAt;

    private bool msj;

    public GameObject[] obj;
    public Material mat;

    public GameObject img1;
    public GameObject img2;
    public GameObject img3;
    public GameObject img4;
    public GameObject img5;
    public GameObject img6;
    public GameObject img7;

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
        img1.SetActive(true);
        img2.SetActive(false);
        img3.SetActive(false);
        img4.SetActive(false);
        img5.SetActive(false);
        img6.SetActive(false);
        img7.SetActive(false);
        for (int i = 0; i < 20; i++) {
            obj[i].transform.GetComponent<MeshRenderer>().material = mat;
        }
    }
}
