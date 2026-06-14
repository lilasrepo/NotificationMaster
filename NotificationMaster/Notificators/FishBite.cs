// TODO(api12): FishBite feature added in JP HEAD (commit 2d04427) depends on
// FFXIVClientStructs.FFXIV.Client.Game.Event.FishingState and EventHandlerModule.FishingEventHandler,
// both of which are API15-era / game-7.5-only. Whole module B1-stubbed for the API12/game-7.1 build —
// the Setup method is now a no-op, fish bite notifications will not fire.

namespace NotificationMaster;

public enum FishBiteType : byte
{
    Unknown = 0,
    Light = 36,
    Medium = 37,
    Heavy = 38,
    None = 255,
}

internal class FishBite : IDisposable
{
    public void Dispose() { }

    internal static void ResetToDefaults(NotificationMaster p)
    {
        Notify.Warning("Fish Notify is disabled in this build (API12/game-7.1).");
    }

    internal static void Setup(bool enable, NotificationMaster p)
    {
        if (enable)
        {
            PluginLog.Information("FishBite Setup(enable=true) called — feature is B1-stubbed in this build, no-op");
        }
    }
}
