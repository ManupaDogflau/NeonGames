using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    [SerializeField] private float velocity = 2f;
    // Start is called before the first frame update
    void Start()
    {
        ReplaceOnTop();
    }

    private void ReplaceOnTop()
    {
        gameObject.transform.position = new Vector3(Random.Range(-8f, 8f), 6);
        gameObject.transform.localScale = new Vector3( Random.Range(10, 50), 1);
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position -= new Vector3(0, Time.deltaTime * velocity* Mathf.Log(TimeManager.Timer+1));
        if (gameObject.transform.position.y <= -6)
        {
            ReplaceOnTop();
        }
    }
}
