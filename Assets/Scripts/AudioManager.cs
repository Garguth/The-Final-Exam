using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {

    public AudioClip NotePickup;
    public AudioClip BatteryPickup;
    public AudioClip BackgroudMusic;
    public AudioClip MenuMusic;

    //Monster loop sounds/Ambient noise
    public AudioClip SmallMonsterLoop;
    public AudioClip MediumMonsterLoop;
    public AudioClip LargeMonsterLoop;

    //Death Sounds
    public AudioClip SmallMonsterDeath;
    public AudioClip MediumMonsterDeath;
    public AudioClip LargeMonsterDeath;

    //Detection sounds
    public AudioClip SmallMonsterDetect;
    public AudioClip MediumMonsterDetect;
    public AudioClip LargeMonsterDetect;

    //Audio Sources for Each Object
    public AudioSource SmallMonster;
    public AudioSource MediumMonster;
    public AudioSource LargeMonster;
    public AudioSource PLAYERISCENTEROFWORLD;


    static void LargeMonsterDeathF()
    {
        
    }
    private void Awake()
    {
    }
    void Start ()
    { 
        LargeMonster.clip = LargeMonsterLoop;
        LargeMonster.loop = true;
        LargeMonster.Play();

        SmallMonster.clip = SmallMonsterLoop;
        SmallMonster.loop = true;
        SmallMonster.Play();

        PLAYERISCENTEROFWORLD.clip = BackgroudMusic;
        PLAYERISCENTEROFWORLD.loop = true;
        PLAYERISCENTEROFWORLD.Play();

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
