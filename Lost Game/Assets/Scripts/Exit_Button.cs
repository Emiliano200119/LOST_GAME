using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitButton : MonoBehaviour
{
    public void Salir()
    {
        // Cargar la escena "Lost_Escene"
        SceneManager.LoadScene("Lost_Escene");
    }
}