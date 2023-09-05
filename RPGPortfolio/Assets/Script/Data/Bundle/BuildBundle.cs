using System.IO;
using UnityEditor;
using UnityEngine;

public class BuildBundle : MonoBehaviour
{
#if UNITY_EDITOR
    [MenuItem("AssetBundle/BuildBundles")]
    public static void BuildBundles()
    {
        string assetBundleDir = "Assets/AssetBundles";

        if(!Directory.Exists(Application.streamingAssetsPath))
        {
            Directory.CreateDirectory(assetBundleDir);
        }

        BuildPipeline.BuildAssetBundles(assetBundleDir, BuildAssetBundleOptions.None, EditorUserBuildSettings.activeBuildTarget);
    }
#endif
}
