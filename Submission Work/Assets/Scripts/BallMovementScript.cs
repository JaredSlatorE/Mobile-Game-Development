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

        public Collider GroundCollider;
        private float CurrentTime = 0;
        private float DelayTime = 1;

        public bool IsOnGround {get;private set;}
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

            CurrentTime += Time.deltaTime;
            if ((CurrentTime > DelayTime) && IsOnGround)
            {
                if (-0.9 > (Accelerometer.acceleration.value.z))
                {
                    Debug.Log("Added");

                    Rigidbody.AddForce(new Vector3(0,200,0));
                    CurrentTime = 0;
                }
            }
            gameObject.transform.position += new Vector3((Accelerometer.acceleration.y.value * MovementVariable)* Time.deltaTime,0,0); //https://youtu.be/wpSm2O2LIRM?si=wAhYx5U9BiMOQkDz
        }
        private void ChangeGroundState(bool state)
        {
            IsOnGround = state;
        }

        void OnTriggerEnter(Collider other)
        {
            ChangeGroundState(true);
        }
        void OnTriggerExit(Collider other)
        {
            ChangeGroundState(false);
        }
    }
}