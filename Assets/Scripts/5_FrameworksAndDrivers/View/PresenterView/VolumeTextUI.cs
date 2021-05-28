using UnityEngine;
using UnityEngine.UI;

namespace kodai100.CA.View.UIComponents
{

    [RequireComponent(typeof(Text))]
    public class VolumeTextUI : MonoBehaviour, IVolumeTextUI
    {

        private Text _textUI;
        
        public void Set(string text)
        {

            if (!_textUI)
            {
                _textUI = GetComponent<Text>();
            }
            
            _textUI.text = text;
        }
    }

}