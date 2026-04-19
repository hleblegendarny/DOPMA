using UnityEngine;
using UnityEngine.Events;

class Clickable : MonoBehaviour
{
    private Renderer[] r;
    private Material mat;
    void Start()
    {
        r = GetComponentsInChildren<Renderer>();
    }
    void OnMouseEnter()
    {
        foreach (Renderer obj in r) {
            mat = obj.material;
            mat.EnableKeyword("_EMISSION");
        }
        
    }
    void OnMouseExit()
    {
        foreach (Renderer obj in r) {
            mat = obj.material;
            mat.DisableKeyword("_EMISSION");
        }
    }
    void OnMouseDown()
    {
        SendMessage("RunAction", SendMessageOptions.DontRequireReceiver);
    }
}