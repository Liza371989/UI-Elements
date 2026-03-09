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
    public void toggleCharacterObject(Toggle _myToggle, int _propNumber)
    {
        if (_myToggle.isOn)
        {
            propList[_propNumber].SetActive(true);
        }else{
            propList[_propNumber].SetActive(false);
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
