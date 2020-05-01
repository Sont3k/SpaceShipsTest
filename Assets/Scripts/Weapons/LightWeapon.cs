using Assets.Scripts.Interfaces;
using UnityEngine;

namespace Assets.Scripts.Weapons
{
    public class LightWeapon : MonoBehaviour, IWeapon
    {
        private int _health;
        public int Health { get => _health; set { _health = value; } }

        public void Shoot()
        {
            Debug.Log("Shooting from light weapon");
        }
    }
}