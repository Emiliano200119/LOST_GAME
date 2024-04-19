using UnityEngine;

public class Fantasma : MonoBehaviour
{
    // Tiempo en segundos antes de desactivar el fantasma
    public float tiempoDesactivacion = 3f;
    private Transform player; // Referencia al transform del jugador

    private void Start()
    {
        // Encuentra el objeto del jugador y obtén su transform
        player = GameObject.FindGameObjectWithTag("Player").transform;

        // Desactivar el fantasma después de tiempoDesactivacion segundos
        Invoke("DesactivarFantasma", tiempoDesactivacion);
    }

    // Método para desactivar el fantasma
    private void DesactivarFantasma()
    {
        // Desactivar el GameObject del fantasma
        gameObject.SetActive(false);
    }

    void Update()
    {
        // Asegúrate de que player no sea null y aplica LookAt
        if (player != null)
        {
            transform.LookAt(player);
        }
    }
}
