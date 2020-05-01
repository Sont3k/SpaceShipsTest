using Assets.Scripts.Interfaces;
using UnityEngine;

namespace Assets.Scripts.Weapons
{
    public class MediumWeapon : MonoBehaviour, IWeapon
    {
        public int Health { get; set; }

        public void Shoot()
        {
            if(Health > 0)
            {
                Debug.Log("Shooting from medium weapon.");
            }
            else
            {
                Debug.Log("Can't shoot from medium weapon, it's broken.");
            }
        }
    }
}
