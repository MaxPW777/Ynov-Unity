using UnityEngine;

[CreateAssetMenu(fileName = "Coco", menuName = "Bitches/Coco", order = 0)]
public class TextSO : ScriptableObject {
    [TextArea(0,4)]
    [SerializeField]
    private string paragraph;
    public string Paragraph => paragraph;
}