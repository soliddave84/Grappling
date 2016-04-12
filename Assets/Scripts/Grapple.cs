using UnityEngine;
using System.Collections;

public class Grapple : MonoBehaviour {
    public GameObject player;
    public Transform grapplebox;
   private Rigidbody m_Rigidbody;

   public GameObject releaseBox;
   
    private CardboardMoving canWalking;
    private CardboardMoving canWalk;


    public GameObject ret;
    public bool grapple =false ;
    public float speed;
    // Use this for initialization
    void Start()
    {
        m_Rigidbody = player.GetComponent<Rigidbody>();
        canWalking = player.GetComponent<CardboardMoving>();
        canWalk = player.GetComponent<CardboardMoving>();

      
    }
    // Update is called once per frame
    void Update () {

        

    }




    public void OnGazeClickMove()
    {

        
      
        if (grapple == false && Physics.Raycast(ret.transform.forward, grapplebox.transform.position, 100))
        {

            

            Vector3 direction = (grapplebox.transform.position - player.transform.position).normalized;
            m_Rigidbody.AddForce(direction * speed);
            grapple = true;

            
            
        }
    }

    public void OnGazeClickFreeze()
    {

        // freezes the position when to simulate being hooked to object

        // m_Rigidbody.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ |
        // RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
        if (grapple == true && Physics.Raycast(ret.transform.forward, grapplebox.transform.position, 100))
        {
            canWalking.isWalking = false;
            canWalk.enableWalking = false;
            m_Rigidbody.useGravity = false;

        }
        // disable gravity
        /* Re-write grapple code. Click to Release if statement. if click on grapplebox release grapple and fall */

    }
    public void GrappleClickRelease()

    {

        if (grapple == true)
        {
            m_Rigidbody.useGravity = true;
            canWalking.isWalking = false;
            canWalk.enableWalking = true;
            grapple = false;

        }
    }
}
