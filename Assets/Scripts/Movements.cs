using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movements : MonoBehaviour
{
    public HUD _hud;
    public Rigidbody rb;

    //public int speedMoves = 0;
    //public int sideSpeedMoves = 0;
    
    public int speedMoves = 0;
    public int speedRotation = 0;

    public GameObject key;
    public GameObject finalWall;
    public bool caught = false;
    


    private void FixedUpdate()
    {
        
        float translation = Input.GetAxis("Vertical") * speedMoves * Time.deltaTime;
        transform.Translate(0,0, translation);  //défini une direction vers l'avant et l'arrière
        
        float rotation = Input.GetAxis("Horizontal") * speedRotation * Time.deltaTime;
        transform.Rotate(0,rotation, 0);  //défini une rotation via l'axe y et permet de pivoter à G/D
        
        /*float moves = Input.GetAxis("Vertical") * speedMoves * Time.deltaTime;
        transform.Translate(0,0,0);
        //rb.AddForce(0, 0, speedMoves);
        
        float sideMoves = Input.GetAxis("Horizontal") * sideSpeedMoves * Time.deltaTime;
        transform.Translate(0,0,0);*/

        //rb.AddForce(sideSpeedMoves, 0, 0);
        
    }
    
    private void OnTriggerEnter(Collider other) //obtention de la clé
    {
        if (other.gameObject.CompareTag("Key"))
        {
            other.gameObject.SetActive(false);
            _hud.keyScore++;
            caught = true;

        }

        if (other.gameObject.CompareTag("TriggerZone") && caught == true)
        {
            finalWall.transform.Translate(0f,3f,0f);
            caught = false;
        }

        if (other.gameObject.CompareTag("EndGame"))
        {
            SceneManager.LoadScene("End");
        }
        
        
    }
    
}



/*

public int speedMoves = 0;

float translation = Input.GetAxis("Vertical") * speedMoves * Time.deltaTime;
transform.Translate(0,0, translation);  //défini une direction vers l'avant et l'arrière


public int speedRotation = 0;

float rotation = Input.GetAxis("Horizontal") * speedRotation * Time.deltaTime;
transform.Rotate(0,rotation, 0);  //défini une rotation via l'axe y et permet de pivoter à G/D

public Animator myAnimator;
myAnimator.enabled = true;

*/