using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta : MonoBehaviour
{
    [SerializeField] private GameObject puerta;
    [SerializeField] private GameObject effect;
    [SerializeField] private AudioSource audios;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "ball")
        {
            Destroy (puerta);
            Destroy(gameObject);
        }
    }

    private void OnDestroy()
    {
        Instantiate(effect, transform.position, Quaternion.identity);
        audios.Play();
    }
}
