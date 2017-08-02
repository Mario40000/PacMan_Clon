using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public Text scoreText;
    public Text hiScoreText;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        UpdateUI();
	}

    //Metodo para refrescar los marcadores
    void UpdateUI ()
    {
        scoreText.text = "SCORE " + StaticData.score;
        hiScoreText.text = "HIGH SCORE " + StaticData.hiScore;
    }
}
