using UnityEngine;
[System.Serializable]
public class Dialogue
{
    public string name;
    [TextArea(1, 2)]
    public string[] sentences;
}
