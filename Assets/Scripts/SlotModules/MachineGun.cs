using Assets.Scripts.Interfaces;
using Assets.Scripts.Slots;
using UnityEngine;

namespace Assets.Scripts.SlotModules
{
    public class MachineGun : LightSlot
    {
        private readonly IGunParticles _bullets;

        public MachineGun(IGunParticles bullets)
        {
            _bullets = bullets;
        }

        public override int Health { get; set; }

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