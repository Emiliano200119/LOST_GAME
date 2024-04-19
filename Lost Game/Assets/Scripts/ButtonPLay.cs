using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonPlay : MonoBehaviour
{
    public void CargarEscena()
    {
        SceneManager.LoadScene("Interfaz_Historia");
    }
}