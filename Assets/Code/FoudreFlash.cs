using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoudreFlash : MonoBehaviour
{
    // Alias pour SpriteRenderer
    SpriteRenderer spriteR;

    // Initialiser le temps pour le prochain flash à zero au début
    float prochainFlash = 0f;

    // Variable publique pour intervalle flash (toutes les 3 sec)
    public float intervalleFlash = 1f;

    void Start()
    {
        // Définir alias
        spriteR = gameObject.GetComponent<SpriteRenderer>();

        // Activer foudre au début
        spriteR.enabled = true;

        // Définir le prochain flash après l'intervalle
        prochainFlash = Time.time + intervalleFlash;
    }

    void Update()
    {
        // Si le temps a dépassé le temps du prochain flash
        if (Time.time >= prochainFlash)
        {
            if (spriteR.enabled)
            {
                // Si activé -> désactiver
                spriteR.enabled = false;
            }
            else
            {
                // Sinon -> activer
                spriteR.enabled = true;
            }

            // Incrémenter temps pour prochain flash
            prochainFlash = Time.time + intervalleFlash;
        }
    }
}
