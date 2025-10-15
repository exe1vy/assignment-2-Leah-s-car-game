
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NewMonoBehaviourScript1 : MonoBehaviour
{
    public float moveSpeed;
    public float maxSpeed;
    public float minSpeed;
    public TMP_Text messageText;

    void Update()
    {
        float Xmove = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float Zmove = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.position += new Vector3(Xmove, 0, Zmove);


        if (Input.GetKey(KeyCode.E))//The player accelerates.
        {
            SpeedingUpPlayer();
           
        }

        if (Input.GetKey(KeyCode.Q))//The Player slows down. 
        {
            SlowdingDownPlayer();
            
        }
        if (Input.GetKeyDown(KeyCode.Space))//The player stops.
        {
            StopThePlayer();
        }


    }
    public void StopThePlayer()
    {
        if (Input.GetKeyDown(KeyCode.Space))//The player stops.
        {
            moveSpeed = 0;
        }
    }
    public void SpeedingUpPlayer()
    {
        print("I am speeding up!");
        if (moveSpeed < maxSpeed)
        { 
                moveSpeed += 1f * Time.deltaTime;
            messageText.text = "More SPEED! \nYour current text kmph " + moveSpeed.ToString("N0");
            print("You have pressed E. I am speed! KACHOW" + moveSpeed);

        }
        
    }
    public void SlowdingDownPlayer()
    {
        print("Slowing down...");
        if (moveSpeed > minSpeed)
        {
            print("You have pressed Q. Slowing down..." + moveSpeed);
            moveSpeed -= 1f * Time.deltaTime;
            messageText.text = "Slowing down... \nYour current text kmph " + moveSpeed.ToString("N0");
        }
    }
}