using UnityEngine;

public class GlobalState
{
    public static SystemLanguage language; // Global static SystemLanguage used to translate strings

    private void Awake()
    {
        language = Application.systemLanguage; // Set global language when starting to the current system's language
    }
}