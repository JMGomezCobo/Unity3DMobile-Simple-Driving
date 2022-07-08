using UnityEngine;

namespace SimpleDriving
{
    [AddComponentMenu("Player/Car Controller")]
    public class CarController : MonoBehaviour
    {
        [Header("Settings")] 
        [SerializeField] private float _speed = 10f;
        [SerializeField] private float _speedMultiplier = 0.5f;
        [SerializeField] private float _turnSpeed = 200f;

        private int _steerValue;
        
        private void Update()
        {
            _speed += _speedMultiplier * Time.deltaTime;
            
            transform.Rotate(0, _steerValue * _turnSpeed * Time.deltaTime, 0);
            transform.Translate(Vector3.forward * (_speed * Time.deltaTime));
        }

        public void Steer(int value)
        {
            _steerValue = value;
        }
    }
}