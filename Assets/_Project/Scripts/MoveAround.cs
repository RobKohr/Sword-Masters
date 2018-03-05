using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAround : MonoBehaviour {
    float speed = 1;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
       
        float horizontal = 0;
        float vertical = 0;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            horizontal = 1;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            horizontal = -1;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            vertical = 1;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            vertical = -1;
        }
        var move = new Vector3(vertical, 0, horizontal);
        transform.position += move * speed * Time.deltaTime;
        print(move);
    }
}
