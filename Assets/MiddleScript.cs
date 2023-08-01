using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MiddleScript : MonoBehaviour
{
    public LogicScript logic;
    public GameObject gameOverScreen;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3 && !logic.gameOverIsActive) {
            logic.addScore(1);
        }
    }
}
