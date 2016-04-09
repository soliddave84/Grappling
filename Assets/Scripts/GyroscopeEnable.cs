#if UNITY_EDITOR

using UnityEngine;
using System.Collections;

public class GyroscopeEnable : MonoBehaviour
{
    private Gyroscope gyro;
    //public Quaternion rotation;

    void Start()
    {


        // attitudeFix = new Quaternion(gyro.attitude.x*0, gyro.attitude.y*0, gyro.attitude.z*0, gyro.attitude.w);
      
        if (SystemInfo.supportsGyroscope)
        {
            gyro = Input.gyro;
            gyro.enabled = true;
        
        }
    }
    
    void Update()
    {

     // rotation = new Quaternion(0, Input.gyro.attitude.y, Input.gyro.attitude.z, -Input.gyro.attitude.w);

      //  transform.rotation =rotation;
    }



}

#endif