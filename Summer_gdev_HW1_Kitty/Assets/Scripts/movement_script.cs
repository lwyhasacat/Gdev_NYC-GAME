using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement_script : MonoBehaviour
{
    public static float movementSpeed = 0.02f;
    public static float catFood = 0.0f;
    public Transform personTransform;
    private bool front = false;
    private bool back = false;
    private bool left = false;
    private bool right = false;

    Rigidbody2D playerRB;

    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(movementSpeed == 0){
            if(front){
                GetComponent<Animator>().Play("front_still_ani");
            }
            else if(back){
                GetComponent<Animator>().Play("back_still_ani");
            }
            else if(left){
                GetComponent<Animator>().Play("left_still_ani");
            }
            else if(right){
                GetComponent<Animator>().Play("right_still_ani");
            }
        }
        else if(Input.GetKey(KeyCode.LeftArrow)){
            transform.Translate(-1 * movementSpeed, 0, 0);
            GetComponent<Animator>().Play("left_walk_ani");
            right = false;
            left = true;
        }
        else if(Input.GetKey(KeyCode.RightArrow)){
            transform.Translate(movementSpeed, 0, 0);
            GetComponent<Animator>().Play("right_walk_ani");
            left = false;
            right = true;
        }
        /* else{
            if(left){
                GetComponent<Animator>().Play("left_still_ani");
            }
            if(right){
                GetComponent<Animator>().Play("right_still_ani");
            }
        } */
        else if(Input.GetKey(KeyCode.UpArrow)){
            transform.Translate(0, movementSpeed, 0);
            GetComponent<Animator>().Play("back_walk_ani");
            front = false;
            back = true;
        }
        else if(Input.GetKey(KeyCode.DownArrow)){
            transform.Translate(0, -1 * movementSpeed, 0);
            GetComponent<Animator>().Play("front_walk_ani");
            front = true;
            back = false;
        }
        else{
            if(front){
                GetComponent<Animator>().Play("front_still_ani");
            }
            if(back){
                GetComponent<Animator>().Play("back_still_ani");
            }
        }
    }
}