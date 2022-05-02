// GENERATED AUTOMATICALLY FROM 'Assets/Core/Input/GameControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @GameControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @GameControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GameControls"",
    ""maps"": [
        {
            ""name"": ""ActiveGame"",
            ""id"": ""a2ce1af2-431a-4779-9a9d-f0d20c7ff176"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""6ca5406c-b290-4fde-8602-b8799d7672fc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""6af71210-e463-457c-800e-d7a01e224f8e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""b7a66992-a10b-4448-899f-fe2b6803147a"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""8e8f806d-1547-4fbc-beaf-8f43d013b5a0"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ac5e449e-3e1f-453a-813c-28ea455db476"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""463f9794-9227-475e-8ea0-b1fe066db8f7"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f59e6e0c-2068-4ac0-8025-0a3763ec6698"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""1d3af069-d0ee-497f-a28a-1b8b1a230e10"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // ActiveGame
        m_ActiveGame = asset.FindActionMap("ActiveGame", throwIfNotFound: true);
        m_ActiveGame_Movement = m_ActiveGame.FindAction("Movement", throwIfNotFound: true);
        m_ActiveGame_Sprint = m_ActiveGame.FindAction("Sprint", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // ActiveGame
    private readonly InputActionMap m_ActiveGame;
    private IActiveGameActions m_ActiveGameActionsCallbackInterface;
    private readonly InputAction m_ActiveGame_Movement;
    private readonly InputAction m_ActiveGame_Sprint;
    public struct ActiveGameActions
    {
        private @GameControls m_Wrapper;
        public ActiveGameActions(@GameControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_ActiveGame_Movement;
        public InputAction @Sprint => m_Wrapper.m_ActiveGame_Sprint;
        public InputActionMap Get() { return m_Wrapper.m_ActiveGame; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ActiveGameActions set) { return set.Get(); }
        public void SetCallbacks(IActiveGameActions instance)
        {
            if (m_Wrapper.m_ActiveGameActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_ActiveGameActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_ActiveGameActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_ActiveGameActionsCallbackInterface.OnMovement;
                @Sprint.started -= m_Wrapper.m_ActiveGameActionsCallbackInterface.OnSprint;
                @Sprint.performed -= m_Wrapper.m_ActiveGameActionsCallbackInterface.OnSprint;
                @Sprint.canceled -= m_Wrapper.m_ActiveGameActionsCallbackInterface.OnSprint;
            }
            m_Wrapper.m_ActiveGameActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Sprint.started += instance.OnSprint;
                @Sprint.performed += instance.OnSprint;
                @Sprint.canceled += instance.OnSprint;
            }
        }
    }
    public ActiveGameActions @ActiveGame => new ActiveGameActions(this);
    public interface IActiveGameActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
    }
}
