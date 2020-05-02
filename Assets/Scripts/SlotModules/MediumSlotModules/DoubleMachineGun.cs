using Assets.Scripts.Interfaces;
using Assets.Scripts.SlotModules.GunParticles;
using Assets.Scripts.Slots;
using UnityEngine;

namespace Assets.Scripts.SlotModules.MediumSlotModules
{
    public class DoubleMachineGun : MediumSlot, IGuns
    {
        public override int Health { get; set; } = 20;
        public int Barrels { get; set; } = 2;
        private readonly Bullets _bullets;

        public DoubleMachineGun(Bullets bullets)
        {
            _bullets = bullets;
        }

        public override void Action()
        {
            if (Health > 0)
            {
                for(int i = 0; i < Barrels; i++)
                {
                    Debug.Log("Double machine gun is shooting.");
                }
            }
            else
            {
                Debug.Log("Can't shoot from double machine gun, it's broken.");
            }
        }
    }
}