using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class DialogueManager : MonoBehaviour
{
    public Dialogue dialogue;

    public GameObject leftCharacter, rightCharacter;
    public Image lPortrait, rPortrait;
    public Text lName, rName;
    public Text dialogueText;

    public UnityEvent DialougeEnd;

    private int lineIndex = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        NextLine();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            lineIndex++;
            NextLine();
        }
    }

    private void NextLine()
    {
        if (lineIndex > dialogue.lines.Length - 1)
        {
            DialougeEnd.Invoke();
            return;
        }

        if (dialogue.lines[lineIndex].leftChar)
        {
            leftCharacter.SetActive(true);
            rightCharacter.SetActive(false);
            lPortrait.sprite = dialogue.lines[lineIndex].portrait;
            lName.text = dialogue.lines[lineIndex].name;
        }
        else
        {
            leftCharacter.SetActive(false);
            rightCharacter.SetActive(true);
            rPortrait.sprite = dialogue.lines[lineIndex].portrait;
            rName.text = dialogue.lines[lineIndex].name;
        }

        dialogueText.text = dialogue.lines[lineIndex].text;
    }
}
