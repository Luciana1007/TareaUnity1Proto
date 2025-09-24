using UnityEngine;

// Clase con única responsabilidad: controlar al jugador
public class PlayerController : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public GameObject magicPrefab;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot(bulletPrefab);
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            Shoot(magicPrefab);
        }
    }

    void Shoot(GameObject projectilePrefab)
    {
        Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
    }
}
