using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCInteract : Interactable
{


    Rigidbody rb;
    AudioSource deathsound;
    public Vector3 kickDirection;
    public float kickForce = 10f;
    void Awake() 
    {
        rb = GetComponent<Rigidbody>();
        deathsound = GetComponent<AudioSource>();
    }
    public override void Interact()
    {
        base.Interact();

            if(rb != null)
            {
                rb.freezeRotation= false;
                rb.constraints = RigidbodyConstraints.None;
                rb.AddForce(kickDirection * kickForce,ForceMode.Force);
                rb.AddTorque(kickDirection*kickForce,ForceMode.Force);
                deathsound.Play(0);
                Destroy(gameObject,2);
            }

    }
}
