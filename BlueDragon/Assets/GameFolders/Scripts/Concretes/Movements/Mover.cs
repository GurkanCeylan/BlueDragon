using System.Collections;
using System.Collections.Generic;
using UdemyProject1.Enums;
using UnityEngine;

namespace UdemyProject1.Movements
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Mover : MonoBehaviour
    {
        [SerializeField] float moveSpeed = 5f;
        [SerializeField] DirectionEnum direction;
        Rigidbody2D _rigidbody2D;

        private void Awake()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
        }

        private void OnEnable()
        {
            _rigidbody2D.velocity = selectedNewDirection() * moveSpeed;
        }

        private Vector2 selectedNewDirection()
        {
            Vector2 selectedDirection;

            if (direction == DirectionEnum.Left)
            {
                selectedDirection = Vector2.left;
            }
            else
            {
                selectedDirection = Vector2.right;
            }

            return selectedDirection;
        }
    }
}

