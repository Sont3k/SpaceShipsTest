using Assets.Scripts.Interfaces;
using Assets.Scripts.SlotModules.GunParticles;
using Assets.Scripts.Slots;
using UnityEngine;

namespace Assets.Scripts.SlotModules.MediumSlotModules
{
    public class DoublePlasmaCannon : MediumSlot, IGuns
    {
        public override int Health { get; set; } = 20;
        public int Barrels { get; set; } = 2;

        private readonly Plasma _plasma;

        public DoublePlasmaCannon(Plasma plasma)
        {
            _plasma = plasma;
        }

        public override void Action()
        {
            if (Health > 0)
            {
                for(int i = 0; i < Barrels; i++)
                {
                    Debug.Log("Double plasma cannon is shooting.");
                }
            }
            else
            {
                Debug.Log("Can't shoot from double plasma cannon, it's broken.");
            }
        }
    }
}