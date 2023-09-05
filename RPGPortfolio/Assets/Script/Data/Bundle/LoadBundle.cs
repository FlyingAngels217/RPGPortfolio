using System.Collections;
using System.IO;
using UnityEngine;

public class LoadBundle : MonoBehaviour
{
    string bundleName;
    string assetName;

    public void LoadFromLocalAsync()
    {
        StartCoroutine(LoadFromLocalAsyncProcess());
    }

    private IEnumerator LoadFromLocalAsyncProcess()
    {
        AssetBundleCreateRequest asyncBundleRequest = AssetBundle.LoadFromFileAsync(Path.Combine(Application.streamingAssetsPath, bundleName));

        yield return asyncBundleRequest;

        AssetBundle localAssetBundle = asyncBundleRequest.assetBundle;

        if(localAssetBundle == null)
        {
            Debug.LogError("번들 로드 실패");
            yield break;
        }

        AssetBundleRequest assetRequest = localAssetBundle.LoadAssetAsync<GameObject>(assetName);

        localAssetBundle.Unload(true);
    }
}
