// GENERATED AUTOMATICALLY FROM 'Assets/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""5262f4b4-ebce-4483-a239-c3a0828110be"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""f4e31e8b-6b24-4e60-bd11-9a5f05fc1289"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rise"",
                    ""type"": ""Button"",
                    ""id"": ""553be805-ff09-4408-a8e0-683bbba36837"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Sink"",
                    ""type"": ""Button"",
                    ""id"": ""9913726b-2ed0-441a-8741-1d4cdf862596"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""27341b07-45ea-484b-bdea-8383d80085d3"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightAim"",
                    ""type"": ""Button"",
                    ""id"": ""7e6c03c8-f7e8-4549-bb9d-cbda57b3aa64"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeftAim"",
                    ""type"": ""Button"",
                    ""id"": ""69a041c5-fe58-4afa-8d5b-f72f826ea086"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Punch"",
                    ""type"": ""Button"",
                    ""id"": ""925a1e3b-b6d6-4e0e-a3b9-8a078616e6a8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Test"",
                    ""type"": ""Button"",
                    ""id"": ""279523d2-0720-416e-b7c9-212cd874fad3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""1940762d-74fe-4b4c-99e0-fd656ba76ecf"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""50705588-4b2c-4dc7-88e4-56285baf7053"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""26fa7f44-0d49-44cf-8234-b2855c98f07f"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""14c2a629-41f3-4c53-858a-59444a178e2e"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""bd564475-e89e-4ea6-801a-2d191a98b54b"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""85ba533c-9e03-4074-bfca-e5ebef9d5955"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""55a6f1ac-622e-4113-b5a7-c28c549bfffb"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rise"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""150d4de1-0a7e-4318-976e-06647de7b85b"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rise"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""664f7142-235f-4d0b-a66a-e16edfb24305"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sink"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fbbff11a-f01a-448d-9d4c-b1e7dda1fa5a"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sink"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""01b546e8-0a3d-41cd-9ae7-d4351352d2a8"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2b0a1e91-7190-4a95-945a-12ef4d212b40"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f30d195d-6ed6-4443-bea6-718b0fd94646"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightAim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""07aea23c-93ad-43ab-bac4-1e3248c12db6"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightAim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""24ed5522-96b1-4259-8cd2-013b2b59495f"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftAim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""56a6cad0-bbfc-4e83-851b-fb21b17b8880"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftAim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1971c240-6858-4355-a0c5-13493d6ab3ae"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Punch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""19543524-4362-4bef-9778-eba1599ca520"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Punch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""13f76272-e5d4-40c8-91ae-7f8b524591b4"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Test"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_Move = m_Gameplay.FindAction("Move", throwIfNotFound: true);
        m_Gameplay_Rise = m_Gameplay.FindAction("Rise", throwIfNotFound: true);
        m_Gameplay_Sink = m_Gameplay.FindAction("Sink", throwIfNotFound: true);
        m_Gameplay_Look = m_Gameplay.FindAction("Look", throwIfNotFound: true);
        m_Gameplay_RightAim = m_Gameplay.FindAction("RightAim", throwIfNotFound: true);
        m_Gameplay_LeftAim = m_Gameplay.FindAction("LeftAim", throwIfNotFound: true);
        m_Gameplay_Punch = m_Gameplay.FindAction("Punch", throwIfNotFound: true);
        m_Gameplay_Test = m_Gameplay.FindAction("Test", throwIfNotFound: true);
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

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_Move;
    private readonly InputAction m_Gameplay_Rise;
    private readonly InputAction m_Gameplay_Sink;
    private readonly InputAction m_Gameplay_Look;
    private readonly InputAction m_Gameplay_RightAim;
    private readonly InputAction m_Gameplay_LeftAim;
    private readonly InputAction m_Gameplay_Punch;
    private readonly InputAction m_Gameplay_Test;
    public struct GameplayActions
    {
        private @PlayerControls m_Wrapper;
        public GameplayActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Gameplay_Move;
        public InputAction @Rise => m_Wrapper.m_Gameplay_Rise;
        public InputAction @Sink => m_Wrapper.m_Gameplay_Sink;
        public InputAction @Look => m_Wrapper.m_Gameplay_Look;
        public InputAction @RightAim => m_Wrapper.m_Gameplay_RightAim;
        public InputAction @LeftAim => m_Wrapper.m_Gameplay_LeftAim;
        public InputAction @Punch => m_Wrapper.m_Gameplay_Punch;
        public InputAction @Test => m_Wrapper.m_Gameplay_Test;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @Rise.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRise;
                @Rise.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRise;
                @Rise.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRise;
                @Sink.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSink;
                @Sink.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSink;
                @Sink.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSink;
                @Look.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLook;
                @RightAim.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRightAim;
                @RightAim.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRightAim;
                @RightAim.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRightAim;
                @LeftAim.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLeftAim;
                @LeftAim.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLeftAim;
                @LeftAim.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLeftAim;
                @Punch.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPunch;
                @Punch.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPunch;
                @Punch.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPunch;
                @Test.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnTest;
                @Test.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnTest;
                @Test.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnTest;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Rise.started += instance.OnRise;
                @Rise.performed += instance.OnRise;
                @Rise.canceled += instance.OnRise;
                @Sink.started += instance.OnSink;
                @Sink.performed += instance.OnSink;
                @Sink.canceled += instance.OnSink;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @RightAim.started += instance.OnRightAim;
                @RightAim.performed += instance.OnRightAim;
                @RightAim.canceled += instance.OnRightAim;
                @LeftAim.started += instance.OnLeftAim;
                @LeftAim.performed += instance.OnLeftAim;
                @LeftAim.canceled += instance.OnLeftAim;
                @Punch.started += instance.OnPunch;
                @Punch.performed += instance.OnPunch;
                @Punch.canceled += instance.OnPunch;
                @Test.started += instance.OnTest;
                @Test.performed += instance.OnTest;
                @Test.canceled += instance.OnTest;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);
    public interface IGameplayActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnRise(InputAction.CallbackContext context);
        void OnSink(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnRightAim(InputAction.CallbackContext context);
        void OnLeftAim(InputAction.CallbackContext context);
        void OnPunch(InputAction.CallbackContext context);
        void OnTest(InputAction.CallbackContext context);
    }
}
