using UnityEditor;
using UnityEditor.Build.Reporting;

class MyEditorScript
{
    static void PerformBuild ()
    {
        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
        buildPlayerOptions.scenes = new[] { "Assets/Scenes/SampleScene.unity" };
        buildPlayerOptions.locationPathName = "Builds/MyAndroidBuild.apk"; 
        buildPlayerOptions.target = BuildTarget.Android; 
        buildPlayerOptions.options = BuildOptions.None; 

        BuildPipeline.BuildPlayer(buildPlayerOptions);
    }
} 
