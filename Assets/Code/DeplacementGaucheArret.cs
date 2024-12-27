using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeplacementGaucheArret : MonoBehaviour
{
    // Déclarer variables publiques à définir dans inspector
    public float limiteGauche;  
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
        // Déplacement à droite jusqu'à limite droite
        if (transfo.position.x > limiteGauche)
        {
            transfo.Translate(-vitesse * Time.deltaTime, 0f, 0f);
        }
    }
}
