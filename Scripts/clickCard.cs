using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EvenementsSouris : MonoBehaviour {
// Variable qui contiendra la référence au Renderer de l'objet

Renderer rend;
void Start () {
    rend = GetComponent<Renderer>();
}
// Le mesh devient rouge lorsque la souris entre sur l’objet.

// void OnMouseEnter () {
// rend.material.color = Color.red;
// }
// ...Le rouge tend vers cyan lorsque la souris est sur l’objet..
void OnMouseOver () {
        if(Input.GetKey(KeyCode.Mouse0)){
            rend.material.color = Color.red;
            rend.material.color += new Color(-0.1f, 0.1f, 0.1f) * Time.deltaTime;
    }
}
// Le mesh devient blanc lorsque la souris quitte l’objet.
void OnMouseExit () {
    rend.material.color = Color.white;
}


} 
