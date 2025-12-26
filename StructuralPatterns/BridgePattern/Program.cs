using BridgePattern.Abstractions;
using BridgePattern.Implementations;

AdvancedRemoteControl remote = new AdvancedRemoteControl(new TV());

if (!remote.IsEnabled())
{
    remote.TogglePower();
}
remote.VolumeUp();