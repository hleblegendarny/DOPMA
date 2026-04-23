using UnityEngine;
using UnityEngine.Events;

public class Clickable : MonoBehaviour
{
    protected Renderer[] r;
    protected Material mat;
    public AudioSource audioSource;
    void Start()
    {
        r = GetComponentsInChildren<Renderer>();
        audioSource = GetComponent<AudioSource>();
    }
    protected bool IsDialogue()
    {
        if(!Globals.IsDialogueActive) return false;
        foreach (Renderer obj in r) {
            mat = obj.material;
            mat.DisableKeyword("_EMISSION");
        }
        return true;
    }
    void OnMouseEnter()
    {
        if(IsDialogue()) return;
        foreach (Renderer obj in r) {
            mat = obj.material;
            mat.EnableKeyword("_EMISSION");
        }
        
    }
    void OnMouseExit()
    {
        if(IsDialogue()) return;
        foreach (Renderer obj in r) {
            mat = obj.material;
            mat.DisableKeyword("_EMISSION");
        }
    }
    protected virtual void OnMouseDown()
    {
    }
}