using System;
using UnityEngine;

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
        public Gyroscope Gyro;

        void Start()
        {
            Gyro = Input.gyro;
            Gyro.enabled = true;
        }
        void Update()
        {
            Debug.Log(Gyro.attitude);
        }
    }
}