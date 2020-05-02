using UnityEngine;

namespace Assets.Scripts
{
    public class Destroyer : MonoBehaviour
    {
        private void DestroyObject(GameObject obj) // string reference
        {
            Destroy(obj);
        }
    }
}