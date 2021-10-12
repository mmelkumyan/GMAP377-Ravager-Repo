using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleCore : MonoBehaviour
{
    public GameObject KrakenGrow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void growAnim()
    {
        GameObject krakenGrow = Instantiate(KrakenGrow, gameObject.transform.position, transform.rotation);
        krakenGrow.GetComponent<ParticleSystem>().Play();
    }
}
