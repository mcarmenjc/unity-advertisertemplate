using UnityEditor;

public class CreateAssetBundles
{
	[MenuItem ("Build/BuildWebplayerStreamed")]
	public static void MyBuild(){
		string[] levels = new string[] {"Assets/Scenes/AxelSpringerHackday.unity"};
		BuildPipeline.BuildStreamedSceneAssetBundle( levels, "Assets/Build/advert.unity3d", BuildTarget.Android); 
	}
}