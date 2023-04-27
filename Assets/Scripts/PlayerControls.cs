//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.2.0
//     from Assets/Scripts/PlayerControls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerControls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Movement"",
            ""id"": ""1b35036c-9fa3-4b75-bf32-7725165b6a39"",
            ""actions"": [
                {
                    ""name"": ""Ski"",
                    ""type"": ""Button"",
                    ""id"": ""182b61a9-3bf2-490a-9939-db84190f4686"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""5c147ef4-a771-41bc-a0da-5d22345a88cc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MoveVector"",
                    ""type"": ""Value"",
                    ""id"": ""5f954712-d352-4f46-84b8-df597f27b69b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""LookVector"",
                    ""type"": ""Value"",
                    ""id"": ""69d04e48-5c2c-4185-9024-8ee2eb8d07b0"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""DownJet"",
                    ""type"": ""Button"",
                    ""id"": ""f1ed069d-0b72-480f-beda-e9259634b5ca"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""62f22703-5bc0-43df-b00c-a721d8c7326f"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Ski"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a1291867-4dd1-472d-987c-c3610df7c02d"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""7830d8a8-f6e0-4b60-b7ae-9c2ea59f2d6f"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveVector"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""c6a7261f-1ea4-4948-8b35-fed1cf738f82"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveVector"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""b9b0da56-95ad-46ac-89b1-f91d3b3ac2f2"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveVector"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""9d71a358-3f3b-4b0e-9495-d8fe104c45c7"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveVector"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""1a9621cc-a273-44e0-8cbd-afddd53cd597"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveVector"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""57495766-4043-4880-a583-d18039d0b6b7"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LookVector"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1c9c6362-cc68-4edb-bc97-2ee01fe8b504"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DownJet"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Movement
        m_Movement = asset.FindActionMap("Movement", throwIfNotFound: true);
        m_Movement_Ski = m_Movement.FindAction("Ski", throwIfNotFound: true);
        m_Movement_Jump = m_Movement.FindAction("Jump", throwIfNotFound: true);
        m_Movement_MoveVector = m_Movement.FindAction("MoveVector", throwIfNotFound: true);
        m_Movement_LookVector = m_Movement.FindAction("LookVector", throwIfNotFound: true);
        m_Movement_DownJet = m_Movement.FindAction("DownJet", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Movement
    private readonly InputActionMap m_Movement;
    private IMovementActions m_MovementActionsCallbackInterface;
    private readonly InputAction m_Movement_Ski;
    private readonly InputAction m_Movement_Jump;
    private readonly InputAction m_Movement_MoveVector;
    private readonly InputAction m_Movement_LookVector;
    private readonly InputAction m_Movement_DownJet;
    public struct MovementActions
    {
        private @PlayerControls m_Wrapper;
        public MovementActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Ski => m_Wrapper.m_Movement_Ski;
        public InputAction @Jump => m_Wrapper.m_Movement_Jump;
        public InputAction @MoveVector => m_Wrapper.m_Movement_MoveVector;
        public InputAction @LookVector => m_Wrapper.m_Movement_LookVector;
        public InputAction @DownJet => m_Wrapper.m_Movement_DownJet;
        public InputActionMap Get() { return m_Wrapper.m_Movement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementActions set) { return set.Get(); }
        public void SetCallbacks(IMovementActions instance)
        {
            if (m_Wrapper.m_MovementActionsCallbackInterface != null)
            {
                @Ski.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnSki;
                @Ski.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnSki;
                @Ski.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnSki;
                @Jump.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnJump;
                @MoveVector.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnMoveVector;
                @MoveVector.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnMoveVector;
                @MoveVector.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnMoveVector;
                @LookVector.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnLookVector;
                @LookVector.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnLookVector;
                @LookVector.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnLookVector;
                @DownJet.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnDownJet;
                @DownJet.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnDownJet;
                @DownJet.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnDownJet;
            }
            m_Wrapper.m_MovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Ski.started += instance.OnSki;
                @Ski.performed += instance.OnSki;
                @Ski.canceled += instance.OnSki;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @MoveVector.started += instance.OnMoveVector;
                @MoveVector.performed += instance.OnMoveVector;
                @MoveVector.canceled += instance.OnMoveVector;
                @LookVector.started += instance.OnLookVector;
                @LookVector.performed += instance.OnLookVector;
                @LookVector.canceled += instance.OnLookVector;
                @DownJet.started += instance.OnDownJet;
                @DownJet.performed += instance.OnDownJet;
                @DownJet.canceled += instance.OnDownJet;
            }
        }
    }
    public MovementActions @Movement => new MovementActions(this);
    public interface IMovementActions
    {
        void OnSki(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnMoveVector(InputAction.CallbackContext context);
        void OnLookVector(InputAction.CallbackContext context);
        void OnDownJet(InputAction.CallbackContext context);
    }
}
