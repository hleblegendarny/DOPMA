using UnityEngine;
using UnityEngine.SceneManagement;
public static class Globals {
    public static int BossRage = 0;
    public static FormTypes CorrectForm;
    public static GameObject DialoguePrefab;
    public static GameObject FormsPrefab;
    public static bool IsDialogueActive = false;
    public static bool IsFormFilled = true;

    public static void FormComparisson(FormTypes SuggestedForm)
    {
        if (SuggestedForm != CorrectForm)
        {
            BossRage++;
        }
    }
    public static void SwapScene(string SceneName){
        SceneManager.LoadScene(SceneName);
    }
    public static void ResetGame(){
        BossRage = 0;
        IsDialogueActive = false;
        IsFormFilled = true;
    }
}
public enum FormTypes
{
    Complaint,
    Transfer,
    Statement,
    Protocol,
    Claim
}