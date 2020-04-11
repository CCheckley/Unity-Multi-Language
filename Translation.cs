using UnityEngine;

[CreateAssetMenu(menuName = "Translation", fileName = "New Translation")]
public class Translation : ScriptableObject // Scriptable object so we can store in engine each string and its translations
{
    // Store value for each translation
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

    public string Translate() // translates based on current global state language
    {
        switch (GlobalState.language)
        {
            case Language.en:
                return en;
            case Language.fr:
                return fr;
            case Language.de:
                return de;
            case Language.es:
                return es;
            case Language.ja:
                return ja;
            case Language.ko:
                return ko;
            case Language.ru:
                return ru;
            case Language.zh:
                return zh;
            case Language.pt:
                return pt;
            case Language.zhtw:
                return zhtw;
            default:
                return string.Empty; // If the specified language isn't implemented, return an empty string, you could also throw here to handle the error
        }
    }
}
