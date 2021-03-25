using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static GameManager;

public class GameEvent : MonoBehaviour
{
	public Text CoinsTXT;
	public AudioSource Sound1;
	void Start(){
		// Sound1.Play();
	}
    public void loadShop(){
    	SceneManager.LoadScene("shopping");
    	
    }
    void Update(){
    	CoinsTXT.text=GameManager.gold.ToString();
    }
}
