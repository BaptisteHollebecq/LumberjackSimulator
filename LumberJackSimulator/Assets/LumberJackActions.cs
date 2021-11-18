// GENERATED AUTOMATICALLY FROM 'Assets/LumberJackActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @LumberJackActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @LumberJackActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""LumberJackActions"",
    ""maps"": [
        {
            ""name"": ""Lumber"",
            ""id"": ""195e990e-7f6e-463f-a8b8-e7b8111c3f46"",
            ""actions"": [
                {
                    ""name"": ""LeftTrigger"",
                    ""type"": ""Value"",
                    ""id"": ""689cf417-f987-4162-8419-ae9e6d082076"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightTrigger"",
                    ""type"": ""Value"",
                    ""id"": ""667a7c35-dfeb-4d8c-a65d-b8b75b8b2bd1"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeftGrip"",
                    ""type"": ""Value"",
                    ""id"": ""f57d7041-6950-43b2-9be4-960c5ad5fb27"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightGrip"",
                    ""type"": ""Value"",
                    ""id"": ""1823e8b9-6afb-4157-a684-fb4f229a434b"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""bfc45d67-4eb5-493c-bae4-bb8ce3ca3090"",
                    ""path"": ""<XRController>{LeftHand}/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftTrigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1852fdb2-9a98-4865-9f7e-e5055df84a3e"",
                    ""path"": ""<XRController>{RightHand}/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightTrigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d3e07e98-1e4d-434c-859d-1e4875c4acfb"",
                    ""path"": ""<XRController>{LeftHand}/grip"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftGrip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e35a1039-94bb-4b9d-a946-10564d449f39"",
                    ""path"": ""<XRController>{RightHand}/grip"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightGrip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Lumber
        m_Lumber = asset.FindActionMap("Lumber", throwIfNotFound: true);
        m_Lumber_LeftTrigger = m_Lumber.FindAction("LeftTrigger", throwIfNotFound: true);
        m_Lumber_RightTrigger = m_Lumber.FindAction("RightTrigger", throwIfNotFound: true);
        m_Lumber_LeftGrip = m_Lumber.FindAction("LeftGrip", throwIfNotFound: true);
        m_Lumber_RightGrip = m_Lumber.FindAction("RightGrip", throwIfNotFound: true);
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

    // Lumber
    private readonly InputActionMap m_Lumber;
    private ILumberActions m_LumberActionsCallbackInterface;
    private readonly InputAction m_Lumber_LeftTrigger;
    private readonly InputAction m_Lumber_RightTrigger;
    private readonly InputAction m_Lumber_LeftGrip;
    private readonly InputAction m_Lumber_RightGrip;
    public struct LumberActions
    {
        private @LumberJackActions m_Wrapper;
        public LumberActions(@LumberJackActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @LeftTrigger => m_Wrapper.m_Lumber_LeftTrigger;
        public InputAction @RightTrigger => m_Wrapper.m_Lumber_RightTrigger;
        public InputAction @LeftGrip => m_Wrapper.m_Lumber_LeftGrip;
        public InputAction @RightGrip => m_Wrapper.m_Lumber_RightGrip;
        public InputActionMap Get() { return m_Wrapper.m_Lumber; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(LumberActions set) { return set.Get(); }
        public void SetCallbacks(ILumberActions instance)
        {
            if (m_Wrapper.m_LumberActionsCallbackInterface != null)
            {
                @LeftTrigger.started -= m_Wrapper.m_LumberActionsCallbackInterface.OnLeftTrigger;
                @LeftTrigger.performed -= m_Wrapper.m_LumberActionsCallbackInterface.OnLeftTrigger;
                @LeftTrigger.canceled -= m_Wrapper.m_LumberActionsCallbackInterface.OnLeftTrigger;
                @RightTrigger.started -= m_Wrapper.m_LumberActionsCallbackInterface.OnRightTrigger;
                @RightTrigger.performed -= m_Wrapper.m_LumberActionsCallbackInterface.OnRightTrigger;
                @RightTrigger.canceled -= m_Wrapper.m_LumberActionsCallbackInterface.OnRightTrigger;
                @LeftGrip.started -= m_Wrapper.m_LumberActionsCallbackInterface.OnLeftGrip;
                @LeftGrip.performed -= m_Wrapper.m_LumberActionsCallbackInterface.OnLeftGrip;
                @LeftGrip.canceled -= m_Wrapper.m_LumberActionsCallbackInterface.OnLeftGrip;
                @RightGrip.started -= m_Wrapper.m_LumberActionsCallbackInterface.OnRightGrip;
                @RightGrip.performed -= m_Wrapper.m_LumberActionsCallbackInterface.OnRightGrip;
                @RightGrip.canceled -= m_Wrapper.m_LumberActionsCallbackInterface.OnRightGrip;
            }
            m_Wrapper.m_LumberActionsCallbackInterface = instance;
            if (instance != null)
            {
                @LeftTrigger.started += instance.OnLeftTrigger;
                @LeftTrigger.performed += instance.OnLeftTrigger;
                @LeftTrigger.canceled += instance.OnLeftTrigger;
                @RightTrigger.started += instance.OnRightTrigger;
                @RightTrigger.performed += instance.OnRightTrigger;
                @RightTrigger.canceled += instance.OnRightTrigger;
                @LeftGrip.started += instance.OnLeftGrip;
                @LeftGrip.performed += instance.OnLeftGrip;
                @LeftGrip.canceled += instance.OnLeftGrip;
                @RightGrip.started += instance.OnRightGrip;
                @RightGrip.performed += instance.OnRightGrip;
                @RightGrip.canceled += instance.OnRightGrip;
            }
        }
    }
    public LumberActions @Lumber => new LumberActions(this);
    public interface ILumberActions
    {
        void OnLeftTrigger(InputAction.CallbackContext context);
        void OnRightTrigger(InputAction.CallbackContext context);
        void OnLeftGrip(InputAction.CallbackContext context);
        void OnRightGrip(InputAction.CallbackContext context);
    }
}
