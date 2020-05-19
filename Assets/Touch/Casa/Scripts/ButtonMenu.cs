using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonMenu : MonoBehaviour
{
    public GameObject menuTexturas;
    public GameObject menuTexturasFachada;
    public GameObject menuTexturasPb;
    public GameObject menuTexturasPa;
    public GameObject menuTexturasRg;
    public GameObject menuTexturasSotano;
    public GameObject interfaz;

    public GameObject menu;   

    public void ActivarMenu()
    {
        menu.SetActive(true);
        interfaz.SetActive(false);
    }

    public void DesactivarMenu()
    {
        menu.SetActive(false);
        interfaz.SetActive(true);
    }

    public void RegresarAMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ActivarMenuTexturas()
    {
        menuTexturas.SetActive(true);
        interfaz.SetActive(false);
    }

    public void DesactivarMenuTexturas()
    {
        menuTexturas.SetActive(false);
        interfaz.SetActive(true);
    }

    public void ActivarMenuTexturasFachada()
    {
        menuTexturasFachada.SetActive(true);
        menuTexturas.SetActive(false);
    }

    public void DesactivarMenuTexturasFachada()
    {
        menuTexturasFachada.SetActive(false);
        menuTexturas.SetActive(true);
    }

    public void ActivarMenuTexturasPa()
    {
        menuTexturasPa.SetActive(true);
        menuTexturas.SetActive(false);
    }

    public void DesactivarMenuTexturasPa()
    {
        menuTexturasPa.SetActive(false);
        menuTexturas.SetActive(true);
    }

    public void ActivarMenuTexturasPb()
    {
        menuTexturasPb.SetActive(true);
        menuTexturas.SetActive(false);
    }

    public void DesactivarMenuTexturasPb()
    {
        menuTexturasPb.SetActive(false);
        menuTexturas.SetActive(true);
    }

    public void ActivarMenuTexturasRg()
    {
        menuTexturasRg.SetActive(true);
        menuTexturas.SetActive(false);
    }

    public void DesactivarMenuTexturasRg()
    {
        menuTexturasRg.SetActive(false);
        menuTexturas.SetActive(true);
    }

    public void ActivarMenuTexturasSotano()
    {
        menuTexturasSotano.SetActive(true);
        menuTexturas.SetActive(false);
    }

    public void DesactivarMenuTexturasSotano()
    {
        menuTexturasSotano.SetActive(false);
        menuTexturas.SetActive(true);
    }

    public void Salir()
    {
        Application.Quit();
    }
}
