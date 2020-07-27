using System;
using System.Collections.Generic;
using System.Text;
using Centrifuge.Distance.Game;
using Centrifuge.Distance.GUI;
using Reactor.API.Logging;
using Reactor.API.Attributes;
using Reactor.API.Interfaces.Systems;
using UnityEngine;

namespace ExampleNamespace
{
    [ModEntryPoint(ModID)]
    public class Mod : MonoBehaviour
    {
        public const string ModID = "com.github.Tribow/DistanceTest";

        public Log LogSystem { get; set; }

        public void Initialize(IManager manager)
        {
            // This will run after Awake(), unless 
            // specified otherwise in ModEntryPoint
            // attribute property AwakeAfterInitialize.

            LogSystem = LogManager.GetForCurrentAssembly();
            LogSystem.Info("Hello?");
        }

        public void Awake()
        {

        }
    }
}