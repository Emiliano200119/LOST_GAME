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
        float PlayerX = PlayerPrefs.GetFloat("PlayerX");
        float PlayerY = PlayerPrefs.GetFloat("PlayerY");
        float PlayerZ = PlayerPrefs.GetFloat("PlayerZ");

        Vector3 PlayerPosition = new Vector3(PlayerX, PlayerY, PlayerZ);

        // Obtiene la posición guardada de la cámara principal desde PlayerPrefs
        float cameraX = PlayerPrefs.GetFloat("CameraX");
        float cameraY = PlayerPrefs.GetFloat("CameraY");
        float cameraZ = PlayerPrefs.GetFloat("CameraZ");

        Vector3 cameraPosition = new Vector3(cameraX, cameraY, cameraZ);

        // Carga la escena principal
        SceneManager.LoadScene("Lost_Escene");

        // Coloca al jugador en la posición guardada
        GameObject Player = GameObject.FindGameObjectWithTag("Player");
        Player.transform.position = PlayerPosition;

        // Coloca la cámara principal en la posición guardada
        GameObject mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
        mainCamera.transform.position = cameraPosition;
    }
}
