using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ciel : MonoBehaviour
{
    // Delai avant de noircir le ciel
    public float delai = 27f;

    // Variable pour nouvelle couleur du ciel
    Color nouvelleCouleur;

    // Alias
    SpriteRenderer sR;

    // Contrôle du changement
    bool cielNoirci = false;

    // Temps de départ
    float tempsDebut;

    void Start()
    {
        // Initialiser alias
        sR = gameObject.GetComponent<SpriteRenderer>();

        // Stocker temps de départ
        tempsDebut = Time.time;
    }

    void Update()
    {
        // Temps écoulé depuis le début
        float chrono = Time.time - tempsDebut;

        // Si le délai est atteint
        if (chrono >= delai && !cielNoirci)
        {   
            // Assombrir le ciel
            nouvelleCouleur = new Color(121f/255f, 121f/255f, 121/255f);
            sR.color = nouvelleCouleur;

            // Mettre à jour booléenne
            cielNoirci = true;
        }   
    }
}
