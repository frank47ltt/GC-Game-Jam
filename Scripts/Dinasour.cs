using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;
using static GameManager;
using UnityEngine.SceneManagement;

public class Dinasour : NPC
{
    protected override void Start(){
        animator = GetComponent<Animator>();
        transform.position=GameManager.dinasourPosition;
    }

	protected override void Update(){
		if(time==250 && canMove && !GameManager.triggerDialogue){
            updateDirection();
        }
        if(time>250 && canMove && !GameManager.triggerDialogue){
            move();
        }
        time++;
        if(time>400){
            time=0;
            animator.SetBool("dinasourIdle",true);
            animator.SetBool("dinasourWalk",false);
        }
	}
    public override void move(){
        // transform.Translate(direction*speed*Time.deltaTime);
        transform.Translate(direction*speed*Time.deltaTime);
        GameManager.dinasourPosition = transform.position;
    }
	protected override void updateDirection(){
        Random rnd = new Random();
        int num = rnd.Next(4);
        direction = options[num];
        animator.SetBool("dinasourIdle",false);
        animator.SetBool("dinasourWalk",true);
    }

    protected override void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.tag=="Player" && !GameManager.triggerDialogue){
            canMove = false;
            animator.SetBool("dinasourIdle",true);
            animator.SetBool("dinasourWalk",false);
            SceneManager.LoadScene("GamePop");
            GameManager.triggerDialogue = true;
            GameManager.role=1;
            Debug.Log("change role to 1 in dinasour");
        }
        
    }

}
