#pragma strict
@script RequireComponent(AudioSource)
function Start () {
audio.loop=true;
}

function Update () {

}

function OnGUI() {
    if (GUILayout.Button("BGM pause"))
    {if (!audio.isPlaying)
    {audio.Play();}
    else 
    audio.Pause();
    }
}