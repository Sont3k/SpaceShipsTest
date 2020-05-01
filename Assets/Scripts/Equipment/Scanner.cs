using Assets.Scripts.Interfaces;
using UnityEngine;

namespace SpaceshipsTest.Assets.Scripts.Equipment
{
    public class Scanner : MonoBehaviour, IEquipment
    {
        public int Health { get; set; }

        public void Use()
        {
            if(Health > 0)
            {
                Debug.Log("Started scanning");
            }
            else
            {
                Debug.Log("Can't scan, scanner is broken.");
            }
        }
    }
}