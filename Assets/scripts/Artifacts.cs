using UnityEngine;
public class Artifacts : MonoBehaviour
{
    [SerializeField] FormTypes ArtifactForm;
    [SerializeField] string[] Names;
    [SerializeField] string[] Lines;
    void Start()
    {
        Globals.IsDialogueActive = true;
        Globals.IsFormFilled = false;
        //
        AssignDialogue();
        Globals.CorrectForm = ArtifactForm; // see Globals.cs
        Globals.DialoguePrefab.SetActive(true);
        Globals.DialoguePrefab.GetComponentInChildren<Dialogues>().Init(gameObject,Lines);
        Globals.DialoguePrefab.GetComponentInChildren<NameDialogue>().Init(Names);
    }
    void AssignDialogue()
    {
        if (Globals.DialoguePrefab == null)
        {
            Dialogues dialogueScript = FindObjectOfType<Dialogues>(true);
            if (dialogueScript != null)
                {
                    Globals.DialoguePrefab = dialogueScript.transform.root.gameObject;
                }
                else
                {
                Debug.LogError("Dialogues missing");
                return;
                }
        }
    }
}