using UnityEngine;

[CreateAssetMenu(menuName = "Translation", fileName = "New Translation")] // Sets up the translation in the context menu (right click in assets/heirarchy)
public class Translation : ScriptableObject // Scriptable object so we can hold the data in engine and attach to objects
{
    public string en;
    public string fr;
    public string de;
    public string es;
    public string ja;
    public string ko;
    public string ru;
    public string zh;
    public string pt;
    public string zhtw;
    
    public string Translate()
    {
        // Uses global language state
        switch (GameManager.lang)
        {
            case SystemLanguage.English:
                return en;
            case SystemLanguage.French:
                return fr;
            case SystemLanguage.German:
                return de;
            case SystemLanguage.Spanish:
                return es;
            case SystemLanguage.Japanese:
                return ja;
            case SystemLanguage.Korean:
                return ko;
            case SystemLanguage.Russian:
                return ru;
            case SystemLanguage.Chinese:
            case SystemLanguage.ChineseSimplified:
                return zh;
            case SystemLanguage.Portuguese:
                return pt;
            case SystemLanguage.ChineseTraditional:
                return zhtw;
            default:
                return string.Empty; // return empty string if not implemented
        }
    }
}
