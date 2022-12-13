using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obtacle_mode3 : MonoBehaviour
{
    Vector3 pos;
    int decision;
    int rotation_speed;
    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
        decision = Random.Range(1,2);
        rotation_speed = Random.Range(3,6);
    } 
    public AnimationCurve myCurve;
    // Update is called once per frame
    //adjust this to change speed
    float speed = 5f;
    //adjust this to change how high it goes
    float height = 0.5f;
    void Update()
    {
        // //get the objects current position and put it in a variable so we can access it later with less code
        // Vector3 pos = transform.position;
        // //calculate what the new Y position will be
        // float newY = Mathf.Sin(Time.time * speed);
        // //set the object's Y to the new calculated Y
        // transform.position = new Vector3(pos.x, pos.y+newY, pos.z) * height;
        // Vector3 pos = transform.position;
        backAndFord(pos.x,pos.y,pos.z);
    }
    void backAndFord(float x, float y, float z){
        // Random rnd = new Random();
        // int decision = rnd.Next(1,2);
        float newY;
        if(decision == 1){
            newY = Mathf.Sin(Time.time * speed);
        }else{
            newY = Mathf.Cos(Time.time * speed);
        }
        //get the objects current position and put it in a variable so we can access it later with less code
        // print("Debug Log"+"->"+pos.x+"->"+pos.y+"->"+pos.z);
        //calculate what the new Y position will be
        // float newY = Mathf.Sin(Time.time * speed);
        //set the object's Y to the new calculated Y
        transform.position = new Vector3(x, y+newY, z) * height;

        Vector3 eulers = this.transform.rotation.eulerAngles;
        float mySlider = Mathf.Sin(Time.time * rotation_speed);
        transform.rotation = Quaternion.Euler(mySlider * 90f, 0f, 0f);
    }
}
