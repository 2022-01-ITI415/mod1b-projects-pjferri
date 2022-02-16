using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetalBall : MonoBehaviour
{
    public float timeBeforeDeath;
    public GameObject cannonParticles;

    void Start()
    {
        Invoke("DestroyThis", timeBeforeDeath);
    }

    private void DestroyThis()
    {
        Instantiate(cannonParticles, gameObject.transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            DestroyThis();
        }
    }

}
