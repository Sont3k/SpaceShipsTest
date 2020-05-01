using Assets.Scripts.Interfaces;
using UnityEngine;

namespace Assets.Scripts.Slots
{
    public class HeavySlot : MonoBehaviour, ISlot
    {
        public int Health { get; set; }

        public void Action()
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
