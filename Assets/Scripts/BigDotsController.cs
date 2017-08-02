using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigDotsController : MonoBehaviour {

    //Variables
    public int score;

    private GameObject sound;

    void Start()
    {
        //Cargamos la variable con el sonido
        sound = GameObject.Find("PacManMunch");
    }

    //Detectamos si el player es quien colisiona con la
    //bola y la hacemos desaparecer
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            eatDot();
        }
    }
    //Metodo para destruir la bola
    void eatDot()
    {
        sound.GetComponent<AudioSource>().Play();
        StaticData.score += score;
        StaticData.power = true;
        Destroy(gameObject);
    }
}
