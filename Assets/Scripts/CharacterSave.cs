using UnityEngine;

[CreateAssetMenu]//telling unity to make int possible to create the below objects using asset menu
public class CharacterSave : ScriptableObject
{
    public Character[] character;

    public int CharacterCount //store number of characters we have in the game
    {
        get
        {
            return character.Length;
        }
    }
    public Character GetCharacter(int index) //character retreival
    {
        return character[index];
    }
}
