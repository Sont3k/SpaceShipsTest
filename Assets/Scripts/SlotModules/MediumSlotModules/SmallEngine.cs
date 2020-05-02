using Assets.Scripts.Slots;
using Assets.Scripts.Interfaces;
using UnityEngine;

namespace Assets.Scripts.SlotModules.MediumSlotModules
{
    public class SmallEngine : MediumSlot, IEngine
    {
        public override int Health { get; set; } = 10;
        public int Throttle { get; set; } = 100;

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