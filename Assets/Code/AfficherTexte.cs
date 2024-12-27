using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using TMPro; // Ajouter module pour TextMeshPro

public class AfficherTexte : MonoBehaviour
{
    // Delai et duree de l'affichage texte
    public float delaiAffichage = 0f; // 4 sec pour deuxième texte
    public float dureeAffichage = 3f; // même durée text 1 et 2

    // Variable publique échelle avec vecteur 2
    public Vector2 nouvelleEchelle = new Vector2(1f, 1f);
    // Variable publique couleur avec vecteur2 RGB
    public Color nouvelleCouleur = new Color(212f/255f, 15f/255f, 15f/255f);

    // Alias 
    TextMeshPro txtMP;
    Transform transfo;

    void Start()
    {
        // Initialiser alias
        transfo = gameObject.transform;
        txtMP = gameObject.GetComponent<TextMeshPro>();

        // Ne pas afficher texte au début    
        txtMP.enabled = false;

        // Redimensionner objet
        transfo.localScale = nouvelleEchelle;
        // Changer couleur
        txtMP.color = nouvelleCouleur;
    }

    void Update()
    {
        // Compteur de temps
        float chrono = Time.time;

        // Si le délai est atteint
        if (chrono >= delaiAffichage)
        {   
            // Afficher le texte
            txtMP.enabled = true;
        }
        // Si la durée est atteinte
        if (chrono >= delaiAffichage + dureeAffichage)
        {
            // Retirer le texte
            txtMP.enabled = false;
        }
    }
}
