using Assets.Scripts.Interfaces;
using UnityEngine;

namespace Assets.Scripts.Weapons
{
    public class MediumWeapon : IWeapon
    {
        public int Health { get; set; }

        public void Shoot()
        {
            Debug.Log("Shooting from medium weapon");
        }
    }
}
