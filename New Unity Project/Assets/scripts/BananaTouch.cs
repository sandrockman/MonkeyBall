using UnityEngine;
using System.Collections;

public class BananaTouch : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        //Make sure you ALWAYS have a touch before trying to
        //compute touches
        if (Input.touchCount <= 0)
            return;

        foreach(Touch next in Input.touches)
        {
            if(next.phase == TouchPhase.Began)
            {
                //Moved - move the finger over screen
                //Stationary -- holding the finger
                //Ended - self explanatory
                //cancelled - error
                RaycastHit hit;
                Ray touchRay = Camera.main.ScreenPointToRay(next.position);
                
                if(Physics.Raycast(touchRay, out hit))
                {
                    //Grab the object and send a message, searching all scripts 
                    //on the object until it finds a "Touched" function
                    //Calls the "touched" function and erases any error messages if it doesn't find the function
                    hit.transform.gameObject.SendMessage("Touched", SendMessageOptions.DontRequireReceiver);
                }
            }
        }
	}
}
