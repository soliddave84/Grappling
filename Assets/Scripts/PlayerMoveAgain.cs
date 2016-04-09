using UnityEngine;
using System.Collections;

public class PlayerMoveAgain : MonoBehaviour {

   public GameObject cardboardMain;

    private CardboardMoving canWalking;
    private CardboardMoving canWalk;



    // Use this for initialization
    void Start () {

    canWalking = cardboardMain.GetComponent<CardboardMoving>();
        canWalk = cardboardMain.GetComponent<CardboardMoving>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerStay(Collider otherObject)
    {

        if (otherObject.gameObject.tag == "solidobject")
        {
           
            canWalking.isWalking = false;
            canWalk.enableWalking = false;
        }

        else if (otherObject.gameObject.tag == "solidobject" && Cardboard.SDK.Triggered)
        {

            canWalking.isWalking = false;
            canWalk.enableWalking = false;
        }
    }
    void OnTriggerExit(Collider otherObject)
    {
        if (otherObject.gameObject.tag == "solidobject")
        {


            canWalk.enableWalking = true;
        }

        else if (otherObject.gameObject.tag == "solidobject" && Cardboard.SDK.Triggered)
        {

            canWalking.isWalking =true;
            canWalk.enableWalking =true ;
        }
    }
}
