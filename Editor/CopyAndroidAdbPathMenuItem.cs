using UnityEditor;
using UnityEngine;

namespace Kogane.Internal
{
    internal static class CopyAndroidAdbPathMenuItem
    {
        [MenuItem( "Kogane/コピー/Android adb パス" )]
        private static void Copy()
        {
            var result = $"{EditorApplication.applicationPath}/../PlaybackEngines/AndroidPlayer/SDK/platform-tools/adb";
            EditorGUIUtility.systemCopyBuffer = result;
            Debug.Log( $"Copied! `{result}`" );
        }
    }
}