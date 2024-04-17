using UnityEngine;

public class ActivarFantasma : MonoBehaviour
{
    public Spawn spawner; // Referencia al script de spawner

    private void OnTriggerEnter(Collider other)
    {
        // Verificar si el jugador entró en la zona específica
        if (other.CompareTag("Player"))
        {
            // Llamar al método para spawnear el objeto fantasma
            spawner.SpawnFantasma();
        }
    }
}