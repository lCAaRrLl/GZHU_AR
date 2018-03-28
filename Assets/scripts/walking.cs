using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walking : MonoBehaviour {
    private int direction;
    private float p_start;//起始位置坐标(x)
    private float distance;
	// Use this for initialization
	void Start () {
        this.direction = 1;
        p_start = this.GetComponent<Transform>().position.x;
        distance = 2000f;
	}
	
	// Update is called once per frame
	void Update () {
        //移动区间为 x [-850 ,750]
        //向右移动，每秒位移为direction
        this.GetComponent<Transform>().position = this.GetComponent<Transform>().position + new Vector3(direction,0,0);
        //向右移动时的转身
        if(this.GetComponent<Transform>().position.x - p_start == distance)
        {
            this.GetComponent<Transform>().Rotate(Vector3.up * 180);
            direction = -1;
        }
        //向左移动时的转身
        if(this.GetComponent<Transform>().position.x -p_start == 0)
        {
            this.GetComponent<Transform>().Rotate(Vector3.up * 180);
            direction = 1;
        }
	}
}
