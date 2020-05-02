using Assets.Scripts.Slots;
using UnityEngine;

namespace Assets.Scripts.SlotModules.MediumSlotModules
{
    public class EnergyShield : MediumSlot
    {
        public override int Health { get; set; }

        public override void Action()
        {
            if (Health > 0)
            {
                Debug.Log("Energy shield is on.");
            }
            else
            {
                Debug.Log("Can't enable energy shield, it has no energy.");
            }
        }
    }
}