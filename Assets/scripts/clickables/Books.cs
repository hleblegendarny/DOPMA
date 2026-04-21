using UnityEngine;
class Books : Clickable
{
    protected override void OnMouseDown()
    {
        if(base.IsDialogue()) return;

        AssignFormsPrefab();
        Globals.FormsPrefab.SetActive(true);
    }
    void AssignFormsPrefab()
    {
        if (Globals.FormsPrefab == null)
        {
            ButtonsFunctions FormsPrefabScript = FindObjectOfType<ButtonsFunctions>(true);
            if (FormsPrefabScript != null)
                {
                    Globals.FormsPrefab = FormsPrefabScript.transform.root.gameObject;
                }
                else
                {
                Debug.LogError("FormsPrefab missing");
                return;
                }
        }
    }
}