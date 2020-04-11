using UnityEngine;
using UnityEngine.UI;

public class ButtonTranslator : MonoBehaviour
{
    // Variable to store reference to button
    Button button;

    // Hold translation for each button
    public Translation translation;

    void Start()
    {
        // Store reference to button
        button = GetComponent<Button>();

        // Set the text value to translation result
        button.GetComponentInChildren<Text>().text = translation.Translate();
    }
}
