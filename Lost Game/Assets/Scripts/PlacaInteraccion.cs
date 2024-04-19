using UnityEngine;
using UnityEngine.SceneManagement;

public class PlacaInteraccion : MonoBehaviour
{
    private PlayerPositionManager positionManager; // Referencia al gestor de posición del jugador

    private void Start()
    {
        // Obtener una referencia al gestor de posición del jugador en tiempo de ejecución
        positionManager = FindObjectOfType<PlayerPositionManager>();
        if (positionManager == null)
        {
            positionManager.GuardarPosicionJugador(transform.position);

            Debug.LogError("No se encontró el PlayerPositionManager en la escena.");
        }
    }

    private void OnMouseDown()
    {
        SceneManager.LoadScene("Interfaz_Placa");
    }
    
}
