using NitroxClient.GameLogic;
using NitroxClient.MonoBehaviours;
using NitroxModel.Helper;
using System.Reflection;

namespace NitroxPatcher.Patches.Dynamic;

public sealed partial class Player_StartPlayerInfectionCure_Patch : NitroxPatch, IDynamicPatch
{
    private static readonly MethodInfo TARGET_METHOD = Reflect.Method((Player p) => p.StartPlayerInfectionCure());

    public static void Prefix()
    {
        Resolve<LocalPlayer>().AnimationChange(AnimChangeType.INFECTED, AnimChangeState.OFF);
    }
}
