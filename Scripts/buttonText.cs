using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class buttonText : MonoBehaviour
{

    public static bool food = false;
    public static bool scissors = false;
    public static bool water = false;
    public static bool organ = false;
    public Text Textfield;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void click_food(){
        food = true;
    }
    public void click_organ(){
        organ = true;
    }
    public void click_water(){
        water = true;
    }
    public void click_scissors(){
        scissors = true;
    }


    // Update is called once per frame
    public void Update()
    {
        if(food){
            Textfield.text = "买吃的";
        }

        if(water){
            Textfield.text = "有水喝";
        }
        
        /*
            
            if(inHand = 0) {
                if(碰到恐龙){

                    Text1: 你好呀，你是新来的吧，以后我们就是朋友啦，“一辈子”的那种。 
                    if(按了yes){
                        Text2: 你好，请多关照。
                        Text3: 你要好好注意哟，千万别去招惹管理员。
                    }else{
                        返回
                        碰到恐龙=0
                    }
                }else{
                    
                }
            }
            
        */

        
        /*
        剧情1：
Z: 你好呀，你是新来的吧，以后我们就是朋友啦，“一辈子”的那种。
A: 你好，请多关照。
Z: 你要好好注意哟，千万别去招惹管理员。

1、拿食物给Z
Z: 谢谢你呀，悄悄告诉你，老爷爷在这里很久了，或许他能帮助你一些
A: 好

2、拿水给Z
Z：谢谢你呀，悄悄告诉你，老爷爷喜欢风。
A：好
3、

1、老爷爷看到风琴（音乐）
老：多么熟悉的声音，已经很久很久没有听到过了。
A：啊，为什么
老：这个地方曾经救了我，真正的我却被永远的留在了那天。
A：那你知道怎么出去吗
老：不可能出去的，我被困了这么多年，除非管理员出故障，但是他那家伙是罕见的仿生机器人，是不可能出问题的。
A：机器人又怎么样，我一定会找到办法的。


1、
机器人：
拿到剪刀找到电线，加上水使机器人短路，逃出店铺

        */
    }
}
