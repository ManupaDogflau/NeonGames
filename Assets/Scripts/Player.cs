using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private GameObject death;
    [SerializeField]private float velocity = 1f;
    private float x;
    private float y;
    private Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");
        direction = new Vector3(x, y);
        gameObject.transform.position += direction * velocity * Time.deltaTime;

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player" || collision.gameObject.name == "Player(Clone)")
        {
            Instantiate(death, transform.position,Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
