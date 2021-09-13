using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] private float velocity = 1f;
    private float x;
    private float y;
    [SerializeField] private float ymin=-4.6f;
    [SerializeField] private float ymax=4.8f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");
       
        transform.Rotate(new Vector3(0, 0,x* velocity*2 * Time.deltaTime));
        if(transform.position.y>ymin && y<0 ||transform.position.y<ymax && y > 0) 
        {
            transform.Translate(new Vector3(0, y * velocity / 6 * Time.deltaTime), 0);
        }
    }
}
       
