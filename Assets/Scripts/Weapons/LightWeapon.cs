using Assets.Scripts.Interfaces;
using UnityEngine;

namespace Assets.Scripts.Weapons
{
    public class LightWeapon : IWeapon
    {
        public int Health { get; set; }

        public void Shoot()
        {
            Debug.Log("Shooting from light weapon");
        }
    }
}