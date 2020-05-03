using Assets.Scripts.Slots;
using UnityEngine;

namespace Assets.Scripts.SlotModules.MediumSlotModules
{
    public class HPRegenerator : MediumSlot
    {
        public override int Health { get; set; } = 50;
        public override int Level { get; set; } = 1;

        private void Start() {
            InitLevel();
        }

        public override void InitLevel()
        {
            Health *= Level;
        }

        public override void Action()
        {
            if (Health > 0)
            {
                Debug.Log("HP regenerator is on.");
            }
            else
            {
                Debug.Log("Can't enable HP regenerator, it has no energy.");
            }
        }
    }
}