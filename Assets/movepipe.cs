using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movepipe : MonoBehaviour
{
    public float wallspeed;
    public float kill = -40;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * wallspeed) * Time.deltaTime;
        if(transform.position.x < kill)
        {
            Destroy(gameObject);
            Debug.Log("pipe removed");
        }
    }
}
