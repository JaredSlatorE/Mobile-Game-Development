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
        public MovementVariables MovementVariables;
        public Camera Camera;
        private UnityEngine.InputSystem.Gyroscope Gyroscope;
        void Start()
        {
            Gyroscope = InputSystem.GetDevice<UnityEngine.InputSystem.Gyroscope>();
            InputSystem.EnableDevice(Gyroscope);
        }

        void Update()
        {
            gameObject.transform.rotation = new quaternion(0,0,Gyroscope.angularVelocity.x.value * 5,0);
        }
    }
}