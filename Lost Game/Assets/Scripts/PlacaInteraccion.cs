using UnityEngine;
using UnityEngine.SceneManagement;

public class PlacaInteraccion : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("Interfaz_Placa");
    }
}