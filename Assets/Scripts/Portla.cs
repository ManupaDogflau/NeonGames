using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portla : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale=new Vector3(1+ Mathf.Sin(TimeManager.Timer*2)*0.2f, 1+ Mathf.Sin(TimeManager.Timer*2) * 0.2f);
    }
}
