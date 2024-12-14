using System;
using System.Collections;
using UnityEngine;

namespace WorldTime
{
    public class Time : MonoBehaviour
    {
        public event EventHandler<TimeSpan> WorldTimeChange;

        [SerializeField]
        private float _daylength;

        private TimeSpan _currentTime;
        private float _min => _daylength / 1440;

        private void Start()
        {
            StartCoroutine(addMin());
        }
        private IEnumerator addMin()
        {
            _currentTime += TimeSpan.FromMinutes(1);
            WorldTimeChange?.Invoke(this, _currentTime);
            yield return new WaitForSeconds(_min);
            StartCoroutine(addMin());
        }
    }
}
    
