using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject objetoFantasmaPrefab; // Prefab del objeto fantasma
    public Transform spawnPoint; // Punto de Spawn del objeto fantasma

    // Método para spawnear el objeto fantasma
    public void SpawnFantasma()
    {
        // Verificar si hay un prefab asignado
        if (objetoFantasmaPrefab != null)
        {
            // Instanciar el objeto fantasma en la posición del Spawn
            GameObject nuevoFantasma = Instantiate(objetoFantasmaPrefab, spawnPoint.position, Quaternion.identity);
            
            // Opcional: Establecer el objeto fantasma como hijo del spawnPoint
            nuevoFantasma.transform.parent = spawnPoint;
        }
        else
        {
            Debug.LogWarning("No se ha asignado un prefab de objeto fantasma al spawner.");
        }
    }
}