using Assets.Scripts.Interfaces;
using UnityEngine;

namespace Assets.Scripts.Slots
{
    public class MediumSlot : MonoBehaviour, ISlot
    {
        public int Health { get; set; }

        public void Action()
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
