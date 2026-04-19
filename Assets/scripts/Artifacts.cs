using UnityEngine;
public class Artifacts : MonoBehaviour
{
    protected string[] Dialogues;
    public FormTypes ArtifactForm;
    void Awake()
    {
        Globals.CorrectForm = ArtifactForm; // see Globals.cs
        // TODO: add Dialogue spawn
    }
}