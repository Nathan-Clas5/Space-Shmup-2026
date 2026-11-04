using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum eWeaponType {
    none,
    blaster,
    spread,
    phaser,
    missile,
    laser,
    shield,
}

[System.Serializable]
public class WeaponDefinition {
    public eWeaponType type = eWeaponType.none;
    [Tooltip("Letter to show on the PowerUp Cube")]
    public string letter;
    [Tooltip("Color of the PowerUp Cube")]
    public Color powerUpColor = Color.white;
    [Tooltip("Prefab of Weapon Model that is attached to the Player Ship")]
    public GameObject weaponModelPrefab;
    [Tooltip("Pregab of projectile that is fired")]
    public GameObject projectilePrefab;
    [Tooltip("Color of the Projectile that is fired")]
    public Color projectileColor = Color.white;
    [Tooltip("Damage caused when a single Projectile hits an enemy")]
    public float damageOnHit = 0;
    [Tooltip("Damage caused per second by the Laser [Not Implemented]")]
    public float amagerPerSec = 0;
    [Tooltip("Seconds to delay between shots")]
    public float delayBetweenShots = 0;
    [Tooltip("Velocity of individual Projectiles")]
    public float velocity = 50;
}

public class Weapon : MonoBehaviour
{
   
}
