using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlNave : MonoBehaviour
{
    BarraScript bar;
    Rigidbody rigidbody;
    Transform transform;
    AudioSource audiosource;

    public float maxValue = 100f;
    private const float coef = 5f;
    public float currentValue;
    

    void Start()
    {
        
        
        bar = GameObject.Find("BarraCombustible").GetComponent<BarraScript>();
        rigidbody = GetComponent<Rigidbody>();
        transform = GetComponent<Transform>();  
        audiosource = GetComponent<AudioSource>();
        currentValue = maxValue;
        
    }
    
    void Update()
    {            
        ProcesarInput();
            
    }
    
    private void OnCollisionEnter(Collision collision) 
    {
        switch(collision.gameObject.tag)
        {
            case "ColisionSegura":
                print("Colision segura...");
                // SceneManager.LoadScene("Nivel2");
                break;

            case "ColisionPeligrosa":
                // SceneManager.LoadScene("Nivel1");
                print("Colision peligrosa...");
                break;        

        }
    }
    
    private void ProcesarInput()
    {
        Propulsion();
        Rotacion();
    }

    private void Propulsion() {
        if (Input.GetKey(KeyCode.Space))
        {
            bar.decreaseValue(coef*Time.deltaTime);
            rigidbody.freezeRotation = true;
            rigidbody.AddRelativeForce(Vector3.up);
            
            if(!audiosource.isPlaying)
            {
                audiosource.Play();
            }            
        } 
        else 
        {
            audiosource.Stop();
        }
        rigidbody.freezeRotation = false;
    }

    private void Rotacion() {
        if(Input.GetKey(KeyCode.D))
        {                        
            var rotarDerecha = transform.rotation;
            rotarDerecha.z -= Time.deltaTime * 0.5f;
            transform.rotation = rotarDerecha;
            bar.setValue(20f);
        }
        else if(Input.GetKey(KeyCode.A))
        {                       
            var rotarIzquierda = transform.rotation;
            rotarIzquierda.z += Time.deltaTime * 0.5f;
            transform.rotation = rotarIzquierda;
        }
    }
}













