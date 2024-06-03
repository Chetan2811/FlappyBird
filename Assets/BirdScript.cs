using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myrigid;
    public float flapstrength;
    public Logicscript logic;
    public bool birdAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<Logicscript>();        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && birdAlive)
        { 
            myrigid.velocity = Vector2.up * flapstrength;
            logic.nflaps();
            Debug.Log("flapped");
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.dead();
        birdAlive = false;
    }
}
