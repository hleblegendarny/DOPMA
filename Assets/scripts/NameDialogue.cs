using System.Collections;
using UnityEngine;
using TMPro;
public class NameDialogue : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textComponent;
    [SerializeField] string[] names;
    private int index;

    public void Init(string[] newNames)
    {
        names = newNames;
        StartDialogue();
    }
    void StartDialogue()
    {
        textComponent.text = string.Empty;
        index = 0;
        textComponent.text = names[index];
    }
    public void NextLine()
    {
        if (index < names.Length - 1)
        {
            index++;
        } else
        {
            index = 0;
        }
            textComponent.text = names[index];
    }
}