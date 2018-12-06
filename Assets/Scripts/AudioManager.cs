using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class AudioManager : MonoBehaviour {

    public AudioClip BackgroudMusic;
    public AudioClip MenuMusic;
    public AudioClip CountryRoads;
    public AudioClip BatteryLow;
    public AudioSource Player;
    public AudioSource MainMenuObject;


    //MonsterSource Sounds and Object Sounds
    public AudioClip[] MonsterLoop;
    public AudioClip[] MonsterDetect;
    public AudioClip[] MonsterDeath;
    public AudioClip[] PickupNoise;
    public AudioSource[] MonsterSource;
    public AudioSource[] BookSource;



    //public static AudioManager Instance;




    //To call functions here use public AudioManager FunctionName;
    //Drag Audio Manager to the public area and hopefully it works.


   public void PlayerDeath(int x) 
    {
        MonsterSource[x].clip = MonsterDeath[x];
        MonsterSource[x].loop = false;
        MonsterSource[x].Play();
    }

   public void Bat_Tery(bool LowNot)
    {
        if (LowNot == true)
        {
            Player.clip = BatteryLow;
            Player.loop = true;
            Player.Play();
        }
        else
        {
            Player.loop = false;
        }
    }

    public void MonsterDetectPlayer(int x) 
    {
        MonsterSource[x].clip = MonsterDetect[x];
        MonsterSource[x].loop = false;
        MonsterSource[x].Play();
    }

    public void Pickup(int x)
    {
        Player.clip = PickupNoise[x];
        Player.loop = false;
        Player.Play();
    }
    public void GeneralSoundPlay(AudioClip AudioClip, AudioSource AudioSource, bool Loop)
    {
        AudioSource.clip = AudioClip;
        AudioSource.loop = Loop;
        AudioSource.Play();
    }
    public void BookSound()
    {
        for ( int x = 0; x <= 4; x++)
        {
            BookSource[x].clip = CountryRoads;
            BookSource[x].loop = true;
            BookSource[x].Play();
        }

    }
    private void Awake()
    {

    }
    void Start ()
    { 
        Player.clip = MenuMusic;
        Player.loop = true;
        Player.Play();
    }

    public void StopMenuMusic()
    {
        MainMenuObject.Stop();
    }
	
   public void VolumeControl(AudioSource AudioSource, bool UpDown)
    {
        if (UpDown == true)
        {
            AudioSource.volume += 0.1f;
        }
        else
        {
            AudioSource.volume -= 0.1f;
        }
    }

    public void StopAllMusic()
    {
        MonsterSource[0].Stop();
        MonsterSource[1].Stop();
        MonsterSource[2].Stop();
        Player.Stop();
        MainMenuObject.Stop();
    }
	// Update is called once per frame

}
