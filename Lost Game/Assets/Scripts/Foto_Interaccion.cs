using UnityEngine;
using UnityEngine.SceneManagement;
 class Foto_Interaccion : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("Interfaz_Foto");
    }
}