//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Scripts/Antek/Controller.inputactions
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

public partial class @Controller: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controller()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controller"",
    ""maps"": [
        {
            ""name"": ""Fucking_Controller"",
            ""id"": ""be07f211-55c9-4ef9-813a-e5baf82f7d5e"",
            ""actions"": [
                {
                    ""name"": ""Movement_Waiter"",
                    ""type"": ""Value"",
                    ""id"": ""7f449d04-2f00-4226-902d-1541470315dd"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Movement_FuckingRat"",
                    ""type"": ""Value"",
                    ""id"": ""f41ea76e-51ea-4be7-a416-bef0c6a5d7dd"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7118e147-1b7a-4969-aebd-beb50adf514c"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement_FuckingRat"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""32ab3571-237d-4ca7-b838-1eb8d56b8dbe"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": ""AxisDeadzone"",
                    ""groups"": """",
                    ""action"": ""Movement_Waiter"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Fucking_Controller
        m_Fucking_Controller = asset.FindActionMap("Fucking_Controller", throwIfNotFound: true);
        m_Fucking_Controller_Movement_Waiter = m_Fucking_Controller.FindAction("Movement_Waiter", throwIfNotFound: true);
        m_Fucking_Controller_Movement_FuckingRat = m_Fucking_Controller.FindAction("Movement_FuckingRat", throwIfNotFound: true);
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

    // Fucking_Controller
    private readonly InputActionMap m_Fucking_Controller;
    private List<IFucking_ControllerActions> m_Fucking_ControllerActionsCallbackInterfaces = new List<IFucking_ControllerActions>();
    private readonly InputAction m_Fucking_Controller_Movement_Waiter;
    private readonly InputAction m_Fucking_Controller_Movement_FuckingRat;
    public struct Fucking_ControllerActions
    {
        private @Controller m_Wrapper;
        public Fucking_ControllerActions(@Controller wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement_Waiter => m_Wrapper.m_Fucking_Controller_Movement_Waiter;
        public InputAction @Movement_FuckingRat => m_Wrapper.m_Fucking_Controller_Movement_FuckingRat;
        public InputActionMap Get() { return m_Wrapper.m_Fucking_Controller; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Fucking_ControllerActions set) { return set.Get(); }
        public void AddCallbacks(IFucking_ControllerActions instance)
        {
            if (instance == null || m_Wrapper.m_Fucking_ControllerActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_Fucking_ControllerActionsCallbackInterfaces.Add(instance);
            @Movement_Waiter.started += instance.OnMovement_Waiter;
            @Movement_Waiter.performed += instance.OnMovement_Waiter;
            @Movement_Waiter.canceled += instance.OnMovement_Waiter;
            @Movement_FuckingRat.started += instance.OnMovement_FuckingRat;
            @Movement_FuckingRat.performed += instance.OnMovement_FuckingRat;
            @Movement_FuckingRat.canceled += instance.OnMovement_FuckingRat;
        }

        private void UnregisterCallbacks(IFucking_ControllerActions instance)
        {
            @Movement_Waiter.started -= instance.OnMovement_Waiter;
            @Movement_Waiter.performed -= instance.OnMovement_Waiter;
            @Movement_Waiter.canceled -= instance.OnMovement_Waiter;
            @Movement_FuckingRat.started -= instance.OnMovement_FuckingRat;
            @Movement_FuckingRat.performed -= instance.OnMovement_FuckingRat;
            @Movement_FuckingRat.canceled -= instance.OnMovement_FuckingRat;
        }

        public void RemoveCallbacks(IFucking_ControllerActions instance)
        {
            if (m_Wrapper.m_Fucking_ControllerActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IFucking_ControllerActions instance)
        {
            foreach (var item in m_Wrapper.m_Fucking_ControllerActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_Fucking_ControllerActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public Fucking_ControllerActions @Fucking_Controller => new Fucking_ControllerActions(this);
    public interface IFucking_ControllerActions
    {
        void OnMovement_Waiter(InputAction.CallbackContext context);
        void OnMovement_FuckingRat(InputAction.CallbackContext context);
    }
}