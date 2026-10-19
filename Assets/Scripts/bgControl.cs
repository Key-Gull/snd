using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //背景的移动速度
    public float speed = 0.2f;
    //背景宽度
    public float width = 2.88f;
    //是否需要重置管道高度
    public bool resetPipeHeight = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //遍历背景
        foreach(Transform trans in transform)
        {
            //移动背景
            Vector3 v= trans.position;
            v.x-=speed * Time.deltaTime;
            //如果需要切换到新的位置
            if(v.x<-width)
            { 
                v.x+=width * 2;
                //重置高度
                if(resetPipeHeight)
                {
                    PipeControl pipe = trans.GetComponentInChildren<PipeControl>();
                    pipe.ResetHeight();
                }
            }
            trans.position = v;
        }
    }
}
