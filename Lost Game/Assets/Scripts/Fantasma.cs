using UnityEngine;

public class Fantasma : MonoBehaviour
{
    // Tiempo en segundos antes de desactivar el fantasma
    public float tiempoDesactivacion = 3f;

    private void Start()
    {
        // Desactivar el fantasma después de tiempoDesactivacion segundos
        Invoke("DesactivarFantasma", tiempoDesactivacion);
    }

    // Método para desactivar el fantasma
    private void DesactivarFantasma()
    {
        // Desactivar el GameObject del fantasma
        gameObject.SetActive(false);
    }
}