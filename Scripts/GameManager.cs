using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
	public static float gold = 100;
    public static Vector2 position=new Vector2(-1,0);
	public static bool justBuy = false;
    public static Vector2 oldManPosition = new Vector2(4,0);
    public static Vector2 dinasourPosition = new Vector2(5,-4);
    public static Vector2 robotPosition = new Vector2(-2,-4);
    public static bool triggerDialogue = false;
    // Start is called before the first frame update
    public static int inHand = 0; 
    // 0 空手
    // 1 => item1 =>水
    // 2 => item2 =>剪刀
    // 3 => item3 =>汉堡
    // 4 => item4 =>风琴
 
    public static int choice = 0;
    public static int state = 0;
    public static int role = 0;
    //1 -> dinasour 2 -> oldMan
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
    void Start()
    {
        //initialize a winning story 
        GameObject.FindWithTag("Music").GetComponent<Music>().PlayMusic(); 
    }

    // Update is called once per frame
    void Update()
    {
    }

}
