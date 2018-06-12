﻿using Zenject;

namespace Code
{
    public class LightInstaller : MonoInstaller<LightInstaller>
    {
        public override void InstallBindings()
        {
            Container.DeclareSignal<LightsOutSignal>();

            Container.BindSignal<LightsOutSignal>()
                .ToMethod<LightSwitcher>(x => x.SwitchLight)
                .FromResolve();
//                .FromComponentInHierarchy();
        }
    }
}