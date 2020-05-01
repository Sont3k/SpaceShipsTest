using Assets.Scripts.Interfaces;
using Assets.Scripts.Slots;
using UnityEngine;

namespace Assets.Scripts.SlotModules.LightSlotModules
{
    public class MachineGun : LightSlot
    {
        public override int Health { get; set; }
        public int Barrel { get; set; } = 1;
        private readonly IGunParticles _bullets;

        public MachineGun(IGunParticles bullets)
        {
            _bullets = bullets;
        }

        public override void Action()
        {
            if (Health > 0)
            {
                Debug.Log("MachineGun is shooting.");
            }
            else
            {
                Debug.Log("Can't shoot from machine gun, it's broken.");
            }
        }
    }
}