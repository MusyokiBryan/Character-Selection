using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.UI; 

public class CharacterManager : MonoBehaviour
{
    public CharacterSave characterDB;

    public Text nameText;
    public SpriteRenderer artworkSprite;

    private int selectedOption = 0;
    // Start is called before the first frame update
    void Start()
    {
        UpdateCharacter(selectedOption);
    }
    public void NextOption()
    {
        selectedOption++;

        if (selectedOption >= characterDB.CharacterCount)
        {
            selectedOption = 0;
        }

        UpdateCharacter(selectedOption);
    }

    public void BackOption()
    {
        selectedOption--;

        if(selectedOption < 0)
        {
            selectedOption = characterDB.CharacterCount -1;
        }
        UpdateCharacter(selectedOption);
    }

    private void UpdateCharacter(int selectedOption)
    {
        Character character = characterDB.GetCharacter(selectedOption);
        artworkSprite.sprite = character.characterSprite;
        nameText.text = character.characterName;
    }
}
