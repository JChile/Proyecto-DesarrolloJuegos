using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlNave : MonoBehaviour
{
    ControlBarra controlBarra;
    Rigidbody rigidBody;
    Transform transForm;
    AudioSource audiosource;
    Color colorBarra;
    GameObject explosion;
    ParticleSystem propulsion;
    
    private float velRot = 10f;
    private float velPro = 20f;      
    private float curValue = 20f;        

    void Start() 
    {            
        controlBarra = GameObject.Find("BarraCombustible").GetComponent<ControlBarra>();
        propulsion = GameObject.Find("Propulsion").GetComponent<ParticleSystem>();
        rigidBody = GetComponent<Rigidbody>();
        transForm = GetComponent<Transform>();  
        audiosource = GetComponent<AudioSource>();   
        explosion = GameObject.Find("Explosion");
    }
    
    void Update() 
    {            
        ProcesarInput();            
    }
    
    private void OnCollisionEnter(Collision collision) 
    {
        switch(collision.gameObject.tag) {
            case "ColisionSegura":
                print("Colision segura...");                
                break;

            case "ColisionPeligrosa":                                                                
                print("Colision peligrosa..."); 
                
                Instantiate(explosion, transform.position, transform.rotation);
                Destroy(gameObject);        
                                     
                break;        
        }
    }
    
    private void ProcesarInput() {
        Propulsion();
        Rotacion();
    }

    private void Propulsion() 
    {
        if (Input.GetKey(KeyCode.Space) && curValue > 0) 
        {
            rigidBody.AddRelativeForce(Vector3.up * velPro);            
                        
            controlBarra.decrementValue();
            curValue = controlBarra.getValue();           
            propulsion.Play();
                   
            if(!audiosource.isPlaying) 
            {
                audiosource.Play();
            }            
        } 
        else 
        {
            audiosource.Stop();
            propulsion.Stop();
        }        
       
    }

    private void Rotacion() {
        if(Input.GetKey(KeyCode.D)) 
        {                        
            rigidBody.AddRelativeTorque(Vector3.back * velRot, ForceMode.Acceleration);
        }
        else if(Input.GetKey(KeyCode.A)) 
        {                       
            rigidBody.AddRelativeTorque(Vector3.forward * velRot, ForceMode.Acceleration);
        }
    }
}













