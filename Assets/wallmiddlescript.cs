using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class wallmiddlescript : MonoBehaviour
{
    public Logicscript logic;
    // Start is called before the first frame update
    void Start()
    {
        logic  = GameObject.FindGameObjectWithTag("logic").GetComponent<Logicscript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision){
        logic.addScore();
    }
}
