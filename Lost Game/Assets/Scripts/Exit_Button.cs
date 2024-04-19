using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit_Button : MonoBehaviour
{
    private void Update()
    {
        // Verificar si se ha presionado una tecla específica (por ejemplo, la tecla "Escape")
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Cargar la escena "Lost_Escene"
            SceneManager.LoadScene("Lost_Escene");
        }
    }
}