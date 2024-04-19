using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit_Button : MonoBehaviour
{
    private Vector3 posicionJugador; // Variable para almacenar la posición del jugador

    private void Start()
    {
        // Guardar la posición actual del jugador al inicio
        GuardarPosicionJugador();
    }

    private void Update()
    {
        // Verificar si se ha presionado una tecla específica (por ejemplo, la tecla "Escape")
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Restaurar la posición del jugador antes de cargar la escena "Lost_Escene"
            SceneManager.LoadScene("Lost_Escene");
        }
    }

    // Método para guardar la posición del jugador
    private void GuardarPosicionJugador()
    {
        // Obtener la posición actual del jugador
        posicionJugador = GameManager.RestaurarPosicionJugador();
    }

    // Método para restaurar la posición del jugador cuando se carga la escena "Lost_Escene"
    private void OnEnable()
    {
        // Restaurar la posición del jugador cuando el objeto se activa (es decir, cuando se carga la escena "Lost_Escene")
        transform.position = posicionJugador;
    }
}