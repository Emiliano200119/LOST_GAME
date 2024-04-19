using UnityEngine;
using UnityEngine.SceneManagement;

public class Next_Button : MonoBehaviour
{
    public void CargarEscena()
    {
        SceneManager.LoadScene("Lost_Escene");
    }
}