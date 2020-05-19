using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonsMaterialSotano : MonoBehaviour
{
    public Material mat1S;
    public Material mat2S;
    public Material mat3S;
    public Material mat4S;
    public Material mat5S;
    public Material mat6S;
    public Material mat7S;

    public Button b1S;
    public Button b2S;
    public Button b3S;
    public Button b4S;
    public Button b5S;
    public Button b6S;
    public Button b7S;

    void Update()
    {
        b1S.onClick.AddListener(Mat1S);
        b2S.onClick.AddListener(Mat2S);
        b3S.onClick.AddListener(Mat3S);
        b4S.onClick.AddListener(Mat4S);
        b5S.onClick.AddListener(Mat5S);
        b6S.onClick.AddListener(Mat6S);
        b7S.onClick.AddListener(Mat7S);
    }

    void Mat1S()
    {
        transform.GetComponent<MeshRenderer>().material = mat1S;
    }

    void Mat2S()
    {
        transform.GetComponent<MeshRenderer>().material = mat2S;
    }

    void Mat3S()
    {
        transform.GetComponent<MeshRenderer>().material = mat3S;
    }

    void Mat4S()
    {
        transform.GetComponent<MeshRenderer>().material = mat4S;
    }

    void Mat5S()
    {
        transform.GetComponent<MeshRenderer>().material = mat5S;
    }

    void Mat6S()
    {
        transform.GetComponent<MeshRenderer>().material = mat6S;
    }

    void Mat7S()
    {
        transform.GetComponent<MeshRenderer>().material = mat7S;
    }
}
