using Assets.Scripts.Interfaces;
using UnityEngine;

namespace Assets.Scripts.Slots
{
    public class MediumSlot : MonoBehaviour, ISlot
    {
        public virtual int Health { get; set; }

        public virtual void Action() {}
    }
}
