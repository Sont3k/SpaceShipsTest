using Assets.Scripts.Interfaces;
using UnityEngine;

namespace Assets.Scripts.Weapons
{
    public class LightWeapon : MonoBehaviour, IWeapon
    {
        public int Health { get; set; }

        public void Shoot()
        {
            if(Health > 0)
            {
                Debug.Log("Shooting from light weapon.");
            }
            else
            {
                Debug.Log("Can't shoot from light weapon, it's broken.");
            }
        }
    }
}