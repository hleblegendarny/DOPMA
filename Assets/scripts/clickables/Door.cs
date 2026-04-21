using UnityEngine;
class Door : Clickable
{
    [SerializeField] private GameObject[] Artifacts;
    int index = 0;
    protected override void OnMouseDown()
    {
        if(base.IsDialogue() || !Globals.IsFormFilled) return; //need true
        
        if (Globals.BossRage == 2){
            Globals.SwapScene("BossOffice");
        }
        
        if (index > Artifacts.Length - 1)
        {
            Globals.SwapScene("BossOffice");
        }
        Instantiate(Artifacts[index]);
        index++;
    }
}
