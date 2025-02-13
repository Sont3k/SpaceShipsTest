using Assets.Scripts.Interfaces;
using Assets.Scripts.SlotModules.GunParticles;
using Assets.Scripts.Slots;
using UnityEngine;

namespace Assets.Scripts.SlotModules.LightSlotModules
{
    public class PlasmaCannon : LightSlot, IGun
    {
        public override int Health { get; set; } = 10;
        public int Barrels { get; set; } = 1;
        public int Damage { get; set; } = 100;
        public int Rapidity { get; set; } = 10;
        public int Clip { get; set; } = 30;
        public float ClipReloadTime { get; set; } = 20.2f;
        public override int Level { get; set; } = 1;

        private readonly Plasma _plasma;

        public PlasmaCannon(Plasma plasma)
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
                Debug.Log("Plasma cannon is shooting.");
            }
            else
            {
                Debug.Log("Can't shoot from plasma cannon, it's broken.");
            }
        }
    }
}