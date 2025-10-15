using UnityEngine;
using TMPro;
public class finishline : MonoBehaviour

{
    public TextMeshProUGUI lapcounter;
    public float lap = 0;
    public bool completeLap = false;
    //Creating the counter
    public void OnTriggerExit(Collider finishline)
    //Something happens when object A collides with object B
    {
        if (finishline.CompareTag("Player") && completeLap == false)
        //If a collision between A and B happens do this 
        //(what i have is if "player" hits "finishline" so and so what happens)
        {
            lap += 1;
            completeLap = true;
            //add +1 the lap (lapcounter)
            print("You finished lap " + lap);
            //Print to double check if working properly
            lapcounter.text = "You finished lap" + lap.ToString("");
        }
    }

    


}
    //PROBLEM: WHY IS IT PRINTING TWICE
