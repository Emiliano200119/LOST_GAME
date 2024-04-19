using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit_Button : MonoBehaviour
{
    public void CargarSiguienteEscena()
    {
        SceneManager.LoadScene("Lost_Escene");
    }
}