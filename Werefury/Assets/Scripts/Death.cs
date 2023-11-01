using UnityEngine;

public class ParticleSystemOnDestroy : MonoBehaviour
{
    public GameObject particlePrefab; 

    private void OnDestroy()
    {
        if (particlePrefab != null)
        {
            GameObject particleInstance = Instantiate(particlePrefab, transform.position, particlePrefab.transform.rotation);
            particleInstance.GetComponent<ParticleSystem>().Play();
        }
    }
}