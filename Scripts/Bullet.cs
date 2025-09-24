using UnityEngine;

// Proyectil físico
public class Bullet : Projectile, IDoPhysicalDamage
{
    public void ApplyPhysicalDamage()
    {
        Debug.Log("La bala hace daño físico!");
    }
}