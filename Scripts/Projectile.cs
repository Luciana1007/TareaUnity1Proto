using UnityEngine;

// Clase base de proyectiles
public abstract class Projectile : MonoBehaviour
{
    public float speed = 10f;

    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}