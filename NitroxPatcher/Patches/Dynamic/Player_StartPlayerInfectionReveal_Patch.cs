using NitroxClient.GameLogic;
using NitroxClient.MonoBehaviours;
using NitroxModel.Helper;
using System.Reflection;

namespace NitroxPatcher.Patches.Dynamic;

public sealed partial class Player_StartPlayerInfectionReveal_Patch : NitroxPatch, IDynamicPatch
{
    private static readonly MethodInfo TARGET_METHOD = Reflect.Method((Player p) => p.StartPlayerInfectionReveal());

    public static void Prefix()
    {
        Resolve<LocalPlayer>().AnimationChange(AnimChangeType.INFECTED, AnimChangeState.ON);
    }
}
