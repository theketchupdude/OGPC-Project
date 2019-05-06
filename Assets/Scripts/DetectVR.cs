using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class DetectVR : MonoBehaviour
{
    public static bool isOculus;

    public GameObject Oculus;

    public GameObject WindowsMR;


    // Use this for initialization
    void Start()
    {
        string detectedHMD = XRDevice.model;
        if (detectedHMD.ToLower().Contains("oculus"))
        {
            // HMD Must be a oculus headset
            isOculus = true;
            WindowsMR.SetActive(false);
            Oculus.SetActive(true);
        }
        else
        {
            // There isn't an easy way to check for WindowsMR so assume if it's not oculus its WindowsMR
            isOculus = false;
            WindowsMR.SetActive(true);
            Oculus.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
