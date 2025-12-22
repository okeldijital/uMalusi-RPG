using UnityEngine;

namespace UMalusi.Narrative
{
    [CreateAssetMenu(
        fileName = "CodexPage",
        menuName = "uMalusi/Narrative/Codex Page"
    )]
    public class CodexPageData : ScriptableObject
    {
        [Header("Identity")]
        public string pageId;

        [Header("Content")]
        [TextArea(5, 12)]
        public string bodyText;

        [Header("Classification")]
        public CodexChapter chapter;
        public CodexPageType pageType;

        [Header("Progression")]
        public bool isMandatory;
    }

    public enum CodexChapter
    {
        Origins,
        FallOfUMzansi,
        TheMalusi,
        Prophecy,
        Unknown
    }

    public enum CodexPageType
    {
        HistoricalAccount,
        PersonalTestimony,
        ContradictoryAccount,
        PropheticFragment
    }
}
