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

        private float RecordedZ = 0;
        private float CurrentTime = 0;
        private float DelayTime = 0.5f;
        void Start()
        {
            if (SystemInfo.supportsAccelerometer)
            {
                Accelerometer = InputSystem.GetDevice<UnityEngine.InputSystem.Accelerometer>();
                InputSystem.EnableDevice(Accelerometer);
                RecordedZ = Accelerometer.acceleration.z.value;
            }
        }

        void Update()
        {
            CurrentTime += Time.deltaTime;
            if (CurrentTime > DelayTime)
            {
                if (-(RecordedZ + 0.25f) > -(Accelerometer.acceleration.value.z))
                {
                    Debug.Log("Added");

                    Rigidbody.AddForce(new Vector3(0,100,0));
                }
                RecordedZ = Accelerometer.acceleration.z.value;
            }
            Debug.Log(Accelerometer.acceleration.value.z);
            gameObject.transform.position += new Vector3((Accelerometer.acceleration.y.value * MovementVariable)* Time.deltaTime,0,0);
        }
    }
}