using UnityEngine;

public enum Language
{
    en, //ENGLISH
    fr, //FRENCH
    de, //GERMAN
    es, //SPANISH - SPAIN
    ja, //JAPANESE
    ko, //KOREAN
    ru, //RUSSIAN
    zh, //CHINESE - SIMPLE
    pt, //PORTUGUESE
    zhtw // CHINESE - TRADITIONAL
}

public class GlobalState
{
    public static Language language; // Set by user choice, used to translate strings
}