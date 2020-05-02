using Assets.Scripts.Interfaces;
using Assets.Scripts.SlotModules.GunParticles;
using Assets.Scripts.Slots;
using UnityEngine;

namespace Assets.Scripts.SlotModules.MediumSlotModules
{
    public class DoublePlasmaCannon : MediumSlot, IGun
    {
        public override int Health { get; set; } = 20;
        public int Barrels { get; set; } = 2;
        public int Damage { get; set; } = 200;
        public int Rapidity { get; set; } = 20;
        public int Clip { get; set; } = 60;
        public float ClipReloadTime { get; set; } = 40.4f;
        public override int Level { get; set; } = 1;

        private readonly Plasma _plasma;

        public DoublePlasmaCannon(Plasma plasma)
        {
            _plasma = plasma;
        }

        private void Start() {
            InitLevel();
        }

        public override void InitLevel()
        {
            Health *= Level;
            Damage *= Level;
            Rapidity *= Level;
            Clip *= Level;
            ClipReloadTime *= Level;
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