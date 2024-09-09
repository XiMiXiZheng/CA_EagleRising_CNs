using HarmonyLib;
using TaleWorlds.CampaignSystem.Settlements.Buildings;
using TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.TownManagement;
using TaleWorlds.Localization;

namespace CA_EagleRising_CNs
{
    [HarmonyPatch(typeof(SettlementDailyProjectVM), "RefreshProductionText")]
    internal class InfrastructureLevelPatch
    {
        public static void Postfix(SettlementDailyProjectVM __instance)
        {
            var ProductionText = __instance.ProductionText;

            ProductionText = ProductionText.Replace("Current Level", new TextObject("{=uS36UvYz}").ToString());
            ProductionText = ProductionText.Replace("Completion", new TextObject("{=WXAJKNsb}").ToString());
            ProductionText = ProductionText.Replace("days", new TextObject("{=cwsQBtoA}").ToString());
            
            __instance.ProductionText = ProductionText;
        }
    }
}
