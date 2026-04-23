using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class Dialogues : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textComponent;
    [SerializeField] float TextSpeed;
    GameObject ArtefactRelated;
    protected string[] lines;
    private int index;

    void Update()
    {
        if(Input.GetMouseButtonDown(0)){NextLine();}
    }

    public void Init(GameObject TooMuchTalkativeArtifact, string[] newLines)
    {
        ArtefactRelated = TooMuchTalkativeArtifact;
        lines = newLines;
        StartDialogue();
    }
    void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }
    IEnumerator TypeLine()
    {
        textComponent.text = "";
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(TextSpeed);
        }
    }
    void NextLine()
    {
        if (textComponent.text != lines[index])
        {
            return;
        }
        if (index < lines.Length - 1)
        {
            index++;
            textComponent.text = string.Empty;
            NameDialogue Hey = FindObjectOfType<NameDialogue>();
            Hey.NextLine();
            StartCoroutine(TypeLine());
        }
        else
        {
            Dismiss();
        }
    }
    public void Dismiss()
    {
        Globals.IsDialogueActive = false;
            StopAllCoroutines();
            if(SceneManager.GetActiveScene().name == "BossOffice")Globals.SwapScene("MainMenu");
            Destroy(ArtefactRelated);
            transform.root.gameObject.SetActive(false);
    }
}