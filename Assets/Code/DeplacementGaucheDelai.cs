using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeplacementGaucheDelai : MonoBehaviour
{
    // Déclarer variables publiques à définir dans inspector
    public float limiteGauche;
    public float limiteDroite; 
    public float delaiSecondes;
    public float vitesse; 

    // Variable distance de la scène
      float distance;

    // Alias pour Transform
    Transform transfo;

    void Start()
    { 
        // Initialiser les variables au début
        transfo = gameObject.transform;
        distance = limiteGauche - limiteDroite;
    }

    void Update()
    {   
        // Initier le mouvement après délai indiqué dans Inspector
        if (Time.time > delaiSecondes)
        {
            // Boucle de déplacement vers la gauche
            transfo.Translate(-vitesse * Time.deltaTime, 0f, 0f);
            if (transfo.position.x < limiteGauche)
            {
                // Si atteint limite gauche, repositionner à limite droite
                transfo.Translate(-distance, 0f, 0f);
            }
        }
    }
}
