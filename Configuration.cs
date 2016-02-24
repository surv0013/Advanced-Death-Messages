using Rocket.API;

namespace AdvancedDeathMessages
{
    public class Configuration : IRocketPluginConfiguration
    {
        public bool Enabled = true;

        public bool ShowErrorMessages = true;
        public bool ShowSuicideMessages = true;
        public bool ShowHeadshotMessages = true;

        public string DeathMessagesColor;

        public void LoadDefaults()
        {
            DeathMessagesColor = "Red";
        }
    }
}