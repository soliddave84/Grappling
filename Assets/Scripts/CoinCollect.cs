using UnityEngine;
using System.Collections;

public class CoinCollect : MonoBehaviour {


    
   
    public GameObject coin;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(-1, 0, 0);
    }


    public void OnTriggerEnter(Collider otherObject)
    {

        

        if (otherObject.gameObject.tag=="Player")
        {



           
            
                Destroy(coin.gameObject);
            
        }
       

    }
}
