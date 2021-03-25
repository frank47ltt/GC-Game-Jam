using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static GameManager;
using UnityEngine.UI;

public class GamePopEvent : MonoBehaviour
{
    public Text Textfield;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if(inHand==1){
        //     Textfield.text = "买水";
        // }else if(inHand==2){
        //     Textfield.text = "买剪刀";
        // }else if(inHand==3){
        //     Textfield.text = "买吃的";
        // }else if(inHand==4){
        //     Textfield.text = "买风琴";
        // }
        if(GameManager.role==1){
            if(GameManager.state == 0){
                Textfield.text = "恐龙宝宝：你好呀，你是新来的吧，以后我们就是朋友啦，“一辈子”的那种。"; 
                if(GameManager.choice == 1){
                    Textfield.text = " 我: 你好，请多关照. \n  恐龙宝宝: 你要好好注意哟，千万别去招惹管理员。"; 
                    GameManager.choice = 0;
                    GameManager.state = 1;
                }
                else{
                    GameManager.state = 0;
                }   
            }
            if(GameManager.state == 1 && GameManager.inHand == 3){
                Textfield.text = "恐龙宝宝：你是要给我吃的吗？";
                if(GameManager.choice == 1){
                    Textfield.text = "恐龙宝宝：谢谢你呀，悄悄告诉你，老爷爷在这里很久了，或许他能帮助你一些";
                    GameManager.choice = 0;
                    GameManager.state = 2;
                }
            }
            if(GameManager.state == 2 && GameManager.inHand == 1){
                Textfield.text = "恐龙宝宝：你是要给我水喝吗？";
                if(GameManager.choice == 1){
                    Textfield.text = "恐龙宝宝：谢谢你呀，悄悄告诉你，老爷爷喜欢风。";
                    GameManager.choice = 0;
                    GameManager.state = 3;
                }
            }
            if(GameManager.choice == 1 || GameManager.choice==3){
                SceneManager.LoadScene("Game");
                GameManager.choice = 0;
            }
        }
        if(GameManager.role==2){
            if(GameManager.state == 3 && GameManager.inHand == 4){
                Textfield.text = "老爷爷：哇，小伙子，你会吹风琴的嘛？";
                if(GameManager.choice == 1){
                    //Textfield.text = "多么熟悉的声音，已经很久很久没有听到过了。这个地方曾经救了我，真正的我却被永远的留在了那天。\n 是否留下来陪陪老爷爷？";
                    GameManager.choice = 0;
                    GameManager.state = 4;
                }
            }
            if(GameManager.state==4 && GameManager.inHand == 4){
                Textfield.text = "老爷爷：多么熟悉的声音，已经很久很久没有听到过了。这个地方曾经救了我，真正的我却被永远的留在了那天。\n 是否留下来陪陪老爷爷？";
                if(GameManager.choice == 1){
                    Textfield.text = "老爷爷：啊为什么。。。\n 这个地方曾经救了我，真正的我却被永远的留在了那天。\n那你知道怎么出去吗。。。？";
                    GameManager.choice = 0;
                    GameManager.state = 5;
                }
            }
            if(GameManager.state==5 && GameManager.inHand == 4){
                Textfield.text = "老爷爷：不可能出去的，我被困了这么多年，除非管理员出故障，但是他那家伙是罕见的仿生机器人，是不可能出问题的。\n机器人又怎么样，我一定会找到办法的";
                if(GameManager.choice == 1){
                    Textfield.text = "我：嗯！";
                    GameManager.choice = 0;
                    GameManager.state = 6;
                }
            }
            if(GameManager.choice == 1|| GameManager.choice==3){
                SceneManager.LoadScene("Game");
                GameManager.choice = 0;
            }
        }
        if(GameManager.role==3){
            if(GameManager.state==6 && GameManager.inHand == 2){
                Textfield.text = "恭喜你，你找到了管理员的死穴，你要切断他的电源吗？";
                if(GameManager.choice == 1){
                    Textfield.text = "但... 游戏还没结束哦，请继续寻找对的商品，给他致命一击";
                    GameManager.choice = 0;
                    GameManager.state = 7;
                }
                Debug.Log("after if" + GameManager.choice);
            }
            if(GameManager.state== 7 && GameManager.inHand == 1){
                Textfield.text = "哦哈哈，你找到了！\n 你要浇水至其短路吗";
                if(GameManager.choice == 1){
                    SceneManager.LoadScene("Victory");
                    GameManager.choice = 0;
                    GameManager.state = 7;
                }
            }else if (GameManager.state== 7){
                Textfield.text = "继续加油，小伙子";
            }
            Debug.Log(GameManager.state);

            // if(GameManager.state== 6 && GameManager.inHand == 2){
            //     Textfield.text = "恭喜你，你找到了管理员的死穴，你要切断他的电源吗？";
            //     Debug.Log("before enter");
            //     if(GameManager.choice == 1){
            //         Debug.Log("after");
            //         Textfield.text = "但... 游戏还没结束哦，请继续寻找对的商品，给他致命一击";
            //         GameManager.choice = 0;
            //         GameManager.state = 7;
            //     }
            // }

            Debug.Log("last" + GameManager.state);
            if(GameManager.choice == 1 || GameManager.choice==3){
                SceneManager.LoadScene("Game");
                GameManager.choice = 0;
            }
        }   
    }
    public void yes(){
        GameManager.choice = 1;
        Debug.Log("click");
    	// SceneManager.LoadScene("Game");
        // GameManager.triggerDialogue = false;
    }
    public void no(){
        GameManager.choice = 3;
    	// SceneManager.LoadScene("Game");
        // GameManager.triggerDialogue = false;
    }
}
