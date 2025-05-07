using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    public float speed = 20f; // Hvor hurtigt padlen bevæger sig
    public float Limit = 25f; // Hvor langt padlen må bevæge sig til siderne

    void Update()
    {
        float input = Input.GetAxis("Horizontal"); // Brug piletaster eller A/D
        Vector3 move = new Vector3(2*input * speed * Time.deltaTime, 0f, 0f);
        transform.position += move;

        // Begræns padlens position på x-aksen det gør vi ved hjælp af Clamp og vi lavede tideligere vores float "limit" som 
        float Begræns = Mathf.Clamp(transform.position.x, -Limit - 5, Limit + 6);
        transform.position = new Vector3(Begræns, transform.position.y, transform.position.z);
    }
}