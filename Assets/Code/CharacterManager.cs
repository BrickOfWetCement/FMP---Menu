using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using NUnit.Framework;
using System.Collections.Generic;
public class CharacterManager : MonoBehaviour
{
    public SpriteRenderer sr;
    public List<Sprite> characters = new List<Sprite>();
    private int selectedcharacter = 0;
    public GameObject playercharacter;


    public void NextOption()
    {
        selectedcharacter = selectedcharacter + 1;
        if (selectedcharacter == characters.Count)
        {
            selectedcharacter = 0;


        }
        sr.sprite = characters[selectedcharacter];

        Debug.LogWarning(selectedcharacter);


    }
    public void BackOption()
    {
        selectedcharacter = selectedcharacter - 1;
        if (selectedcharacter < 0)
        {
            selectedcharacter = characters.Count - 1;


        }
        sr.sprite = characters[selectedcharacter];

        Debug.LogWarning(selectedcharacter);
    }
}