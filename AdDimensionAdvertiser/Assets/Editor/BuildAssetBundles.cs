using UnityEditor;

public class CreateAssetBundles
{
	[MenuItem ("Build/BuildWebplayerStreamed")]
	public static void MyBuild(){
		string[] levels = new string[] {"Assets/Scenes/AxelSpringerHackday.unity","Assets/Scenes/CarAdvert.unity","Assets/Scenes/CocaCola.unity"};
		BuildPipeline.BuildStreamedSceneAssetBundle( levels, "Assets/Build/advert.unity3d", BuildTarget.Android); 
	}
}