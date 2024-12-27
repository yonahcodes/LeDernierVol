using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    // Delai et durée de l'explosion 
    float delaiAvantExplosion = 55f;
    float dureeExplosion = 1f;

    // Alias
    SpriteRenderer sR;

    void Start()
    {
        // Initialiser alias
        sR = gameObject.GetComponent<SpriteRenderer>();

        // Ne pas afficher explosion au début    
        sR.enabled = false;
    }

    void Update()
    {
        // Compteur de temps
        float chrono = Time.time;

        // Si le délai est atteint
        if (chrono >= delaiAvantExplosion)
        {   
            // Activer explosion
             sR.enabled = true;
        }
        // Si la durée est atteinte
        if (chrono >= delaiAvantExplosion + dureeExplosion)
        {
            // Terminer explosion
            sR.enabled = false;
        }
    }
}

