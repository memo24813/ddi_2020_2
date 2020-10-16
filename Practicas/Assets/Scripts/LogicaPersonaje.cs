using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaPersonaje : MonoBehaviour
{

    public float velocidadMovimiento = 5.0f;
    public float velocidadRotacion = 200.0f;
    private Animator anim;
    public float x,y;

    public Rigidbody rigidbodyplayer;
    public float fuerzaSalto = 6f;
    public bool saltar,baile,kick;

    public AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        saltar = false;
        baile = false;
        kick = false;
        anim = GetComponent<Animator>();
        source = GetComponent<AudioSource>();
        rigidbodyplayer = GetComponent<Rigidbody>();
    }

    void FixedUpdate() {
        transform.Rotate(0,x*Time.deltaTime*velocidadRotacion,0);
        transform.Translate(0,0,y*Time.deltaTime*velocidadMovimiento); 
    }
    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");


        anim.SetFloat("VelX",x);
        anim.SetFloat("VelY",y);

        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            velocidadMovimiento= 10.0f;
        }
        if(Input.GetKeyUp(KeyCode.LeftShift))
        {
            velocidadMovimiento= 5.0f;
        }

        if(saltar)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                anim.SetBool("Salte",true);
                rigidbodyplayer.AddForce(new Vector3(0,fuerzaSalto,0),ForceMode.Impulse);
            }
            anim.SetBool("ColisionSuelo",true);
        }
        else
        {
            EstoyCallendo();
        }

        if(!baile)
        {
            if(Input.GetKeyDown("g"))
            {
                anim.SetBool("Baile",true);
                baile=true;    
                source.Play(0);
            }
        }
        else
        {
            if(Input.GetKeyDown("g") || Input.GetKeyDown("w") || Input.GetKeyDown("s") || Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.K))
            {
                anim.SetBool("Baile",false);
                baile=false;
                source.Pause();
            }
        }
        
        if(!kick)
        {
            if(Input.GetKeyDown(KeyCode.K))
            {
                anim.SetBool("Kick",true);
                kick = true;
                // Debug.Log(anim.GetCurrentAnimatorStateInfo(0).IsName("Kick"));
            }
        }    
        else if(anim.GetCurrentAnimatorStateInfo(0).IsName("Kick"))
        {
            kick = false;
            anim.SetBool("Kick",false);
        }

    }


    public void EstoyCallendo()
    {
        anim.SetBool("ColisionSuelo",false);
        anim.SetBool("Salte",false);

    }
}
