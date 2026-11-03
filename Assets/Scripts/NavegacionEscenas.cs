using UnityEngine;
using UnityEngine.SceneManagement;

public class NavegacionEscenas : MonoBehaviour
{
    public void IrAPrimeraVentana()
    {
        SceneManager.LoadScene("PrimeraVentana");
    }

    public void IrAPrimerEscenario()
    {
        SceneManager.LoadScene("PrimerEscenario");
    }

    public void IrAProgramacionBotones()
    {
        SceneManager.LoadScene("ProgramacionBotones");
    }

}