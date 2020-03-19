using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioVolumeSetting : MonoBehaviour
{
   
    
        public UnityEngine.UI.Slider slider;
        public UnityEngine.Audio.AudioMixer Volume;
        public string parameterName;

        void Awake()
        {
            float savedVol = PlayerPrefs.GetFloat(parameterName, slider.maxValue);
            SetVolume(savedVol); //Manually set value & volume before subscribing to ensure it is set even if slider.value happens to start at the same value as is saved
            slider.value = savedVol;
            slider.onValueChanged.AddListener((float _) => SetVolume(_)); //UI classes use unity events, requiring delegates (delegate(float _) { SetVolume(_); }) or lambda expressions ((float _) => SetVolume(_))
        }

        void SetVolume(float _value)
        {
            Volume.SetFloat(parameterName, ConvertToDecibel(_value / slider.maxValue)); //Dividing by max allows arbitrary positive slider maxValue
            PlayerPrefs.SetFloat(parameterName, _value);
        }

     
        /// Converts a percentage fraction to decibels,
        /// with a lower clamp of 0.0001 for a minimum of -80dB, same as Unity's Mixers.
      
        public float ConvertToDecibel(float _value)
        {
            return Mathf.Log10(Mathf.Max(_value, 0.0001f)) * 20f;
        }
    }
