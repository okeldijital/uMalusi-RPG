using System.Collections.Generic;
using UnityEngine;
using UMalusi.Narrative;

namespace UMalusi.Systems
{
    public class NarrativeSystem : IGameSystem
    {
        private readonly HashSet<string> _unlockedPages = new();

        public void Initialize()
        {
            Debug.Log("[NarrativeSystem] Initialized.");
        }

        public void Shutdown()
        {
            _unlockedPages.Clear();
            Debug.Log("[NarrativeSystem] Shutdown.");
        }

        public void UnlockPage(CodexPageData page)
        {
            if (page == null || _unlockedPages.Contains(page.pageId))
                return;

            _unlockedPages.Add(page.pageId);
            Debug.Log($"[NarrativeSystem] Codex page unlocked: {page.pageId}");
        }

        public bool IsPageUnlocked(string pageId)
        {
            return _unlockedPages.Contains(pageId);
        }
    }
}
