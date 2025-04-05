using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BackgroundChanger : MonoBehaviour
{
    public Sprite[] backgroundSprites;         // Assign 4 background sprites in the Inspector
    public Image backgroundDisplay;            // The Image that shows the background
    public GameObject UI;

    // This method gets called by the buttons with values 0–3
    public void OnBackgroundButtonPressed(int index)
    {
        if (index >= 0 && index < backgroundSprites.Length)
        {
            backgroundDisplay.sprite = backgroundSprites[index];
        }
    }

    public void OnCustomClicked()
    {
        UI.SetActive(!UI.activeSelf);
    }

    public void OnExitClicked()
    {
        SceneManager.LoadScene("HomeScreen");
    }

}
