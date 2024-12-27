using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeplacementGaucheDelaiArret : MonoBehaviour
{
    // Déclarer variables publiques à définir dans inspector
    public float limiteGauche;
    public float delaiSecondes;
    public float vitesse; 

    // Alias pour Transform
    Transform transfo;

    void Start()
    { 
        // Initialiser les variables au début
        transfo = gameObject.transform;
    }

    void Update()
    {   
        // Initier le mouvement après délai indiqué dans Inspector
        if (Time.time > delaiSecondes)
        {
            // Boucle de déplacement vers la gauche
            if (transfo.position.x > limiteGauche)
            {
                // Déplacement à gauche jusqu'à limite gauche
                transfo.Translate(-vitesse * Time.deltaTime, 0f, 0f);

            }
        }
    }
}
