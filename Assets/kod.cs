using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public float fallSpeed = 5.0f; // Küplerin düşüş hızı
    public float rotationSpeed = 50.0f; // Küplerin dönüş hızı

    void Update()
    {
        // Küpleri aşağıya doğru hareket ettirme
        transform.Translate(Vector3.down * fallSpeed * Time.deltaTime);

        // Küpleri döndürme
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
