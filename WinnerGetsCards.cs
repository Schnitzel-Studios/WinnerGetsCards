using BepInEx;

namespace WinnerGetsCards
{
    [BepInPlugin("com.schnitzelreaper.rounds.WinnerGetsCards", "WinnerGetsCards", "1.0.0")]
    [BepInDependency("com.willis.rounds.unbound", BepInDependency.DependencyFlags.HardDependency)]

    public class WinnerGetsCards : BaseUnityPlugin
    {
        private const string ModId = "ot.dan.rounds.PlayerMarkers";
        private const string ModName = "Player Markers";
        public const string Version = "1.1.1";
        public const string ModInitials = "PM";
        private const string CompatibilityModName = "PlayerMarkers";
        public static PlayerMarkers instance { get; private set; }

        private void Awake()
        {
            // Plugin startup logic
            Logger.LogInfo($"Plugin com.schnitzelreaper.rounds.WinnerGetsCards is loaded!");
        }
    }
}
