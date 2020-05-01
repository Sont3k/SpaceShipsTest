using Assets.Scripts.Interfaces;
using UnityEngine;

namespace Assets.Scripts.Slots
{
    public class LightSlot : MonoBehaviour, ISlot
    {
        public int Health { get; set; }

        public void Action()
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