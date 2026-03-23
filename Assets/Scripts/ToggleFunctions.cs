using UnityEngine;
using UnityEngine.UI;

public class ToggleFunctions : MonoBehaviour
{
    public void toggleTrueFalse(Toggle _myToggle, Toggle _otherToggle)
    {
        if (_myToggle.isOn)
        {
            _otherToggle.isOn = false;
        }
    }

    public void toggleMultipleChoice(Toggle _myToggle, Toggle[] _otherToggles)
    {
        if (_myToggle.isOn){
            _otherToggles[0].isOn = false;
            _otherToggles[1].isOn = false;
            _otherToggles[2].isOn = false;
        }
    }

    public GameObject[] propList;
    public void toggleCharacterObject0(Toggle _myToggle)
    {
        if (_myToggle.isOn)
        {
            propList[0].SetActive(true);
        }else{
            propList[0].SetActive(false);
        }
    }
	
	 public void toggleCharacterObject1(Toggle _myToggle)
    {
        if (_myToggle.isOn)
        {
            propList[1].SetActive(true);
        }else{
            propList[1].SetActive(false);
        }
    }
	
	 public void toggleCharacterObject2(Toggle _myToggle)
    {
        if (_myToggle.isOn)
        {
            propList[2].SetActive(true);
        }else{
            propList[2].SetActive(false);
        }
    }

    public AudioSource musicSpeaker;
    public void toggleMusic(Toggle _myToggle)
    {
        if (_myToggle.isOn){
            musicSpeaker.Play();     
        }else{
            musicSpeaker.Pause(); 
        }
    }

    public AudioSource narrationSpeaker;
    public void toggleNarration(Toggle _myToggle)
    {
        if (_myToggle.isOn){
            narrationSpeaker.Play();  
        }else{
            narrationSpeaker.Pause();  
        }
    }

}
