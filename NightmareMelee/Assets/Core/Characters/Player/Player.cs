using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : Character
{
    public GameControls Controls;

    [Header("Weapon")]
    public GameObject WeaponObject;
    public GameObject WeaponPivot;
    public IEquipable EquipedWeapon{ get; private set; }

    public Item[] Inventory;

    private EPlayerState _state;
    private Vector2 _input;
    private bool _canSprint = false;

    private GameObject _raycastHitObject;

    protected override void Awake()
    {
        base.Awake();
        Controls = new GameControls();
        Controls.ActiveGame.Sprint.performed += delegate { _canSprint = true; };
        Controls.ActiveGame.Sprint.canceled += delegate { _canSprint = false; };
        Controls.ActiveGame.Shoot.performed += delegate { Attack(); };
        _raycastHitObject = new GameObject();

        EquipedWeapon = WeaponObject.GetComponent<Weapon>();
    }

    protected override void Update()
    {
        SetPlayerState();
        UpdateWeaponRotation();
        switch (_state)
        {
            case EPlayerState.Idle:
                Idle();
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
        _input.Normalize();
        if (_input.magnitude == 0)
        {
            _state = EPlayerState.Idle;
        }
        else if (_input.magnitude >= 0.9f)
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
        else
        {
            _state = EPlayerState.Idle;
        }
    }

    protected override void Attack()
    {
        if (EquipedWeapon == null)
        {
            return;        
        }

        EquipedWeapon.Shoot();
    }

    private void UpdateWeaponRotation()
    {
        Ray ray = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());
        if (Physics.Raycast(ray, out RaycastHit hit, 1000))
        {
            _raycastHitObject.transform.position = new Vector3(hit.point.x, hit.point.y, hit.point.z);
            WeaponPivot.transform.LookAt(_raycastHitObject.transform);
        }
    }

    private void OnEnable()
    {
        Controls.Enable();
    }

    private void OnDisable()
    {
        Controls.Disable();
    }
    private enum EPlayerState 
    { 
        Idle,
        Walk,
        Run,
        Attack
    }
}
