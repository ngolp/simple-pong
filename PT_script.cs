using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PT_script : MonoBehaviour
{

    public logicScript logic;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindWithTag("logic").GetComponent<logicScript>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        logic.updateScore(true);
    }
}
