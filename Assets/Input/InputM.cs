// GENERATED AUTOMATICALLY FROM 'Assets/Input/InputM.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputM : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputM()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputM"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""67167b65-f1a4-440a-acbb-c888b346cf74"",
            ""actions"": [
                {
                    ""name"": ""Atirar"",
                    ""type"": ""Button"",
                    ""id"": ""dc7d7311-e87c-4071-a4ba-4bf64192412e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Horizontal"",
                    ""type"": ""Value"",
                    ""id"": ""4aa9f8a2-a2dd-493d-b3d9-720e9f71c485"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Vertical"",
                    ""type"": ""Value"",
                    ""id"": ""010ab5a7-78c2-4941-acb6-4b444d27e4cb"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Agachar"",
                    ""type"": ""Button"",
                    ""id"": ""2d6e6c32-8ed4-4a23-a565-499b413880e2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MouseX"",
                    ""type"": ""Value"",
                    ""id"": ""b8d3e421-5d05-45ab-a56b-980cfe1a3087"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MouseY"",
                    ""type"": ""Value"",
                    ""id"": ""124834f3-7196-45ba-8df8-6464c95f731e"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Moeda"",
                    ""type"": ""Button"",
                    ""id"": ""6b682172-2cb5-48f7-a73b-cd884c0820fb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TrocaArmaGamepad"",
                    ""type"": ""Button"",
                    ""id"": ""575f7551-8425-42c5-9feb-eacc709179c8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interacao"",
                    ""type"": ""Button"",
                    ""id"": ""8f0655cc-b063-4312-83e5-55d7f05fde3e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MarcarInimigos"",
                    ""type"": ""Button"",
                    ""id"": ""ed466ada-8dd9-40f5-b9f3-c64393d4645d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TrocaArmaKeyboard"",
                    ""type"": ""Value"",
                    ""id"": ""065fd156-29d3-4676-950a-eb2e782b25f7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Correr"",
                    ""type"": ""Value"",
                    ""id"": ""f84a34d3-a152-4229-8318-d327069af915"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold""
                },
                {
                    ""name"": ""Cheat"",
                    ""type"": ""Button"",
                    ""id"": ""9b72c776-a06e-426c-9678-677310bffd30"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5b2e5cba-fe23-47f1-a80f-b8761e54fe17"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Atirar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""50e93dcc-b377-4021-8729-36ff2f713603"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Atirar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""arrowHorizontal"",
                    ""id"": ""121456e6-af21-4c98-9ce5-12f54176c7b6"",
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
                    ""id"": ""956d722a-4340-4608-9240-b38d2c7c1897"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""62d8bfab-a29b-4380-9311-c17743f20b96"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""arrowHorizontal"",
                    ""id"": ""efd57a9a-765d-4793-95d6-a6609094b697"",
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
                    ""id"": ""1641f276-4a61-46a2-a3ee-0e060f0c13a0"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""220c7f64-7b1f-4baa-910e-ba50cc9b07f9"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""controllerHorizontal"",
                    ""id"": ""4462899c-7080-45b3-ad00-e72eff6f7eb6"",
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
                    ""id"": ""1929fd98-835d-4715-943d-df3cfbfb5bfc"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""3238593d-bafb-4070-91f0-a3236abd474b"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""controllerVertical"",
                    ""id"": ""fae5167b-695b-4511-a7f4-42e94cf5b943"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""c75296bd-39e6-4c2f-8c9c-e8327ef52f55"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""95e994c5-917c-43d7-ab5a-d690da0c4928"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""arrowVertical"",
                    ""id"": ""225249da-f1a9-4eae-8ae0-0ba7cd770e6e"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""b977087d-7f33-4938-8f90-12ad3fbc8366"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""cef39ede-c9f9-4a04-ab95-337d4154a56c"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""arrowVertical"",
                    ""id"": ""f3eeb5a1-2737-4319-920a-5667fa21b4c2"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""04d98b40-9fb8-42c9-8555-116de5eb2709"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""f0c836aa-bdf6-442b-8bb7-f81c93a9cd46"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""8b8cd8b5-906a-4408-b5e7-4fef5616de23"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Agachar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""de0c7a09-d9b3-49d5-aa25-611bbc16baa4"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Agachar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""ControleX"",
                    ""id"": ""d9e26529-b20c-4933-a16c-17a0c7bc4147"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseX"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""86705933-11b1-42e0-8a1a-7bbc7db07702"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""MouseX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""41f6ce42-3704-46a0-a4ff-75d4488dc01a"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""MouseX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""1f833984-13b6-4f17-aff0-275bad2d7db3"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""MouseX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""ControleY"",
                    ""id"": ""c3b2f547-7edb-4323-ab24-250ccb9d86c3"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseY"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""321b2473-54ea-42fb-9aab-a58b534371d9"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""MouseY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""6852be6a-143f-4b65-a612-1abac5e87d3b"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""MouseY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""86144455-bfe4-48d5-bd4f-0a970e87404e"",
                    ""path"": ""<Mouse>/delta/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""MouseY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""582e4876-2ad3-4666-80e7-aa24f69e540b"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Moeda"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f0092b13-f5ef-46d4-8091-53473f3e4f89"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Moeda"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f6706d04-52c0-4e02-86f5-6c2336a05f99"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""TrocaArmaGamepad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4ce7f416-75ef-4987-856e-75fc2f666326"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Interacao"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6a5514f8-c0a2-4866-a0ce-febf1c9280cd"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Interacao"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""26c47b36-c4af-43f9-82df-ac24186af3a8"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""MarcarInimigos"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bb868e44-1725-432e-8a7f-23c12939b1dd"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""MarcarInimigos"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""ArmasKeyboard"",
                    ""id"": ""ea2e3ccc-310e-4696-84e8-f4655f0fe298"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TrocaArmaKeyboard"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""26c43b49-6dd0-40fd-b8fe-9510acc28c66"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""TrocaArmaKeyboard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""96831e41-166c-4b44-a84f-919bc811c39a"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""TrocaArmaKeyboard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""d29cd99c-7635-4294-9a53-d62f7b2ffc81"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Correr"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""90170cf7-1f8e-4946-9213-e7af17ba50ee"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Correr"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8b76a0a2-c5e8-4556-b7f7-d3d8c971757c"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": ""Tap"",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Cheat"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""88028b64-1850-4435-b0dd-581e285f6715"",
            ""actions"": [
                {
                    ""name"": ""Mapa"",
                    ""type"": ""Value"",
                    ""id"": ""df7fb8d7-41ff-4b99-ae35-94620f6b133e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""8559cf3b-2ad4-4d69-b008-b0bf9235a6c3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""99a4d4cf-2e42-455a-a6f7-fec11b0d0223"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3d9ff38c-dbca-4a10-aace-e6b794c63b63"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9468f5e6-f075-4f89-ae94-be02e1c105ad"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Mapa"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""91d6119f-cda8-407c-8f90-22e06b78043b"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Mapa"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard and mouse"",
            ""bindingGroup"": ""Keyboard and mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Atirar = m_Player.FindAction("Atirar", throwIfNotFound: true);
        m_Player_Horizontal = m_Player.FindAction("Horizontal", throwIfNotFound: true);
        m_Player_Vertical = m_Player.FindAction("Vertical", throwIfNotFound: true);
        m_Player_Agachar = m_Player.FindAction("Agachar", throwIfNotFound: true);
        m_Player_MouseX = m_Player.FindAction("MouseX", throwIfNotFound: true);
        m_Player_MouseY = m_Player.FindAction("MouseY", throwIfNotFound: true);
        m_Player_Moeda = m_Player.FindAction("Moeda", throwIfNotFound: true);
        m_Player_TrocaArmaGamepad = m_Player.FindAction("TrocaArmaGamepad", throwIfNotFound: true);
        m_Player_Interacao = m_Player.FindAction("Interacao", throwIfNotFound: true);
        m_Player_MarcarInimigos = m_Player.FindAction("MarcarInimigos", throwIfNotFound: true);
        m_Player_TrocaArmaKeyboard = m_Player.FindAction("TrocaArmaKeyboard", throwIfNotFound: true);
        m_Player_Correr = m_Player.FindAction("Correr", throwIfNotFound: true);
        m_Player_Cheat = m_Player.FindAction("Cheat", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_Mapa = m_UI.FindAction("Mapa", throwIfNotFound: true);
        m_UI_Pause = m_UI.FindAction("Pause", throwIfNotFound: true);
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
    private readonly InputAction m_Player_Atirar;
    private readonly InputAction m_Player_Horizontal;
    private readonly InputAction m_Player_Vertical;
    private readonly InputAction m_Player_Agachar;
    private readonly InputAction m_Player_MouseX;
    private readonly InputAction m_Player_MouseY;
    private readonly InputAction m_Player_Moeda;
    private readonly InputAction m_Player_TrocaArmaGamepad;
    private readonly InputAction m_Player_Interacao;
    private readonly InputAction m_Player_MarcarInimigos;
    private readonly InputAction m_Player_TrocaArmaKeyboard;
    private readonly InputAction m_Player_Correr;
    private readonly InputAction m_Player_Cheat;
    public struct PlayerActions
    {
        private @InputM m_Wrapper;
        public PlayerActions(@InputM wrapper) { m_Wrapper = wrapper; }
        public InputAction @Atirar => m_Wrapper.m_Player_Atirar;
        public InputAction @Horizontal => m_Wrapper.m_Player_Horizontal;
        public InputAction @Vertical => m_Wrapper.m_Player_Vertical;
        public InputAction @Agachar => m_Wrapper.m_Player_Agachar;
        public InputAction @MouseX => m_Wrapper.m_Player_MouseX;
        public InputAction @MouseY => m_Wrapper.m_Player_MouseY;
        public InputAction @Moeda => m_Wrapper.m_Player_Moeda;
        public InputAction @TrocaArmaGamepad => m_Wrapper.m_Player_TrocaArmaGamepad;
        public InputAction @Interacao => m_Wrapper.m_Player_Interacao;
        public InputAction @MarcarInimigos => m_Wrapper.m_Player_MarcarInimigos;
        public InputAction @TrocaArmaKeyboard => m_Wrapper.m_Player_TrocaArmaKeyboard;
        public InputAction @Correr => m_Wrapper.m_Player_Correr;
        public InputAction @Cheat => m_Wrapper.m_Player_Cheat;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Atirar.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAtirar;
                @Atirar.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAtirar;
                @Atirar.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAtirar;
                @Horizontal.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHorizontal;
                @Horizontal.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHorizontal;
                @Horizontal.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHorizontal;
                @Vertical.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnVertical;
                @Vertical.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnVertical;
                @Vertical.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnVertical;
                @Agachar.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAgachar;
                @Agachar.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAgachar;
                @Agachar.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAgachar;
                @MouseX.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMouseX;
                @MouseX.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMouseX;
                @MouseX.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMouseX;
                @MouseY.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMouseY;
                @MouseY.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMouseY;
                @MouseY.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMouseY;
                @Moeda.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoeda;
                @Moeda.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoeda;
                @Moeda.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoeda;
                @TrocaArmaGamepad.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTrocaArmaGamepad;
                @TrocaArmaGamepad.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTrocaArmaGamepad;
                @TrocaArmaGamepad.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTrocaArmaGamepad;
                @Interacao.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteracao;
                @Interacao.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteracao;
                @Interacao.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteracao;
                @MarcarInimigos.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMarcarInimigos;
                @MarcarInimigos.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMarcarInimigos;
                @MarcarInimigos.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMarcarInimigos;
                @TrocaArmaKeyboard.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTrocaArmaKeyboard;
                @TrocaArmaKeyboard.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTrocaArmaKeyboard;
                @TrocaArmaKeyboard.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTrocaArmaKeyboard;
                @Correr.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCorrer;
                @Correr.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCorrer;
                @Correr.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCorrer;
                @Cheat.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCheat;
                @Cheat.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCheat;
                @Cheat.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCheat;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Atirar.started += instance.OnAtirar;
                @Atirar.performed += instance.OnAtirar;
                @Atirar.canceled += instance.OnAtirar;
                @Horizontal.started += instance.OnHorizontal;
                @Horizontal.performed += instance.OnHorizontal;
                @Horizontal.canceled += instance.OnHorizontal;
                @Vertical.started += instance.OnVertical;
                @Vertical.performed += instance.OnVertical;
                @Vertical.canceled += instance.OnVertical;
                @Agachar.started += instance.OnAgachar;
                @Agachar.performed += instance.OnAgachar;
                @Agachar.canceled += instance.OnAgachar;
                @MouseX.started += instance.OnMouseX;
                @MouseX.performed += instance.OnMouseX;
                @MouseX.canceled += instance.OnMouseX;
                @MouseY.started += instance.OnMouseY;
                @MouseY.performed += instance.OnMouseY;
                @MouseY.canceled += instance.OnMouseY;
                @Moeda.started += instance.OnMoeda;
                @Moeda.performed += instance.OnMoeda;
                @Moeda.canceled += instance.OnMoeda;
                @TrocaArmaGamepad.started += instance.OnTrocaArmaGamepad;
                @TrocaArmaGamepad.performed += instance.OnTrocaArmaGamepad;
                @TrocaArmaGamepad.canceled += instance.OnTrocaArmaGamepad;
                @Interacao.started += instance.OnInteracao;
                @Interacao.performed += instance.OnInteracao;
                @Interacao.canceled += instance.OnInteracao;
                @MarcarInimigos.started += instance.OnMarcarInimigos;
                @MarcarInimigos.performed += instance.OnMarcarInimigos;
                @MarcarInimigos.canceled += instance.OnMarcarInimigos;
                @TrocaArmaKeyboard.started += instance.OnTrocaArmaKeyboard;
                @TrocaArmaKeyboard.performed += instance.OnTrocaArmaKeyboard;
                @TrocaArmaKeyboard.canceled += instance.OnTrocaArmaKeyboard;
                @Correr.started += instance.OnCorrer;
                @Correr.performed += instance.OnCorrer;
                @Correr.canceled += instance.OnCorrer;
                @Cheat.started += instance.OnCheat;
                @Cheat.performed += instance.OnCheat;
                @Cheat.canceled += instance.OnCheat;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_Mapa;
    private readonly InputAction m_UI_Pause;
    public struct UIActions
    {
        private @InputM m_Wrapper;
        public UIActions(@InputM wrapper) { m_Wrapper = wrapper; }
        public InputAction @Mapa => m_Wrapper.m_UI_Mapa;
        public InputAction @Pause => m_Wrapper.m_UI_Pause;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                @Mapa.started -= m_Wrapper.m_UIActionsCallbackInterface.OnMapa;
                @Mapa.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnMapa;
                @Mapa.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnMapa;
                @Pause.started -= m_Wrapper.m_UIActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnPause;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Mapa.started += instance.OnMapa;
                @Mapa.performed += instance.OnMapa;
                @Mapa.canceled += instance.OnMapa;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
            }
        }
    }
    public UIActions @UI => new UIActions(this);
    private int m_KeyboardandmouseSchemeIndex = -1;
    public InputControlScheme KeyboardandmouseScheme
    {
        get
        {
            if (m_KeyboardandmouseSchemeIndex == -1) m_KeyboardandmouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard and mouse");
            return asset.controlSchemes[m_KeyboardandmouseSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnAtirar(InputAction.CallbackContext context);
        void OnHorizontal(InputAction.CallbackContext context);
        void OnVertical(InputAction.CallbackContext context);
        void OnAgachar(InputAction.CallbackContext context);
        void OnMouseX(InputAction.CallbackContext context);
        void OnMouseY(InputAction.CallbackContext context);
        void OnMoeda(InputAction.CallbackContext context);
        void OnTrocaArmaGamepad(InputAction.CallbackContext context);
        void OnInteracao(InputAction.CallbackContext context);
        void OnMarcarInimigos(InputAction.CallbackContext context);
        void OnTrocaArmaKeyboard(InputAction.CallbackContext context);
        void OnCorrer(InputAction.CallbackContext context);
        void OnCheat(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnMapa(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
    }
}
