using Assets.Scripts.Slots;
using UnityEngine;

namespace SpaceshipsTest.Assets.Scripts.SlotModules.MediumSlotModules
{
    public class SmallEngine : MediumSlot
    {
        public override int Health { get; set; } = 10;

        public override void Action()
        {
            if (Health > 0)
            {
                Debug.Log("Small engine is giving full throttle.");
            }
            else
            {
                Debug.Log("Can't give full throtle from small engine, it's broken.");
            }
        }
    }
}