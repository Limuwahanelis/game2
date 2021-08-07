using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputV2 : MonoBehaviour
{
    [SerializeField]
    private PlayerV2 _player;

    // Start is called before the first frame update
    void Start()
    {
        _player = GetComponent<PlayerV2>();
    }

    // Update is called once per frame
    void Update()
    {
        float direction = Input.GetAxisRaw("Horizontal");
        Move(direction);
        if (Input.GetButtonDown("Attack"))
        {
            Attack();
        }
        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }
    }

    private void Move(float direction)
    {
        _player.currentState.Move(direction);
    }
    private void Attack()
    {

        _player.currentState.Attack();

    }
    private void Jump()
    {
        _player.currentState.Jump();
    }
}
