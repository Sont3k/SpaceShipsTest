using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Interfaces
{
    public interface ISlot
    {
        int Health { get; set; }

        void Action();
    }
}