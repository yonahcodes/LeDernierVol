using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class FinDuJeu : MonoBehaviour
{
    // Delai au dernier affichage et fin
    float delaiAfficheFin = 57f;
    float delaiFin = 60f;

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

        // Si le délai pour la fin est atteint
        if (chrono >= delaiAfficheFin)
        {   
            // Afficher Fond
             sR.enabled = true;

            // Quitter l'application 
        }

        // Si temps écoulé -> Arrêter scène
        if (chrono >= delaiFin)
        {
#if UNITY_EDITOR
            // Stop Play mode in the editor
            UnityEditor.EditorApplication.isPlaying = false;
#else
            // Quit the application in a build
            Application.Quit();
#endif
        }
    }
}


