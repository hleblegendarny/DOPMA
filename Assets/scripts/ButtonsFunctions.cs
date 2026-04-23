using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonsFunctions : MonoBehaviour
{
    public void Exit(){
        Door audio = FindObjectOfType<Door>();
        audio.audioSource.Play();
        transform.root.gameObject.SetActive(false);
    }
    public void Complaint(){
        Globals.IsFormFilled = true;
        Globals.FormComparisson(FormTypes.Complaint);
        Exit();
    }
    public void Transfer(){
        Globals.IsFormFilled = true;
        Globals.FormComparisson(FormTypes.Transfer);
        Exit();
    }
    public void Statement(){
        Globals.IsFormFilled = true;
        Globals.FormComparisson(FormTypes.Statement);
        Exit();
    }
    public void Protocol(){
        Globals.IsFormFilled = true;
        Globals.FormComparisson(FormTypes.Protocol);
        Exit();
    }
    public void Claim(){
        Globals.IsFormFilled = true;
        Globals.FormComparisson(FormTypes.Claim);
        Exit();
    }
    public void StartButton(){
        Globals.ResetGame();
        Globals.SwapScene("PlayerOffice");
    }
    public void ExitButton(){
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}
