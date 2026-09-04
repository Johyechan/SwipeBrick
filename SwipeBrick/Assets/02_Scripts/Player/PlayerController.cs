using Enum;
using Player.Movement;
using UnityEngine;
using UnityEngine.InputSystem;

// 작성자: 조혜찬
namespace Player
{
    public class PlayerController : MonoBehaviour
    {
        private PlayerMovement _playerMovement;

        [SerializeField] private float _speed;

        [SerializeField] private Transform _rightTarget;
        [SerializeField] private Transform _leftTarget;
        [SerializeField] private Transform _topTarget;

        private Transform _target;

        // private TargetType _targetType;

        private void Awake()
        {
            _playerMovement = new PlayerMovement(transform, _speed);
            //_targetType = TargetType.None;
        }

        private void Update()
        {
            if (Keyboard.current.dKey.isPressed)
            {
                if (_playerMovement.IsReachToTarget(_target.position))
                {
                    _target = _topTarget;
                }
                else if (_playerMovement.IsReachToTarget(_target.position))
                {
                    _target = _leftTarget;
                }
                else if (_playerMovement.IsReachToTarget(_target.position))
                {
                    _target = _rightTarget;
                }

                _playerMovement.Move(_target.position);
            }

            if (Keyboard.current.aKey.isPressed)
            {
                if (_playerMovement.IsReachToTarget(_target.position))
                {
                    _playerMovement.Move(_leftTarget.position);
                }
                else if (_playerMovement.IsReachToTarget(_leftTarget.position))
                {
                    _playerMovement.Move(_topTarget.position);
                }
                else if (_playerMovement.IsReachToTarget(_topTarget.position))
                {
                    _playerMovement.Move(_rightTarget.position);
                }
            }
        }
    }
}
// 마지막 작성 일자: 2026.09.04