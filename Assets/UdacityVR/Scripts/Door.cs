using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

    public GameObject leftDoor;
    public GameObject rightDoor;
    AudioSource audioSource;

    public bool locked = true;
    public bool opening = false;

    Quaternion leftDoorStartRotation;
    Quaternion leftDoorEndRotation;
    Quaternion rightDoorStartRotation;
    Quaternion rightDoorEndRotation;

    public float timer = 0f;
    public float rotationTime = 10f;

    void Start () {
        audioSource = GetComponent<AudioSource>();
        leftDoorStartRotation = leftDoor.transform.rotation;
        leftDoorEndRotation = leftDoorStartRotation * Quaternion.Euler(0f, 0f, 90f);
        rightDoorStartRotation = rightDoor.transform.rotation;
        rightDoorEndRotation = rightDoorStartRotation * Quaternion.Euler(0f, 0f, -90f);
    }


	void Update () {
        

        if (opening == true)
        {
            timer += Time.deltaTime;
                
            leftDoor.transform.rotation = Quaternion.Slerp(leftDoorStartRotation, leftDoorEndRotation, timer / rotationTime);
            rightDoor.transform.rotation = Quaternion.Slerp(rightDoorStartRotation, rightDoorEndRotation, timer / rotationTime);
            audioSource.Play();
        }

    }


	public void OnDoorClicked () {
		// Prints to the console when the method is called
		Debug.Log ("'Door.OnDoorClicked()' was called");


        if (locked == false)
        {
            opening = true;
            audioSource.Play();
        }

    }

    
	public void Unlock () {
		// Prints to the console when the method is called
		Debug.Log ("'Door.Unlock()' was called");

        // TODO: Unlock the door 
        // Unlock the door by changing the value of 'locked'
        locked = false;
	}
}
