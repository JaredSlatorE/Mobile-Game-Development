using System;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Ball.Movement
{
    [Serializable]
    public struct MovementVariables
    {
        public int MovementSpeed;
    }
    public class BallMovementScript : MonoBehaviour
    {
        public int MovementVariable;
        public Rigidbody Rigidbody;
        private UnityEngine.InputSystem.Accelerometer Accelerometer;
        void Start()
        {
            if (SystemInfo.supportsAccelerometer)
            {
                Accelerometer = InputSystem.GetDevice<UnityEngine.InputSystem.Accelerometer>();
                InputSystem.EnableDevice(Accelerometer);
            }
        }

        void Update()
        {
            gameObject.transform.position += new Vector3((Accelerometer.acceleration.y.value * MovementVariable)* Time.deltaTime,0,0);
        }
    }
}