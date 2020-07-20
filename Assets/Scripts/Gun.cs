using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Gun : ScriptableObject
{
    [Tooltip("the name that shows in the UI")]
    public string displayName;
    [Tooltip("the sprite in the players hand")]
    public Sprite gameSprite;

    [Tooltip("How many health points it does")]
    public float damage;
    [Tooltip("the prefab GameObject that is created when the gun fires")]
    public GameObject projectile;
    [Tooltip("set to true if the gun is automatic, false if semi")]
    public bool isAutomatic;
    [Tooltip("how many shots per second")]
    public float fireRate;

    [Tooltip("set to true if the gun's spread is NOT random")]
    public bool fixedSpread;
    [Tooltip("the number of projectiles that are created each shot")]
    public int projectileCount;
    [Tooltip("the angle in degrees that the bullets will deviate")]
    public float spread;
}
