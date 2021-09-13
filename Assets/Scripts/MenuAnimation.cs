using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.PostProcessing;

public class MenuAnimation : MonoBehaviour
{
    [SerializeField] PostProcessProfile volume;

    Bloom b;
    [ColorUsage(true, true)]
    [SerializeField] private Color32[] color;
    [SerializeField] private GameObject[] invoke;
    private float t;
    private float t2;
    private int random;
    // Start is called before the first frame update
    void Start()
    {


        volume.TryGetSettings(out b);
       

    }

    // Update is called once per frame
    void Update()
    {
        
        t += Time.deltaTime;
        t2 += Time.deltaTime;
        if (t > 5)
        {
            random = Random.Range(0, 4);
            t -= 5;
         
            b.color.value = color[random];
        }
        if (t2 > 0.5f)
        {
            random = Random.Range(0, 4);
            t2 -= 0.5f;

            Instantiate(invoke[random], new Vector3(Random.Range(-7, 7), Random.Range(-4, 4)), Quaternion.identity);
        }
        
    }
}
