using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using static GameManager;
public class GameOverEvent : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void restart(){
        GameManager.gold = 100;
        GameManager.position=new Vector2(-1,0);
        GameManager.justBuy = false;
        GameManager.oldManPosition = new Vector2(4,0);
        GameManager.dinasourPosition = new Vector2(5,-4);
        GameManager.robotPosition = new Vector2(-2,-4);
        GameManager.triggerDialogue = false;
        GameManager.inHand = 0; 
        GameManager.choice = 0;
        GameManager.state = 0;
        GameManager.role = 0;
    	SceneManager.LoadScene("MainMenu");

    }
     public void quit(){
     	Application.Quit();
     }
}
