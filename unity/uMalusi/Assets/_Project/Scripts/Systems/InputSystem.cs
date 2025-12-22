using UnityEngine;

namespace UMalusi.Systems
{
    public class InputSystem : IGameSystem
    {
        public void Initialize()
        {
            Debug.Log("[InputSystem] Initialized.");
        }

        public void Shutdown()
        {
            Debug.Log("[InputSystem] Shutdown.");
        }
    }
}
