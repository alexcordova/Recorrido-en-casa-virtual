using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonsMaterialsParedesPb : MonoBehaviour
{
    public Material mat1Pb;
    public Material mat2Pb;
    public Material mat3Pb;
    public Material mat4Pb;
    public Material mat5Pb;
    public Material mat6Pb;
    public Material mat7Pb;

    public Button b1Pb;
    public Button b2Pb;
    public Button b3Pb;
    public Button b4Pb;
    public Button b5Pb;
    public Button b6Pb;
    public Button b7Pb;

    void Update()
    {
        b1Pb.onClick.AddListener(Mat1Pb);
        b2Pb.onClick.AddListener(Mat2Pb);
        b3Pb.onClick.AddListener(Mat3Pb);
        b4Pb.onClick.AddListener(Mat4Pb);
        b5Pb.onClick.AddListener(Mat5Pb);
        b6Pb.onClick.AddListener(Mat6Pb);
        b7Pb.onClick.AddListener(Mat7Pb);
    }

    void Mat1Pb()
    {
        transform.GetComponent<MeshRenderer>().material = mat1Pb;
    }

    void Mat2Pb()
    {
        transform.GetComponent<MeshRenderer>().material = mat2Pb;
    }

    void Mat3Pb()
    {
        transform.GetComponent<MeshRenderer>().material = mat3Pb;
    }

    void Mat4Pb()
    {
        transform.GetComponent<MeshRenderer>().material = mat4Pb;
    }

    void Mat5Pb()
    {
        transform.GetComponent<MeshRenderer>().material = mat5Pb;
    }

    void Mat6Pb()
    {
        transform.GetComponent<MeshRenderer>().material = mat6Pb;
    }

    void Mat7Pb()
    {
        transform.GetComponent<MeshRenderer>().material = mat7Pb;
    }
}
