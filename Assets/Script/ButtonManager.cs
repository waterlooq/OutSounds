using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;  // Include this if you're using TextMeshPro for your button

public class ButtonManager : MonoBehaviour
{
    // The name of the scene you want to load when the button is clicked
    public string sceneName;

    // Start is called before the first frame update
    void Start()
    {
        // If you're using TextMeshPro and want to add functionality to the button
        TMP_Text buttonText = GetComponentInChildren<TMP_Text>();  // Get the TextMeshPro component from the button
        if (buttonText != null)
        {
            buttonText.text = "Click to Load Scene";  // Optional: Change the text on the button
        }
    }

    // This function will be triggered when the button is clicked
    public void OnButtonClick()
    {
        // Load the scene by name
        SceneManager.LoadScene("MainScene");
    }
}
