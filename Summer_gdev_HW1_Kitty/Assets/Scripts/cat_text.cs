using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cat_text : MonoBehaviour
{
    public Text text;
    public GameObject textbox;
    public static bool catbbb = false;

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
            if(movement_script.catFood == 0){
                text.text = "FOOD THX";
            }
            else if(movement_script.catFood == 1 || movement_script.catFood == 2){
                text.text = "HEY HUMAN I KNOW THERE ARE MORE GIMME ALL MY FOOD!!!!";
            }
            else if(movement_script.catFood == 3|| movement_script.catFood == 4){
                text.text = "YOU KNOW I NEED MORE FOOD DON'T YOU???";
            }
            else if(movement_script.catFood == 5){
                text.text = "HEY... WHY DON'T YOU ASK YOUR MOM FOR MORE FOOD?? THIS IS NOT ENOUGH FOR ME!";
                catbbb = true;
            }
            else{
                text.text = "CONGRATS YOU SURVIVED TODAY";
            }
            
            textbox.SetActive(true);
            movement_script.movementSpeed = 0.0f;
            StartCoroutine(catbb());
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