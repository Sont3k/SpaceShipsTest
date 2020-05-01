using Assets.Scripts.Interfaces;
using UnityEngine;

namespace Assets.Scripts.Weapons
{
    public class HeavyWeapon : MonoBehaviour, IWeapon
    {
        public int Health { get; set; }

        public void Shoot()
        {
            Debug.Log("Shooting from heavy weapon");
        }
    }
}
