#if UNITY_EDITOR


using UnityEngine;
using System.Collections;

public class AttitudeDebug : MonoBehaviour {
    private Gyroscope gyro;
    // Use this for initialization
    void Start()
    {
        if (SystemInfo.supportsGyroscope)
        {
            gyro = Input.gyro;
            gyro.enabled = true;

        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}


    void OnGUI()
    {
        GUILayout.Label("Gyroscope attitude : " + gyro.attitude);
        GUILayout.Label("Gyroscope gravity : " + gyro.gravity);
        GUILayout.Label("Gyroscope rotationRate : " + gyro.rotationRate);
        GUILayout.Label("Gyroscope rotationRateUnbiased : " + gyro.rotationRateUnbiased);
        GUILayout.Label("Gyroscope updateInterval : " + gyro.updateInterval);
        GUILayout.Label("Gyroscope userAcceleration : " + gyro.userAcceleration);
    }
}

    #endif
