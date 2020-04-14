using UnityEngine;
using UnityEngine.UI;

// Attach this script to the object with a Text script you wish to translate
public class TextTranslator : MonoBehaviour
{
    // Hold translation for each button
    public Translation translation;

    void Start()
    {
        // Set the text value to translation result
        GetComponent<Text>().text = translation.Translate();
    }
}
