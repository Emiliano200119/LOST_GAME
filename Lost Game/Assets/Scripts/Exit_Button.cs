using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit_Button : MonoBehaviour
{
    public void Salir()
    {
        // Obtener el índice de la escena anterior
        int indiceEscenaAnterior = SceneManager.GetActiveScene().buildIndex - 1;
        
        // Cargar la escena anterior si existe
        if (indiceEscenaAnterior >= 0)
        {
            SceneManager.LoadScene(indiceEscenaAnterior);
        }
        else
        {
            Debug.LogWarning("No hay una escena anterior disponible.");
        }
    }
}