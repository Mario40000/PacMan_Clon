using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float playerSpeed;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        
		
	}

    //Desde aqui controlamos el movimiento del jugador
    void FixedUpdate ()
    {
        //Variables para recoger la posicion de los ejes
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        //Actualizamos la posicion de la nave multiplicando movimiento por velocidad
        Vector3 movement = new Vector3((moveHorizontal) , 0.0f, moveVertical);
        GetComponent<Rigidbody>().velocity = movement * playerSpeed;
    }
}
