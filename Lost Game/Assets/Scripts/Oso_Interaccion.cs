using UnityEngine;
using UnityEngine.SceneManagement;

public class Oso_Interaccion : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("Oso_Interfaz");
    }
}