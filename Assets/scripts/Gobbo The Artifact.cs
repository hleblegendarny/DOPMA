using UnityEngine;
public class Gobbo : MonoBehaviour
{
    [SerializeField] string[] Names;
    string[] Lines;
    [SerializeField] string[] CorrectLines;
    [SerializeField] string[] WrongLines;
    [SerializeField] string[] NeutralLines;
    void Start()
    {
        Ending();
        AssignDialogue();
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
    void Ending(){
        if (Globals.BossRage == 0){
            Lines = CorrectLines;
            return;
        }
        if(Globals.BossRage >= 2){
            Lines = WrongLines;
        }else{
            Lines = NeutralLines;
        }
            
    }
}