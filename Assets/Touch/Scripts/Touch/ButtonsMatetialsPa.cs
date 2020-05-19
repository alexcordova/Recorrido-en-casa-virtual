using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonsMatetialsPa : MonoBehaviour
{
    public Material mat1Pa;
    public Material mat2Pa;
    public Material mat3Pa;
    public Material mat4Pa;
    public Material mat5Pa;
    public Material mat6Pa;
    public Material mat7Pa;

    public Button b1Pa;
    public Button b2Pa;
    public Button b3Pa;
    public Button b4Pa;
    public Button b5Pa;
    public Button b6Pa;
    public Button b7Pa;

    void Update()
    {
        b1Pa.onClick.AddListener(Mat1Pa);
        b2Pa.onClick.AddListener(Mat2Pa);
        b3Pa.onClick.AddListener(Mat3Pa);
        b4Pa.onClick.AddListener(Mat4Pa);
        b5Pa.onClick.AddListener(Mat5Pa);
        b6Pa.onClick.AddListener(Mat6Pa);
        b7Pa.onClick.AddListener(Mat7Pa);
    }

    void Mat1Pa()
    {
        transform.GetComponent<MeshRenderer>().material = mat1Pa;
    }

    void Mat2Pa()
    {
        transform.GetComponent<MeshRenderer>().material = mat2Pa;
    }

    void Mat3Pa()
    {
        transform.GetComponent<MeshRenderer>().material = mat3Pa;
    }

    void Mat4Pa()
    {
        transform.GetComponent<MeshRenderer>().material = mat4Pa;
    }

    void Mat5Pa()
    {
        transform.GetComponent<MeshRenderer>().material = mat5Pa;
    }

    void Mat6Pa()
    {
        transform.GetComponent<MeshRenderer>().material = mat6Pa;
    }

    void Mat7Pa()
    {
        transform.GetComponent<MeshRenderer>().material = mat7Pa;
    }
}
