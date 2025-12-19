using UnityEngine;

namespace UMalusi.Core
{
    public class GameBootstrap : MonoBehaviour
    {
        private void Awake()
        {
            DontDestroyOnLoad(gameObject);
            Initialize();
        }

        private void Initialize()
        {
            Debug.Log("[GameBootstrap] Initialization started.");
        }
    }
}
