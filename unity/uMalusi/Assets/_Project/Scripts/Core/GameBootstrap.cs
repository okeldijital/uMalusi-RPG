using UnityEngine;

namespace UMalusi.Core
{
    public class GameBootstrap : MonoBehaviour
    {
        private SystemRegistry _systemRegistry;

        private void Awake()
        {
            DontDestroyOnLoad(gameObject);
            _systemRegistry = new SystemRegistry();
            InitializeSystems();
        }

        private void InitializeSystems()
        {
            Debug.Log("[GameBootstrap] System initialization started.");
        }

        private void OnApplicationQuit()
        {
            _systemRegistry.ShutdownAll();
        }
    }
}
