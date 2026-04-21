using UnityEngine;
class Books : Clickable
{
    protected override void OnMouseDown()
    {
        if(base.IsDialogue()) return;
        Globals.IsFormFilled = true;
    }
}