using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambiarEscenario : MonoBehaviour
{


    public void CambiarEscenario(string nombre)
    {
        SceneManager.LoadScene(nombre);
    }

    public void Exit()
    {
        Application.Quit();
    }
}

