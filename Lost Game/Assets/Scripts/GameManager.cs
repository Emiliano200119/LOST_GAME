using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance; // Referencia estática al GameManager para hacerlo accesible desde otros scripts

    private Vector3 posicionJugador; // Variable para almacenar la posición del jugador

    private void Awake()
    {
        // Configurar GameManager como un Singleton para asegurar que solo haya una instancia en la escena
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Mantener el GameManager cuando se cargan nuevas escenas
        }
        else
        {
            Destroy(gameObject); // Destruir instancias adicionales del GameManager
        }
    }

    // Método para guardar la posición del jugador
    public void GuardarPosicionJugador(Vector3 posicion)
    {
        posicionJugador = posicion;
    }

    // Método para restaurar la posición del jugador
    public Vector3 RestaurarPosicionJugador()
    {
        return posicionJugador;
    }

    // Método estático para acceder al GameManager desde otros scripts
    public static GameManager ObtenerInstancia()
    {
        return instance;
    }
}