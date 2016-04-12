using UnityEngine;
using System.Collections;

public class CardboardMoving : MonoBehaviour {
  

    // set the Walk speed inspector
    public float walkSpeed;

    // will using the Cardboard head transform for player movement
    CardboardHead playerHead = null;

    


    Grapple grapplePass;


    // determines if the player is walking or not  
    [HideInInspector]
    public bool isWalking = false;

    //Enables or disable the ability to walk in the case you hit a solidobject
    [HideInInspector]
    public bool enableWalking = true;

    // Use this for initialization
    void Start() {

        playerHead = Camera.main.GetComponent<StereoController>().Head;
        
       

        
    }
	
	// Update is called once per frame
	void Update () {
        // if you press the magnet trigger and 



        if (Cardboard.SDK.Triggered && !isWalking)
        {
            isWalking = true;
            

        }

        else if  (Cardboard.SDK.Triggered && isWalking)
        {
            isWalking = false;
        }




        //calls the walking function in update
        Walking();
    }


    // the function bellow controls the walking.
    void Walking()
    {
        if (isWalking && enableWalking == true)
        {
            Vector3 walkDirection = new Vector3(playerHead.transform.forward.x, 0, playerHead.transform.forward.z).normalized * walkSpeed * Time.deltaTime;

            transform.Translate(walkDirection);

        }
    }

    

}

    


    

