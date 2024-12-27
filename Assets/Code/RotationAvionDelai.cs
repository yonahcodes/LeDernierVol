using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class RotationAvionDelai : MonoBehaviour
{
    // Alias
    Transform transfo;

    // Variable publique degres de rotation
    public float degres = 25f;

    // Variable délai avant rotation
    float delaiSecondes = 40f;

    // Variable booléenne pour activer/désactiver rotation
    bool arretRotation = false;

    void Start()
    {
        // Initialiser alias
        transfo = gameObject.transform;
    }

    void Update()
    {
        // Si le délai est atteint et rotation inactive
        if (Time.time > delaiSecondes && !arretRotation)
        {
            // Initier la rotation
            transfo.Rotate(0, 0, degres * Time.deltaTime);

            // Si le temps dépasse 10 sec après le délai
            if (Time.time > delaiSecondes + 7f)
            {
                // Arreter la rotation
                arretRotation = true;
            }
        }
    }
}
