// GENERATED AUTOMATICALLY FROM 'Assets/Inputs.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Inputs : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Inputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Inputs"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""efb32709-8d9c-484f-ac60-05401601f7fe"",
            ""actions"": [
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""8b77af76-61b5-4858-9092-df3f60385de2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Horizontal"",
                    ""type"": ""Value"",
                    ""id"": ""a4b5ec2b-03e1-4fb0-b509-88320e25c587"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Vertical"",
                    ""type"": ""Value"",
                    ""id"": ""3f9a8109-31f2-4605-931c-22f2f5b7d869"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TopLight"",
                    ""type"": ""Button"",
                    ""id"": ""3dce80df-6830-48c0-b323-bcffd794e55f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""BottomLight"",
                    ""type"": ""Button"",
                    ""id"": ""8c7f6414-4f1b-4d15-8a23-7e86dfc01e2d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeftLight"",
                    ""type"": ""Button"",
                    ""id"": ""02c2de8c-2ea2-4ffa-8906-ce7e23af70db"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightLight"",
                    ""type"": ""Button"",
                    ""id"": ""aae3f1c3-ae19-4b40-986f-9ab63269754a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""respawn"",
                    ""type"": ""Button"",
                    ""id"": ""b2386056-48e2-407c-aef4-776bc5f39c0f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""toggleMap"",
                    ""type"": ""Button"",
                    ""id"": ""9bafc223-d9b6-41f4-b2f3-5067d2d1812d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""q_low"",
                    ""type"": ""Button"",
                    ""id"": ""78663d09-3dc6-4ecf-a0a2-e9ccc37417dd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""q_normal"",
                    ""type"": ""Button"",
                    ""id"": ""cb120d65-ba6f-4c9b-812e-3d98924231bc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""q_ultra"",
                    ""type"": ""Button"",
                    ""id"": ""4df87b85-416e-4337-94ef-d68d3a12b370"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""105cb747-d3bb-417a-be3d-71603dee0b07"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""84ffc9a2-e0fa-4921-a6f3-672c22242414"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""470a68c4-5888-4b4f-b6dd-03522464a8ce"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""769a3df7-f8e4-4ce9-b5c8-153979a47392"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""22d0b2be-d234-465c-83cd-8df86bc687a6"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cdcc1eb6-7270-4065-a0e7-f6bf0a0b97d9"",
                    ""path"": ""<Gamepad>/leftStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""c80cafe5-e9c2-47ed-b0f2-d01689cc420a"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""f33ed547-4938-4f60-8c6e-3a22b484d65e"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""2cc86479-df4b-437e-a33e-b4c56268df8e"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""9fb9fafd-f234-4d32-8567-ea60d7b2b1c1"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""b1afcfbb-d5fd-4d7c-a1ad-b0c6aa12d73c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""c95e268c-9b87-401a-8331-c3d1a2384d55"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""065723ce-6f06-43e6-acbc-78188b211874"",
                    ""path"": ""<Gamepad>/leftStick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""7a6e3974-7d64-4df5-af76-1a47f1513bf5"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""6c41d413-0c88-4e60-859a-a8789bb4b01f"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""b5e86753-c4ed-4f47-88c3-26132f298428"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""ef8e0f2a-8aaa-46d1-b5a2-191f25eed6dd"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""cef05967-1b07-47e7-b52e-c4baca3f66f9"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""b58e7811-8026-401c-a0fc-fd92df71385d"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""36a3bd97-e57f-41f7-87d0-c88bcd2df63a"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftLight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""99eeefe6-c5a0-45dc-8e94-474408b602a7"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftLight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4b2a2575-4b49-427e-b1ba-646466ad620a"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightLight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b1de3df1-8ecc-4ebf-9165-c98cbd723247"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightLight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""66523a17-5a75-45e4-9415-6db4b3c9573d"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""respawn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""40f19d37-b2be-4ee8-9eb3-0a67984ab129"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BottomLight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b3f3e4b8-8d3b-473b-9a4d-564d7e5e08e2"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BottomLight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2718614a-27b8-44c0-99bd-fd116b109593"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TopLight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3eff772a-2157-4a7d-88dc-8becdb79922c"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TopLight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a29b5730-1b38-42e3-8673-4fd18b874683"",
                    ""path"": ""<Keyboard>/m"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""toggleMap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7bc39699-31c1-4e7b-b131-cf738c49c7ca"",
                    ""path"": ""<Keyboard>/f1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""q_low"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3ea44804-4c4d-4c6c-918c-6c5cdc905f6d"",
                    ""path"": ""<Keyboard>/f2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""q_normal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d73af77a-792b-4b1c-98b4-4e18ecfe9b8f"",
                    ""path"": ""<Keyboard>/f3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""q_ultra"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Shoot = m_Player.FindAction("Shoot", throwIfNotFound: true);
        m_Player_Horizontal = m_Player.FindAction("Horizontal", throwIfNotFound: true);
        m_Player_Vertical = m_Player.FindAction("Vertical", throwIfNotFound: true);
        m_Player_TopLight = m_Player.FindAction("TopLight", throwIfNotFound: true);
        m_Player_BottomLight = m_Player.FindAction("BottomLight", throwIfNotFound: true);
        m_Player_LeftLight = m_Player.FindAction("LeftLight", throwIfNotFound: true);
        m_Player_RightLight = m_Player.FindAction("RightLight", throwIfNotFound: true);
        m_Player_respawn = m_Player.FindAction("respawn", throwIfNotFound: true);
        m_Player_toggleMap = m_Player.FindAction("toggleMap", throwIfNotFound: true);
        m_Player_q_low = m_Player.FindAction("q_low", throwIfNotFound: true);
        m_Player_q_normal = m_Player.FindAction("q_normal", throwIfNotFound: true);
        m_Player_q_ultra = m_Player.FindAction("q_ultra", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Shoot;
    private readonly InputAction m_Player_Horizontal;
    private readonly InputAction m_Player_Vertical;
    private readonly InputAction m_Player_TopLight;
    private readonly InputAction m_Player_BottomLight;
    private readonly InputAction m_Player_LeftLight;
    private readonly InputAction m_Player_RightLight;
    private readonly InputAction m_Player_respawn;
    private readonly InputAction m_Player_toggleMap;
    private readonly InputAction m_Player_q_low;
    private readonly InputAction m_Player_q_normal;
    private readonly InputAction m_Player_q_ultra;
    public struct PlayerActions
    {
        private @Inputs m_Wrapper;
        public PlayerActions(@Inputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Shoot => m_Wrapper.m_Player_Shoot;
        public InputAction @Horizontal => m_Wrapper.m_Player_Horizontal;
        public InputAction @Vertical => m_Wrapper.m_Player_Vertical;
        public InputAction @TopLight => m_Wrapper.m_Player_TopLight;
        public InputAction @BottomLight => m_Wrapper.m_Player_BottomLight;
        public InputAction @LeftLight => m_Wrapper.m_Player_LeftLight;
        public InputAction @RightLight => m_Wrapper.m_Player_RightLight;
        public InputAction @respawn => m_Wrapper.m_Player_respawn;
        public InputAction @toggleMap => m_Wrapper.m_Player_toggleMap;
        public InputAction @q_low => m_Wrapper.m_Player_q_low;
        public InputAction @q_normal => m_Wrapper.m_Player_q_normal;
        public InputAction @q_ultra => m_Wrapper.m_Player_q_ultra;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Shoot.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
                @Horizontal.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHorizontal;
                @Horizontal.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHorizontal;
                @Horizontal.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHorizontal;
                @Vertical.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnVertical;
                @Vertical.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnVertical;
                @Vertical.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnVertical;
                @TopLight.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTopLight;
                @TopLight.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTopLight;
                @TopLight.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTopLight;
                @BottomLight.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBottomLight;
                @BottomLight.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBottomLight;
                @BottomLight.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBottomLight;
                @LeftLight.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeftLight;
                @LeftLight.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeftLight;
                @LeftLight.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeftLight;
                @RightLight.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRightLight;
                @RightLight.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRightLight;
                @RightLight.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRightLight;
                @respawn.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRespawn;
                @respawn.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRespawn;
                @respawn.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRespawn;
                @toggleMap.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnToggleMap;
                @toggleMap.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnToggleMap;
                @toggleMap.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnToggleMap;
                @q_low.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnQ_low;
                @q_low.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnQ_low;
                @q_low.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnQ_low;
                @q_normal.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnQ_normal;
                @q_normal.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnQ_normal;
                @q_normal.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnQ_normal;
                @q_ultra.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnQ_ultra;
                @q_ultra.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnQ_ultra;
                @q_ultra.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnQ_ultra;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @Horizontal.started += instance.OnHorizontal;
                @Horizontal.performed += instance.OnHorizontal;
                @Horizontal.canceled += instance.OnHorizontal;
                @Vertical.started += instance.OnVertical;
                @Vertical.performed += instance.OnVertical;
                @Vertical.canceled += instance.OnVertical;
                @TopLight.started += instance.OnTopLight;
                @TopLight.performed += instance.OnTopLight;
                @TopLight.canceled += instance.OnTopLight;
                @BottomLight.started += instance.OnBottomLight;
                @BottomLight.performed += instance.OnBottomLight;
                @BottomLight.canceled += instance.OnBottomLight;
                @LeftLight.started += instance.OnLeftLight;
                @LeftLight.performed += instance.OnLeftLight;
                @LeftLight.canceled += instance.OnLeftLight;
                @RightLight.started += instance.OnRightLight;
                @RightLight.performed += instance.OnRightLight;
                @RightLight.canceled += instance.OnRightLight;
                @respawn.started += instance.OnRespawn;
                @respawn.performed += instance.OnRespawn;
                @respawn.canceled += instance.OnRespawn;
                @toggleMap.started += instance.OnToggleMap;
                @toggleMap.performed += instance.OnToggleMap;
                @toggleMap.canceled += instance.OnToggleMap;
                @q_low.started += instance.OnQ_low;
                @q_low.performed += instance.OnQ_low;
                @q_low.canceled += instance.OnQ_low;
                @q_normal.started += instance.OnQ_normal;
                @q_normal.performed += instance.OnQ_normal;
                @q_normal.canceled += instance.OnQ_normal;
                @q_ultra.started += instance.OnQ_ultra;
                @q_ultra.performed += instance.OnQ_ultra;
                @q_ultra.canceled += instance.OnQ_ultra;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnShoot(InputAction.CallbackContext context);
        void OnHorizontal(InputAction.CallbackContext context);
        void OnVertical(InputAction.CallbackContext context);
        void OnTopLight(InputAction.CallbackContext context);
        void OnBottomLight(InputAction.CallbackContext context);
        void OnLeftLight(InputAction.CallbackContext context);
        void OnRightLight(InputAction.CallbackContext context);
        void OnRespawn(InputAction.CallbackContext context);
        void OnToggleMap(InputAction.CallbackContext context);
        void OnQ_low(InputAction.CallbackContext context);
        void OnQ_normal(InputAction.CallbackContext context);
        void OnQ_ultra(InputAction.CallbackContext context);
    }
}
