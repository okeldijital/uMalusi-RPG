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

    _systemRegistry.Register(new UMalusi.Systems.InputSystem());
    _systemRegistry.Register(new UMalusi.Systems.NarrativeSystem());
}



        private void OnApplicationQuit()
        {
            _systemRegistry.ShutdownAll();
        }
    }
}
