using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class LogicaPersona : MonoBehaviour
{

    public float velocidadMovimiento = 5.0f;
    public float velocidadRotacion = 200.0f;
    private Animator anim;
    public float x,y;

    public Rigidbody rigidbodyplayer;
    public float fuerzaSalto = 6f;
    public bool saltar;
    // Start is called before the first frame update
    void Start()
    {
        saltar = false;
        anim = GetComponent<Animator>();
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

    }


    public void EstoyCallendo()
    {
        anim.SetBool("ColisionSuelo",false);
        anim.SetBool("Salte",false);

    }
    
}
