using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonsMaterialsRoofGarden : MonoBehaviour
{
    public Material mat1;
    public Material mat2;
    public Material mat3;
    public Material mat4;
    public Material mat5;
    public Material mat6;
    public Material mat7;

    public Button b1;
    public Button b2;
    public Button b3;
    public Button b4;
    public Button b5;
    public Button b6;
    public Button b7;

    void Update()
    {
        b1.onClick.AddListener(Mat1);
        b2.onClick.AddListener(Mat2);
        b3.onClick.AddListener(Mat3);
        b4.onClick.AddListener(Mat4);
        b5.onClick.AddListener(Mat5);
        b6.onClick.AddListener(Mat6);
        b7.onClick.AddListener(Mat7);
    }

    public void Mat1()
    {
        transform.GetComponent<MeshRenderer>().material = mat1;
    }

    public void Mat2()
    {
        transform.GetComponent<MeshRenderer>().material = mat2;
    }

    public void Mat3()
    {
        transform.GetComponent<MeshRenderer>().material = mat3;
    }

    public void Mat4()
    {
        transform.GetComponent<MeshRenderer>().material = mat4;
    }

    public void Mat5()
    {
        transform.GetComponent<MeshRenderer>().material = mat5;
    }

    public void Mat6()
    {
        transform.GetComponent<MeshRenderer>().material = mat6;
    }

    public void Mat7()
    {
        transform.GetComponent<MeshRenderer>().material = mat7;
    }
}
