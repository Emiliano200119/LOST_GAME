using UnityEngine;
using UnityEngine.SceneManagement;

public class InterfazManager : MonoBehaviour
{
    private void Update()
    {
        // Verifica si se ha presionado la tecla "Space"
        if (Input.GetKeyDown(KeyCode.Space))
        {
            LoadOriginalScene();
        }
    }

    public void LoadOriginalScene()
    {
        // Obtiene la posición guardada del jugador desde PlayerPrefs
        float playerX = PlayerPrefs.GetFloat("PlayerX");
        float playerY = PlayerPrefs.GetFloat("PlayerY");
        float playerZ = PlayerPrefs.GetFloat("PlayerZ");

        Vector3 playerPosition = new Vector3(playerX, playerY, playerZ);

        // Obtiene la posición guardada de la cámara principal desde PlayerPrefs
        float cameraX = PlayerPrefs.GetFloat("CameraX");
        float cameraY = PlayerPrefs.GetFloat("CameraY");
        float cameraZ = PlayerPrefs.GetFloat("CameraZ");

        Vector3 cameraPosition = new Vector3(cameraX, cameraY, cameraZ);

        // Carga la escena principal
        SceneManager.LoadScene("Lost_Escene");

        // Coloca al jugador en la posición guardada
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        player.transform.position = playerPosition;

        // Coloca la cámara principal en la posición guardada
        GameObject mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
        mainCamera.transform.position = cameraPosition;
    }
}
