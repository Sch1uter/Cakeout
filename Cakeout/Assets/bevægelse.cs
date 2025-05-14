using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    public float speed = 20f; // Hvor hurtigt padlen bevæger sig
    public float Limit = 20f; // Hvor langt padlen må bevæge sig til siderne

    void Update()
    {
        float input = Input.GetAxis("Horizontal"); // Brug piletaster eller A/D
        Vector3 move = new Vector3(0f, 0f, 2 * -input * speed * Time.deltaTime);
        transform.position += move;

        // Begræns padlens position på x-aksen det gør vi ved hjælp af Clamp og vi lavede tideligere vores float "limit" som 
        float Begræns = Mathf.Clamp(transform.position.z, -Limit , Limit );
        transform.position = new Vector3(transform.position.x, transform.position.y, Begræns);
    }
}