using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonPlay : MonoBehaviour
{
    public void CargarSiguienteEscena()
    {
        SceneManager.LoadScene("Lost_Escene");
    }
}