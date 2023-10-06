using HarmonyLib;

namespace CtrekozsMusicPack
{
    public static class PInfo
    {
        // each loaded plugin needs to have a unique GUID. usually author+generalCategory+Name is good enough
        public const string GUID = "intoxicatedkid.ctrekozsmusicpack";
        public const string Name = "Ctrekoz's Music Pack";
        public const string version = "0.5.0";
        public static readonly Harmony harmony = new Harmony(GUID);

    }
}
