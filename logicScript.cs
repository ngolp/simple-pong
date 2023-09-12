using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logicScript : MonoBehaviour
{
    public Rigidbody2D playerRB;
    public Rigidbody2D opponentRB;
    public ballScript ballLogic;
    public Text oText;
    public Text pText;
    public int playerScore;
    public int opponentScore;

    // Start is called before the first frame update
    void Start()
    {
        ballLogic = GameObject.FindWithTag("ball").GetComponent<ballScript>();
        playerRB = GameObject.FindWithTag("player").GetComponent<Rigidbody2D>();
        opponentRB = GameObject.FindWithTag("opponent").GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void resetGame()
    {
        ballLogic.resetMovement();
        opponentRB.position = new Vector3(8.19f, 0);
        playerRB.position = new Vector3(-8.19f, 0);
    }

    public void updateScore(bool who)
    {
        if(who)
        {
            playerScore++;
            pText.text = playerScore.ToString();
        }
        else
        {
            opponentScore++;
            oText.text = opponentScore.ToString();
        }

        resetGame();
    }
}