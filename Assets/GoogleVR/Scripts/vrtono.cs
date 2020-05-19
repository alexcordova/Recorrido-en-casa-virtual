using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vrtono : MonoBehaviour {
    private void Awake()
    {
       
            StartCoroutine(LoadDevice("cardboard", true));

            
     
    }
    void Start ()
    {
        
            StartCoroutine(LoadDevice("cardboard", true));

           
      
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    IEnumerator LoadDevice(string newDevice, bool enable)
    {
        UnityEngine.XR.XRSettings.LoadDeviceByName(newDevice);
        yield return null;
        UnityEngine.XR.XRSettings.enabled = true;
        Camera.main.ResetAspect();
    }
}
