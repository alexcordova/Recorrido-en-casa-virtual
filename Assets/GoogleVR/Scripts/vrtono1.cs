using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vrtono1 : MonoBehaviour {
    private void Awake()
    {
       
            StartCoroutine(LoadDevice("cardboard", false));

            
     
    }
    void Start ()
    {
        
            StartCoroutine(LoadDevice("cardboard", false));

           
      
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    IEnumerator LoadDevice(string newDevice, bool enable)
    {
        UnityEngine.XR.XRSettings.LoadDeviceByName(newDevice);
        yield return null;
        UnityEngine.XR.XRSettings.enabled = false;
        Camera.main.ResetAspect();
    }
}
