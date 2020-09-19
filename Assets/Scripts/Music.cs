using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]

public class Music : MonoBehaviour
{


    public AudioSource s;
    public AudioClip[] au;
    public Text SongName;
    public Image image;
    string unity = "(UnityEngine";
    bool check;
  

    [Range(0, 7)]
    int i;

    private void Start()
    {
        i = 1;
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play()
    {
        if (i >= au.Length)
        
            i = 1;
        
        if(i == 0)
        
            i = au.Length;
        
        s.clip = au[i];
        //SongName.text = au[i].ToString();

        SongName.text = Path.GetFileNameWithoutExtension(au[i].ToString());
        SongName.text = SongName.text.Replace(unity, "");
        s.Play();
        StartCoroutine(Reveal());
    }
    public void Pause()
    {
        s.Pause();
    }
    public void Skip()
    {
        i++;

        Play();
        
    }
    public void BackWard()
    {
        i--;

        Play();
        
    }

    IEnumerator Reveal()
    {
        if (!check)
        {
            check = true;
            for (int i = 40; i > 0; i--)
            {
                image.transform.position += Vector3.up * .1f;

                yield return new WaitForSeconds(.004f);
            }
            yield return new WaitForSeconds(2);
            for (int i = 40; i > 0; i--)
            {
                image.transform.position += Vector3.down * .1f;

                yield return new WaitForSeconds(.004f);
            }
    
            check = false;
        }
        
      
        

    }
}
