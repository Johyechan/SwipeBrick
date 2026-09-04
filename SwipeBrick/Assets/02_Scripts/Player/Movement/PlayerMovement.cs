using UnityEngine;

// 작성자: 조혜찬
namespace Player.Movement
{
    public class PlayerMovement
    {
        Transform _playerTransform; // 플레이어 이동을 위한 Transform

        float _speed; // 속도
        float _minDistance = 0.01f;

        public PlayerMovement(Transform playerTransform, float speed)
        {
            _playerTransform = playerTransform;
            _speed = speed;
        }

        // 이동 함수(목표 대상)
        public void Move(Vector3 targetPos)
        {
            Vector3 direction = targetPos - _playerTransform.position;
            _playerTransform.position += direction.normalized * _speed * Time.deltaTime;
        }

        public bool IsReachToTarget(Vector3 target)
        {
            if (Vector3.Distance(_playerTransform.position, target) <= _minDistance)
            {
                return true;
            }

            return false;
        }
    }
}

// 마지막 작성 일자: 2026.09.04