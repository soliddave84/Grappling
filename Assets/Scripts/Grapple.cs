using UnityEngine;
using System.Collections;

public class Grapple : MonoBehaviour {
    public GameObject player;
    public GameObject grapplebox;
    Rigidbody m_Rigidbody;



    // Use this for initialization
    void Start()
    {
        m_Rigidbody = player.GetComponent<Rigidbody>();

    }
    // Update is called once per frame
    void Update () {
	
	}


    public void OnGazeClick()
    {

        player.transform.position = grapplebox.transform.position;
    }

    public void OnGazeExit()
    {
        
        
            m_Rigidbody.constraints = RigidbodyConstraints.None;
            m_Rigidbody.constraints = RigidbodyConstraints.FreezeRotation;
        
    }
}
