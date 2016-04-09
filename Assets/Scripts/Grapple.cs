using UnityEngine;
using System.Collections;

public class Grapple : MonoBehaviour {
    public GameObject player;
    public Transform grapplebox;
   private Rigidbody m_Rigidbody;
    public GameObject cardboardMain;
    private CardboardMoving canWalking;
    private CardboardMoving canWalk;

    private bool grapple;
    public float speed;
    // Use this for initialization
    void Start()
    {
        m_Rigidbody = player.GetComponent<Rigidbody>();
        canWalking = cardboardMain.GetComponent<CardboardMoving>();
        canWalk = cardboardMain.GetComponent<CardboardMoving>();

        grapple = false;
    }
    // Update is called once per frame
    void Update () {

       

        
    
    }




    public void OnGazeClickMove()
    {
        grapple = true;
        Vector3 direction = (grapplebox.transform.position - player.transform.position).normalized;
        m_Rigidbody.AddForce(direction * speed);
    }

    public void OnGazeClickFreeze()
    {

        // freezes the position when to simulate being hooked to object
     
      // m_Rigidbody.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ |
           // RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
        canWalking.isWalking = false;
        canWalk.enableWalking = false;

        /* Re-write grapple code. Click to Release if statement. if click on grapplebox release grapple and fall */

    }

    public void OnGazeExit()
    {
        
        /* re-write code. if statement if input click. if you click outside grapplebox you will fall*/
        m_Rigidbody.constraints = RigidbodyConstraints.None;
            m_Rigidbody.constraints = RigidbodyConstraints.FreezeRotation;
        
        canWalk.enableWalking = true;
        grapple = false;
    }
}
