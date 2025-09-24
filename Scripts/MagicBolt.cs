using UnityEngine;

// Proyectil mágico
public class MagicBolt : Projectile, IDoMagicDamage
{
    public void ApplyMagicDamage()
    {
        Debug.Log("El rayo mágico hace daño mágico!");
    }
}