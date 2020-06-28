using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLightActivation : MonoBehaviour
{

    private bool IsFlashOn = false;
    public AudioClip LightToggleFX;
    public Light fsLight;
    public AudioSource FLFX;


    // Start is called before the first frame update
    void Start()
    {
        FLFX = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        // turning flashlight on and off, by using "F"

        if (Input.GetKeyDown(KeyCode.F) && IsFlashOn == true)
        {
            DeactivateLight();
            IsFlashOn = false;
            FLFX.PlayOneShot(LightToggleFX);
        }

        else if (Input.GetKeyDown(KeyCode.F) && IsFlashOn == false)
        {
            ActivateLight();
            IsFlashOn = true;
            FLFX.PlayOneShot(LightToggleFX);
        }
    }


    // Light On and Off -- will see if I can condense the IsFlashOn and PlayOneShot in the same thing

    private void ActivateLight()
    {
        fsLight.enabled = true;
    }

    private void DeactivateLight()
    {
        fsLight.enabled = false;
    }
}
