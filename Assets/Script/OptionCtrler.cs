using UnityEngine;
using UnityEngine.UI;

public class OptionCtrler : MonoBehaviour
{

    [SerializeField] private Slider _music;
    [SerializeField] private Slider _sfx;

    public void setBGM()
    {
        SoundManager.instance.SetVolume(_music.value);
    }
    public void setSFX()
    {
        SoundManager.instance.SetVolume(_sfx.value);
    }
    public void BGMmuteToggle()
    {
       SoundManager.instance.muteBGM();
    }
    public void SFXmuteToggle()
    {
        SoundManager.instance.muteSFX();
    }

}
