using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    public float timeRemaining = 60f;
    public float timeUp = 0f;
    public Text timerBoard;

   
    void Update()
    {
        timeRemaining -= 1 * Time.deltaTime;            // -= 1 permet d'enlever 1 unit� � timeRemaining mais 1 unit� en seconde grace � Time.deltaTime

        timerBoard.text = timeRemaining.ToString("0"); //ToString permet de convertir le type "float" de timeRemaining et d'eviter une erreur de la console
                                                       //il permet �galement l'obligation de mettre un texte " " + ... au d�but, avant l'impl�mentation de timeRemaining
                                                       //("0") permet d'afficher seulement un nombre entier au lieu d'un nombre � virgule.

        

        if (timeRemaining <= timeUp)
        {
            timeRemaining = 0;                          // �vite au timer de passer en dessous de 0
        }

        if (timeRemaining <= 30)
        {
            timerBoard.color = Color.yellow;            // change la couleur du timer en jaune quand arriv� � 30 secondes
        }

        if (timeRemaining <= 10)
        {
            timerBoard.color = Color.red;               
        }

        

    }


}
