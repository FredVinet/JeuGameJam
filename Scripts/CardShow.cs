using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardShow : MonoBehaviour {
    Card cardOne;

    // Start is called before the first frame update
    void Start() {
        cardOne = new Card();
        cardOne.Name = "Carte 1";
        cardOne.Description = "Fait +10 à la jauge Alimentation";
        cardOne.StatTarget = "Alimentation";
        cardOne.Stat = 10;
    }

    void Update(){
        Debug.Log ("Name: " + cardOne.Name + ", Description: " + cardOne.Description + ", Target: " + cardOne.StatTarget + ", Stat: " + cardOne.Stat);
    }
}