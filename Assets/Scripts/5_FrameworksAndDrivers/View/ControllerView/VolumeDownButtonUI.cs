using System;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace kodai100.CA.View.UIComponents
{
    
    [RequireComponent(typeof(Button))]
    public class VolumeDownButtonUI : MonoBehaviour, IVolumeDownControlView
    {
        public event Action Clicked = delegate { };

        private void Start()
        {

            var button = GetComponent<Button>();
            button.OnClickAsObservable().Subscribe(_ =>
            {
                Clicked();
            }).AddTo(this);
            
        }

        public void AddClickHandler(Action onClicked)
        {
            Clicked += onClicked;
        }
        
        private void OnDestroy()
        {
            Clicked = delegate { };
        }
    }
}

