using UnityEngine;
public class Artifacts : MonoBehaviour
{
    public string[] Dialogues;
    public FormTypes ArtifactForm;
    void Start()
    {
        CorrectForm = ArtifactForm; // see Globals.cs
        // TODO: add Dialogue spawn
    }
}