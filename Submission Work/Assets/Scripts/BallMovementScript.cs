using System;
using Unity.Mathematics;
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
        private int testval;
        private UnityEngine.InputSystem.Gyroscope Gyroscope;
        void Start()
        {
            Debug.Log(SystemInfo.supportsGyroscope);
            if (SystemInfo.supportsGyroscope)
            {
                Gyroscope = InputSystem.GetDevice<UnityEngine.InputSystem.Gyroscope>();
                InputSystem.EnableDevice(Gyroscope);
            }
        }

        void Update()
        {
            // Debug.Log(Gyroscope.angularVelocity.value.z);
            gameObject.transform.eulerAngles = new Vector3 (0,0,Gyroscope.angularVelocity.value.z * 90);
        }
    }
}