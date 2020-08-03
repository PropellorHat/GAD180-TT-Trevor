using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Gun : ScriptableObject
{
    [Header("Display")]
    [Tooltip("the name that shows in the UI")]
    public string displayName;
    [Tooltip("the sprite in the players hand")]
    public Sprite gameSprite;
    [Tooltip("the sprite in the ui and pickups")]
    public Sprite uiSprite;

    [Header("Stats")]
    [Tooltip("How many health points it does")]
    public float damage;
    [Tooltip("the prefab GameObject that is created when the gun fires")]
    public GameObject projectile;
    [Tooltip("how many shots it takes before needing to reload. set to -1 if the gun has infinite ammo")]
    public int clipSize;
    [Tooltip("set to true if the gun is automatic, false if semi")]
    public bool isAutomatic;
    [Tooltip("how many shots per second")]
    public float fireRate;

    [Header("Spread")]
    [Tooltip("set to true if the gun's spread is NOT random")]
    public bool fixedSpread;
    [Tooltip("the number of projectiles that are created each shot")]
    public int projectileCount;
    [Tooltip("the angle in degrees that the bullets will deviate")]
    public float spread;
}
