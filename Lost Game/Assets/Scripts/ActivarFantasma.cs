using UnityEngine;

public class ActivarFantasma : MonoBehaviour
{
    public Spawn spawner;
    public AudioClip sonidoEntradaFantasma; 
    private bool zonaFantasmaActivada = false; 

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player") && !zonaFantasmaActivada)
        {
            if (sonidoEntradaFantasma != null)
            {
                AudioSource.PlayClipAtPoint(sonidoEntradaFantasma, transform.position);
            }

            spawner.SpawnFantasma();

            zonaFantasmaActivada = true;

            GetComponent<Collider>().enabled = false;
        }
    }
}