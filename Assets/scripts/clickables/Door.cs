using UnityEngine;
class Door : Clickable
{
    [SerializeField] private GameObject[] Artifacts;
    int index = 0;
    protected override void OnMouseDown()
    {
        if(base.IsDialogue() || !Globals.IsFormFilled) return; //need true
        if (index > Artifacts.Length - 1)
        {
            return;
        }
        Instantiate(Artifacts[index]);
        index++;
    }
}
