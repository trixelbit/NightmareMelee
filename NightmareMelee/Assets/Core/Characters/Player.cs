using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : Character
{
    [SerializeField]
    public GameControls Controls;
    public IEquipable _equipedWeapon { get; private set; }
    protected Item[] _inventory;

    private EPlayerState _state;

    private Vector2 _input;
    private bool _canSprint = false;

    protected override void Awake()
    {
        base.Awake();
        Controls = new GameControls();
        Controls.ActiveGame.Sprint.performed += delegate { _canSprint = true; };
        Controls.ActiveGame.Sprint.canceled += delegate { _canSprint = false; };
    }

    protected override void Update()
    {
        SetPlayerState();

        switch (_state)
        {
            case EPlayerState.Idle:
                break;
            case EPlayerState.Walk:
                Walk(_input);
                break;
            case EPlayerState.Run:
                Run(_input);
                break;
            case EPlayerState.Attack:
                break;
            default:
                break;
        }
    }

    private void SetPlayerState()
    {
        _input = Controls.ActiveGame.Movement.ReadValue<Vector2>();
        if (_input.magnitude == 0)
        {
            _state = EPlayerState.Idle;
        }
        else
        {
            if (_canSprint)
            {
                _state = EPlayerState.Run;
            }
            else
            {
                _state = EPlayerState.Walk;
            }
        }
    }

    protected override void Attack()
    {
        if (_equipedWeapon == null)
        {
            return;        
        }

        _equipedWeapon.Shoot();
    }

    private enum EPlayerState 
    { 
        Idle,
        Walk,
        Run,
        Attack
    }

    private void OnEnable()
    {
        Controls.Enable();
    }

    private void OnDisable()
    {
        Controls.Disable();
    }
}
