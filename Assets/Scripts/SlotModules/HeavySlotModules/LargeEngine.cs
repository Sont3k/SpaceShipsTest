using Assets.Scripts.Interfaces;
using Assets.Scripts.Slots;
using UnityEngine;

namespace Assets.Scripts.SlotModules.HeavySlotModules
{
    public class LargeEngine : HeavySlot, IEngine
    {
        public override int Health { get; set; } = 10;
        public int Throttle { get; set; } = 250;

        public override void Action()
        {
            if (Health > 0)
            {
                Debug.Log("Large engine is giving full throttle.");
            }
            else
            {
                Debug.Log("Can't give full throtle from large engine, it's broken.");
            }
        }
    }
}