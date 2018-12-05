using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class AudioManager : MonoBehaviour {

    public AudioClip BackgroudMusic;
    public AudioClip MenuMusic;

    //Monster loop sounds/Ambient noise
    public AudioClip SmallMonsterLoop;
    public AudioClip MediumMonsterLoop;
    public AudioClip LargeMonsterLoop;
    public AudioClip BatteryLow;

    //Audio Sources for Each Object
    public AudioSource SmallMonster;
    public AudioSource MediumMonster;
    public AudioSource LargeMonster;
    public AudioSource Player;
    public AudioSource MainMenuObject;
    public static AudioManager Instance;




    //To call functions here use Public AudioManager FunctionName;
    //Drag Audio Manager to the public area and hopefully it works.


    void MonsterDeath(AudioClip MonsterDeathSound)
    {
        Player.clip = MonsterDeathSound;
        Player.loop = false;
        Player.Play();
    }

    void Bat_Tery(bool LowNot)
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

    void MonsterDetect(AudioClip MonsterDetectSound, AudioSource MonsterType) 
    {
        MonsterType.clip = MonsterDetectSound;
        MonsterType.loop = false;
        MonsterType.Play();
    }

    void Pickup(AudioClip PickupSound)
    {
        Player.clip = PickupSound;
        Player.loop = false;
        Player.Play();
    }

    void GeneralSound(AudioClip AudioClip, AudioSource AudioSource)
    {

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

    void StopMenuMusic()
    {
        MainMenuObject.Stop();
    }
	
    void VolumeControl(AudioSource AudioSource, bool UpDown)
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

    void StopAllMusic()
    {
        SmallMonster.Stop();
        MediumMonster.Stop();
        LargeMonster.Stop();
        Player.Stop();
        MainMenuObject.Stop();
    }
	// Update is called once per frame
	void Update () {
		
	}
}
