using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterManager : MonoBehaviour
{
    public CharacterSave characterDB; //refence to the character save scriptable object

    public Text nameText;

    public SpriteRenderer artworkSprite; //these 2 are referenced to the selected character and name in unity

    private int selectedOption = 0;

    void Start()
    {
        UpdateCharacter (selectedOption);
    }

    public void NextOption()
    {
        selectedOption++;

        if (selectedOption >= characterDB.CharacterCount)
        {
            selectedOption = 0;
        }

        UpdateCharacter (selectedOption);
    }

    public void BackOption()
    {
        selectedOption--;

        if (selectedOption < 0)
        {
            selectedOption = characterDB.CharacterCount - 1;
        }
        UpdateCharacter (selectedOption);
    }

    private void UpdateCharacter(int selectedOption) //retreiving name and sprite from the scriptable onject DB
    {
        Character character = characterDB.GetCharacter(selectedOption);
        artworkSprite.sprite = character.characterSprite;
        nameText.text = character.characterName;
    }
}
