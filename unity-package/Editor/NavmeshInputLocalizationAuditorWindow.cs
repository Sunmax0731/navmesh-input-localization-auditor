using UnityEditor;
using UnityEngine;

namespace Sunmax0731.NavmeshInputLocalizationAuditor
{
    public sealed class NavmeshInputLocalizationAuditorWindow : EditorWindow
    {
        [MenuItem("Tools/Sunmax0731/navmesh-input-localization-auditor")]
        public static void Open() => GetWindow<NavmeshInputLocalizationAuditorWindow>("navmesh-input-localization-auditor");

        private void OnGUI()
        {
            GUILayout.Label("NavMesh・Input・Localization検査", EditorStyles.boldLabel);
            GUILayout.Label("Closed alpha editor package is importable.");
        }
    }
}
