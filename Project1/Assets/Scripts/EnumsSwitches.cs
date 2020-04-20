using System;
using UnityEngine;
using UnityEngine.Events;
using System.Collections;

public class EnumsSwitches : MonoBehaviour {
	
	public UnityEvent startingEvent, playingEvent, inStoreEvent, pausingEvent, endingEvent;
public UnityEvent idlingEvent, runningEvent, jumpingEvent, walkingEvent;
	
	public enum GameStates
	{
		Start,
		Pause,
		InStore,
		Ending,
	}

	public GameStates currentGameState;

	public enum PlayerStates
	{
		Walking,
		Running,
		Jumping,
		Idling,
	}

	public PlayerStates currentPlayerState;
	
	public void ChangeStateToPlaying()
	{
		currentGameState = GameStates.Start;
		}
	
	void Update()
	{
		switch(currentPlayerState)
		{
		case PlayerStates.Idling:
			idlingEvent.Invoke();
			break;
		case PlayerStates.Walking:
			walkingEvent.Invoke();
			break;
		case PlayerStates.Running:
			runningEvent.Invoke();
			break;
		case PlayerStates.Jumping:
			jumpingEvent.Invoke();
			break;
		default:
			print("I am any.");
			break;
		}
		
		switch(currentGameState){
			case GameStates.Start:
				startingEvent.Invoke();
				break;
			case GameStates.Pause:
				pausingEvent.Invoke();
				break;
			case GameStates.InStore:
				inStoreEvent.Invoke();
				break;
			case GameStates.Ending:
				endingEvent.Invoke();
				break;
			default:
				break;
		}
	}
}
