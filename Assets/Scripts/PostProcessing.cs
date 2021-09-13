using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.PostProcessing;

public class PostProcessing : MonoBehaviour
{
    [SerializeField] PostProcessProfile volume;

    Bloom b;
    [ColorUsage(true, true)]
    [SerializeField] private Color32 color;
    // Start is called before the first frame update
    void Start() 
    { 


        volume.TryGetSettings(out b);
        b.color.value = color;
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
