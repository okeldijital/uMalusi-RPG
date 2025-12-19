using System.Collections.Generic;
using UMalusi.Systems;
using UnityEngine;

namespace UMalusi.Core
{
    public class SystemRegistry
    {
        private readonly List<IGameSystem> _systems = new();

        public void Register(IGameSystem system)
        {
            if (_systems.Contains(system))
                return;

            _systems.Add(system);
            system.Initialize();
        }

        public void ShutdownAll()
        {
            for (int i = _systems.Count - 1; i >= 0; i--)
            {
                _systems[i].Shutdown();
            }

            _systems.Clear();
        }
    }
}
