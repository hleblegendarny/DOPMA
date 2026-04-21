using UnityEngine;
public static class Globals {
    public static int BossRage = 0;
    public static FormTypes CorrectForm;
    public static GameObject DialoguePrefab;
    public static bool IsDialogueActive = false;
    public static bool IsFormFilled = true;

    public static void FormComparisson(FormTypes SuggestedForm)
    {
        if (SuggestedForm != CorrectForm)
        {
            BossRage++;
        }
    }
}
public enum FormTypes
{
    Complaint,
    Consent,
    Statement,
    Protocol,
    Claim
}