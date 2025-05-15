using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using NUnit.Framework;
using System.Collections.Generic;
public class TitleManager : MonoBehaviour
{
    public SpriteRenderer sr;
    public List<Sprite> titles = new List<Sprite>();
    private int selectedtitle = 0;
    public GameObject playertitle;


    public void NextOption()
    {
        selectedtitle = selectedtitle + 1;
        if (selectedtitle == titles.Count)
        {
            selectedtitle = 0;


        }
        sr.sprite = titles[selectedtitle];




    }
    public void BackOption()
    {
        selectedtitle = selectedtitle - 1;
        if (selectedtitle < 0)
        {
            selectedtitle = titles.Count - 1;


        }
        sr.sprite = titles[selectedtitle];

    }
}