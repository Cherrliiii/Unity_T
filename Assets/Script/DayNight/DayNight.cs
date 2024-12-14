using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
 
namespace WorldTime
{
    [RequireComponent(typeof(Light2D))]

    public class DayNight : MonoBehaviour
    {

        [SerializeField]
        private Gradient dayNight;

        [SerializeField]
        private Time _worldTime;

        private Light2D _ligth;

        private void Awake()
        {
            _ligth = GetComponent<Light2D>();
            _worldTime.WorldTimeChange += _WorldTimeChange;
        }

        private void OnDestroy()
        {
            _worldTime.WorldTimeChange -= _WorldTimeChange;
        }

        private void _WorldTimeChange(object sender, TimeSpan newTime)
        {
            _ligth.color = dayNight.Evaluate(PercentOfDay(newTime));
        }

        private float PercentOfDay(TimeSpan timespan)
        {
            return (float)timespan.TotalMinutes % 1440 / 1440;
        }
    }
}

