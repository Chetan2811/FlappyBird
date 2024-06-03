using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class wallspawner : MonoBehaviour
{
    public GameObject wall;
    public float spawnrate = 2;
    private float timer = 0;
    public float heightoffset = 10;
    public float sizeofwall = 1;
    public float minscale = 0.5f;
    public float maxscale = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(wall, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if(timer<spawnrate){
            timer += Time.deltaTime;
        }else{
            spawnpipe();
            timer = 0;
            Debug.Log("wall created");
        }
    }
    void spawnpipe()
    {
        float btm = transform.position.y - heightoffset;
        float tp = transform.position.y + heightoffset;
        GameObject perfectwalls = Instantiate(wall, new Vector3(transform.position.x, Random.Range(btm, tp), transform.position.z ), transform.rotation);
        
        float scaler = Random.Range(minscale, maxscale);
        perfectwalls.transform.localScale = new Vector3(scaler , scaler, transform.position.z);
    }
}
