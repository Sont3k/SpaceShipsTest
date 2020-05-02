using Assets.Scripts.Interfaces;
using UnityEngine;

namespace Assets.Scripts.Slots
{
    public abstract class HeavySlot : MonoBehaviour, ISlot
    {
        public abstract int Health { get; set; }
        public abstract int Level { get; set; }
        
        public abstract void InitLevel();
        public abstract void Action();
    }
}
