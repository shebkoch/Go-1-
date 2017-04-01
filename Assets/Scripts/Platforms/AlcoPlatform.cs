using UnityEngine;
using System.Collections;
public class AlcoPlatform : MonoBehaviour {

    public ParticleSystem particle;
    public float particleDuration;
    
    void Start () {
	
	}
	void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.transform.tag == "Player")
        {
            particle = Instantiate(particle,collision.gameObject.transform);
            particle.transform.position = gameObject.transform.position;
            particle.Play();
			StartCoroutine(ParticlePause());
		}
    }
	IEnumerator ParticlePause()
    {
        particle.Stop();
		yield return new WaitForSeconds(particleDuration);

	}
}
