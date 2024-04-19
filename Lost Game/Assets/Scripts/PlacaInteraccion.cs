using UnityEngine;
using UnityEngine.SceneManagement;

public class PlacaInteraccion : MonoBehaviour
{
    public void OnMouseDown()
    {
        // Guarda la posición actual del jugador antes de cargar la escena de la interfaz
        PlayerPrefs.SetFloat("PlayerX", GameObject.FindGameObjectWithTag("Player").transform.position.x);
        PlayerPrefs.SetFloat("PlayerY", GameObject.FindGameObjectWithTag("Player").transform.position.y);
        PlayerPrefs.SetFloat("PlayerZ", GameObject.FindGameObjectWithTag("Player").transform.position.z);

        // Guarda la posición actual de la cámara principal antes de cargar la escena de la interfaz
        PlayerPrefs.SetFloat("CameraX", GameObject.FindGameObjectWithTag("MainCamera").transform.position.x);
        PlayerPrefs.SetFloat("CameraY", GameObject.FindGameObjectWithTag("MainCamera").transform.position.y);
        PlayerPrefs.SetFloat("CameraZ", GameObject.FindGameObjectWithTag("MainCamera").transform.position.z);

        PlayerPrefs.Save();

        // Carga la escena de la interfaz
        SceneManager.LoadScene("Interfaz_Placa");
    }
}
