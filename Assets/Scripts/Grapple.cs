using UnityEngine;
using System.Collections;

public class Grapple : MonoBehaviour
{
    public GameObject player;

    public GameObject grapplebox;
    public Rigidbody m_Rigidbody;

    public GameObject releaseBox;

    private CardboardMoving canWalking;
    private CardboardMoving canWalk;


    public GameObject ret;
    public bool grapple = false;
    public bool isGrounded = true;

    public Collider cap;

    public float speed;
    // Use this for initialization
    void Start()
    {
        m_Rigidbody = player.GetComponent<Rigidbody>();
        canWalking = player.GetComponent<CardboardMoving>();
        canWalk = player.GetComponent<CardboardMoving>();


    }
    // Update is called once per frame
    void Update()
    {
        RemainReleaseBox();

    }




    public void OnGazeClickMove()
    {

        RaycastHit hit;


        if ((grapple == false || isGrounded == false) && Physics.Raycast(ret.transform.position, ret.transform.forward, out hit, 10))
        {
            //  make code to remove or change ret with hit.distance
            if (hit.collider.transform.gameObject.tag == "grapplebox" && hit.distance <= 10)
            {
                Vector3 direction = (this.transform.position - player.transform.position).normalized;

                Debug.Log("hit");
                m_Rigidbody.AddForce(direction * speed);
                grapple = true;


            }

        }
    }

    public void OnGazeClickFreeze()
    {

        // freezes the position when to simulate being hooked to object

        // m_Rigidbody.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ |
        // RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
        RaycastHit hit;

        if (grapple == true && Physics.Raycast(ret.transform.position, ret.transform.forward, out hit, 10))
        {

            if (hit.collider.transform.gameObject.tag == "grapplebox" && hit.distance <= 10)
            {
                canWalking.isWalking = false;
                canWalk.enableWalking = false;
                m_Rigidbody.useGravity = false;
                isGrounded = false;
                m_Rigidbody.useGravity = false;
                
                StartCoroutine(DisablePhysics());

            }

        }
        // disable gravity
        /* Re-write grapple code. Click to Release if statement. if click on grapplebox release grapple and fall */



    }




    IEnumerator DisablePhysics()
    {

        cap.isTrigger = true;
        yield return new WaitForSeconds(.10f);

        cap.isTrigger = false;

    }
    public void GrappleClickRelease()

    {





        m_Rigidbody.useGravity = true;
        canWalking.isWalking = false;
        canWalk.enableWalking = true;
        grapple = false;
        isGrounded = true;
         m_Rigidbody.isKinematic = false;

      

    }



    public void RemainReleaseBox()
    {
        RaycastHit hit;



        if (grapple == true && isGrounded == false && Physics.Raycast(ret.transform.position, ret.transform.forward, out hit, 15))
        {

          

            if (hit.collider.transform.gameObject.tag == "releasebox" && hit.distance <= 3)
            {
                //releaseBox.SetActive(true);
                //grapplebox.SetActive(false);
                m_Rigidbody.isKinematic = false;

            }
            

        } 
    }




    public void RemainReleaseBox2()
    {
        RaycastHit hit;



        if (grapple == true && isGrounded == false && Physics.Raycast(ret.transform.position, ret.transform.forward, out hit, 15))
        {



            if (hit.collider.transform.gameObject.tag=="releasebox" && hit.distance >5)
            {
                releaseBox.SetActive(false);
                grapplebox.SetActive(true);
                m_Rigidbody.isKinematic = false;

            }


        }
    }

}



    