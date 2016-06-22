using UnityEngine;
using FMODUnity;
using FMOD.Studio;

public class FModController : MonoBehaviour {
    [EventRef]
    public string SND_PlayerDeath = "event:/Player/Player_Death";
    [EventRef]
    public string SND_PlayerHit = "event:/Player/Player_Hit";
    [EventRef]
	public string SND_PlayerShoot;
	[EventRef]
	public string SND_PlayerDimensionChanged = "event:/Player/Dimension";

    EventInstance SND_ControlledEvent; // istanza dell'evento
    float SND_param1; // variabile di appoggio per lettura del valore del pitch dell'istanza audio3

    void Start() {
 
		StartLevel();
    }


	public void StartLevel(){
		EventInstance SND_ControlledEvent = RuntimeManager.CreateInstance(SND_PlayerDeath);
		SND_ControlledEvent.start();		


		EventInstance SND_ControlledEvent_WithParameters = RuntimeManager.CreateInstance(SND_PlayerShoot);
		SND_ControlledEvent_WithParameters.setParameterValue("WeaponNumber", 1);
		SND_ControlledEvent_WithParameters.start();
		SND_ControlledEvent_WithParameters.setParameterValue("WeaponNumber", 2);
		SND_ControlledEvent_WithParameters.start();

	}

	public void PlayerDimensionChanged(float _playerDimension, float _playerSpeed){
		EventInstance EVT_SND_PlayerDimensionChanged = RuntimeManager.CreateInstance(SND_PlayerDimensionChanged);
		EVT_SND_PlayerDimensionChanged.setParameterValue("Dimension", _playerDimension);
		EVT_SND_PlayerDimensionChanged.setParameterValue("Speed", _playerSpeed);
		EVT_SND_PlayerDimensionChanged.start();
		EVT_SND_PlayerDimensionChanged.stop();
		RuntimeManager.PlayOneShot(EVT_SND_PlayerDimensionChanged);
	}
}