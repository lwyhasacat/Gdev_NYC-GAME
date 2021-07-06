using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class conv : MonoBehaviour
{
    public Text text;
    public GameObject textbox;
    public static bool mombb = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "person")
        {
            if(movement_script.catFood == 5 && cat_text.catbbb == true && mombb == false){
                text.text = "Mom our cat is starving he needs more food...";
                cat_text.catbbb = true;
                mombb = true;
                textbox.SetActive(true);
                movement_script.movementSpeed = 0.0f;
                StartCoroutine(catbb());
            }
            else if(movement_script.catFood == 5 && mombb == true){
                text.text = "Again? Ok, here you go!";
                movement_script.catFood ++;
                mombb = false;
                textbox.SetActive(true);
                movement_script.movementSpeed = 0.0f;
                StartCoroutine(catbb());
            }
        }
    }

    IEnumerator catbb()
    {
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(3.0f);
        text.text = "";

        movement_script.movementSpeed = 0.02f;
        textbox.SetActive(false);
    }
}
