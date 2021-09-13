using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class REbote : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 direccion;
    Vector2 reflejado_aux;
    bool pega = false;
    [SerializeField] GameObject rebote;
    [SerializeField] AudioSource audios;
    [SerializeField] AudioSource breake;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //Damos una velocidad inicial
        rb.velocity = new Vector2(1, -1) * 8;
    }
    void FixedUpdate()
    {
        Debug.Log(rb.velocity);
        //Almacenamos la velocidad que lleva antes de la colision
        if (!pega)
        {
            direccion = rb.velocity;
        }
    }

        void OnCollisionEnter2D(Collision2D coll)
        {
        if (gameObject.transform.localScale.x > 1.5)
        {
            if (coll.gameObject.tag == "breakable")
            {
                Destroy(coll.gameObject);
                breake.Play();
            }

        }
            pega = true;

        if (direccion.magnitude <= Mathf.Sqrt(118))
        {
            direccion = new Vector2(1, -1) * 8;

        }
        //coll.contacts nos devuelve una matriz con los contactos de la colision
        Vector2 reflejado = Vector2.Reflect(direccion, coll.contacts[0].normal);

        Debug.Log(reflejado.magnitude);
            rb.velocity = reflejado;
        Instantiate(rebote, transform.position, Quaternion.identity);
        audios.Play();
        CamaraShake.Instance.ShakeCamera(1, 0.1f);
    }

        void OnCollisionExit2D(Collision2D coll)
        {
       
            pega = false;
        }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "ball")
        {
            if (collision.gameObject.GetComponent<SpriteRenderer>().color == gameObject.GetComponent<SpriteRenderer>().color)
            {
                Destroy(collision.gameObject);
                this.gameObject.transform.localScale *= 1.1f;
            }
            else
            {
                Destroy(collision.gameObject);
                this.gameObject.transform.localScale /= 1.1f;
            }
        }
    }

    private void OnBecameInvisible()
    {
        gameObject.transform.position = new Vector3(0, 0, 0);
        rb.velocity = new Vector2(1, -1) * 8;
    }
}
