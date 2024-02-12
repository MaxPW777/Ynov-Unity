using TMPro;
using UnityEngine;

public class TextChanger : MonoBehaviour
{
    [SerializeField]
    TextSO[] data = new TextSO[2];
    private TextMeshProUGUI textArea;
    private TextSO text;
    private int currentText;
    private int nbText;
    void Start()
    {
        nbText = data.Length;
        textArea = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    public void change_text(){
        currentText = (currentText + 1) % nbText;
        text = data[currentText];
        textArea.text = text.Paragraph;
    }
}
