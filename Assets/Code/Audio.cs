using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Musique : MonoBehaviour
{
    [Header("---- Sources Audio ----")]
    public AudioSource musique;
    public AudioSource sons;

    [Header("---- Clips Audio ------")]
    public AudioClip MusiqueJoyeuse;
    public AudioClip MusiqueSombre;
    public AudioClip Oiseaux;
    public AudioClip Tonnerre;
    public AudioClip Explosion;

    // Variables de contrôle de temps
    float changeMusique = 25f;
    float explosion = 55f;
    float chrono = 0f;

    // Variable vitesse de diminution volume
    float baisseSon = 0.5f;

    // Variable booléenne pour contrôler le changement
    bool musiqueChangee = false;
    bool explosionJoue = false;
    bool tonnerreJoue = false;


    void Start()
    {
        // Volumes initiaux
        musique.volume = 1f;
        sons.volume = 1f;

        // Jouer musique joyeuse
        musique.clip = MusiqueJoyeuse;
        musique.Play();
        // Jouer son oiseaux
        sons.clip = Oiseaux;
        sons.Play();
    }

    void Update()
    {
        // Mettre à jour temps écoulé
        chrono += Time.deltaTime;

        // Si c'est le temps de changer et que
        // la musique n'a pas encore changé
        if (chrono >= changeMusique && !musiqueChangee)
        {
            // Diminuer graduellement volume 
            // musique joyeuse et sons oiseaux
            musique.volume -= baisseSon * Time.deltaTime;
            sons.volume -= baisseSon * Time.deltaTime;

            // Si le volume est à 0
            if (musique.volume <= 0 && sons.volume <= 0)
            {
                // Jouer musique sombre, remonter volume
                musique.clip = MusiqueSombre;
                musique.pitch = 1.1f;
                musique.Play();
                musique.volume = 1f;

                // Mettre à jour booléenne
                musiqueChangee = true;
            }
        }

        // Si 4 secondes après que la musique change
        if (chrono >= changeMusique + 4f && musiqueChangee && !tonnerreJoue)
        {
            // Arrêter sons précédents
            sons.Stop();

            // Jouer tonnerre
            sons.clip = Tonnerre;
            sons.volume = 1f;
            sons.Play();

            // Mettre  à jour booléenne
            tonnerreJoue = true;
        }

        // Si le temps de l'explosion est arrivé
        if (chrono >= explosion && !explosionJoue)
        {
            // Arrêter tout son et musique
            musique.Stop();
            sons.Stop();

            // Jouer son explosion
            sons.clip = Explosion;
            sons.Play();

            // Mettre à jour booléenne
            explosionJoue = true;
        }
    }
}
