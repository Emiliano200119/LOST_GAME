using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Método para guardar la posición del jugador
    public static void GuardarPosicionJugador(Vector3 posicion)
    {
        // Guardar la posición del jugador en PlayerPrefs
        PlayerPrefs.SetFloat("PosicionX", posicion.x);
        PlayerPrefs.SetFloat("PosicionY", posicion.y);
        PlayerPrefs.SetFloat("PosicionZ", posicion.z);
        PlayerPrefs.Save(); // Guardar los cambios en PlayerPrefs
    }

    // Método para restaurar la posición del jugador
    public static Vector3 RestaurarPosicionJugador()
    {
        // Obtener la posición del jugador de PlayerPrefs
        float x = PlayerPrefs.GetFloat("PosicionX", 0f);
        float y = PlayerPrefs.GetFloat("PosicionY", 0f);
        float z = PlayerPrefs.GetFloat("PosicionZ", 0f);
        
        // Crear un vector con la posición guardada
        Vector3 posicionGuardada = new Vector3(x, y, z);
        
        return posicionGuardada;
    }
}
