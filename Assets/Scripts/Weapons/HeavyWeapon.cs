using Assets.Scripts.Interfaces;
using UnityEngine;

namespace Assets.Scripts.Weapons
{
    public class HeavyWeapon : MonoBehaviour, IWeapon
    {
        public int Health { get; set; }

        public void Shoot()
        {
            if(Health > 0)
            {
                Debug.Log("Shooting from heavy weapon.");
            }
            else
            {
                Debug.Log("Can't shoot from heavy weapon, it's broken.");
            }
        }
    }
}
