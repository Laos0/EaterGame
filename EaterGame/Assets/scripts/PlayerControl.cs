using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed;
    public Vector3 direction;
    public bool isMove;
    
    void Start()
    {
        speed = .2f;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            isMove = true;
            direction = Vector3.left;
        }else if (Input.GetKey(KeyCode.RightArrow))
        {
            isMove = true;
            direction = Vector3.right;
        }
        else
        {
            isMove = false;
        }
        if (isMove)
        {
            this.gameObject.transform.Translate(direction * speed);
        }
    }
}
