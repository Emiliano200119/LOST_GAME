using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Next_Level : MonoBehaviour
{
   private void Update()
    {
        // Verificar si se ha presionado una tecla específica (por ejemplo, la tecla "Escape")
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Restaurar la posición del jugador antes de cargar la escena "Lost_Escene"
            SceneManager.LoadScene("Final_Interfaz");
        }
    }
}
