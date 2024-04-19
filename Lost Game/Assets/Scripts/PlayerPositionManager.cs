using UnityEngine;

public class PlayerPositionManager : MonoBehaviour
{
    private Vector3 playerPosition; // Posición del jugador antes de entrar a la interfaz de la placa

    // Método para guardar la posición del jugador
    public void GuardarPosicionJugador(Vector3 posicion)
    {
        playerPosition = posicion;
    }

    // Método para restaurar la posición del jugador
    public Vector3 RestaurarPosicionJugador()
    {
        return playerPosition;
    }
}
