//This script is written for Unity 2020.1.12f, but will likely work with other versions
// It allows you to move a camera or game object that the script is attached to with W,A,S,D and the arrows on your keyboard. (Assuming you set it up to do this, it is completely customisable)
// This script also assumes that it is called "WASDCam", if you name the script anything else it won't work properly, although you can fix this by replacing WASDCam with your script name in the public class line of this script.


// You'll need to go into Settings > Project Settings > Input Manager in Unity and make sure that the Axes inputs are setup like this:
// "Horizontal" -> Negative button = a , Positive button = d, alt positive button = right, alt negative button = left
// "Flat Move" -> Negative button = s, Positive button = w, alt negative button = down, alt positive button = up

// Feel free to open an issue if you have any problems with this script.


using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;

public class WASDCam : MonoBehaviour
{
    [SerializeField] private float speed = 10.0f;


    private void Update()
    {
        float translation = Input.GetAxis("Horizontal") * speed;
        float horizMove = Input.GetAxis("Flat Move") * speed;

       translation *= Time.deltaTime;
       horizMove *= Time.deltaTime;


        transform.Translate(translation, 0, 0);
        transform.Translate(0,0,horizMove);
    }
}
