using UnityEditor;
using UnityEngine;

namespace Kogane.Internal
{
    internal static class CopyAndroidAdbPathMenuItem
    {
        [MenuItem( "Kogane/コピー/Android adb パス" )]
        private static void Copy()
        {
            var result = Application.platform == RuntimePlatform.WindowsEditor
                    ? $"{EditorApplication.applicationPath}/../Data/PlaybackEngines/AndroidPlayer/SDK/platform-tools/adb"
                    : $"{EditorApplication.applicationPath}/../PlaybackEngines/AndroidPlayer/SDK/platform-tools/adb"
                ;

            EditorGUIUtility.systemCopyBuffer = result;
            Debug.Log( $"Copied! `{result}`" );
        }
    }
}