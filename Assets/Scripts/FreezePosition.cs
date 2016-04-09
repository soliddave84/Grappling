using UnityEngine;
using System.Collections;

public class FreezePosition : MonoBehaviour
{
    public GameObject cardboardMain;
    Rigidbody m_Rigidbody;
    private CardboardMoving canWalking;
    private CardboardMoving canWalk;
    // Use this for initialization
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        canWalking = cardboardMain.GetComponent<CardboardMoving>();
        canWalk = cardboardMain.GetComponent<CardboardMoving>();
        m_Rigidbody.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider otherObject)
    {

        if (otherObject.gameObject.tag == "grapplebox")

        {

            m_Rigidbody.constraints = RigidbodyConstraints.FreezePositionY |
                RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
            canWalking.isWalking = false;
            canWalk.enableWalking = false;

        }
    }

    
}
