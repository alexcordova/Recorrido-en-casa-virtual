using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsMain : MonoBehaviour
{
    public GameObject soundClick;

    public void Touch()
    {
        SceneManager.LoadScene("Prueba");
        soundClick.SetActive(true);
    }

    public void VR()
    {
        SceneManager.LoadScene("Prueba1");
        soundClick.SetActive(true);
    }

    public void Salir()
    {
        Application.Quit();
        soundClick.SetActive(true);
    }
}
