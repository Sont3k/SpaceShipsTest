using Assets.Scripts.Interfaces;
using UnityEngine;

namespace Assets.Scripts.Slots
{
    public abstract class LightSlot : MonoBehaviour, ISlot
    {
        public abstract int Health { get; set; }

        public abstract void Action();
    }
}