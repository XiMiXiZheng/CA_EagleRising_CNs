using HarmonyLib;
using TaleWorlds.CampaignSystem.Settlements.Buildings;
using TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.TownManagement;
using TaleWorlds.Localization;

namespace CA_EagleRising_CNs
{
    [HarmonyPatch(typeof(SettlementProjectVM), "RefreshValues")]
    internal class InfrastructureAffectPatch
    {
        public static void Postfix(SettlementProjectVM __instance)
        {
            var CurrentPositiveEffectText = __instance.CurrentPositiveEffectText;
            if (__instance.Building.BuildingType == DefaultBuildingTypes.BuildHouseDaily)
            {
                CurrentPositiveEffectText = CurrentPositiveEffectText.Replace("food storage and no overcrowding affects while proserity is under",new TextObject("{=WHOFx2CP}").ToString());
            }
            else if (__instance.Building.BuildingType == DefaultBuildingTypes.FestivalsAndGamesDaily)
            {
                CurrentPositiveEffectText = CurrentPositiveEffectText.Replace("loyalty and", new TextObject("{=HG6snjnR}").ToString());
                CurrentPositiveEffectText = CurrentPositiveEffectText.Replace("influence", new TextObject("{=bRsbzYXF}").ToString());
            }
            else if (__instance.Building.BuildingType == DefaultBuildingTypes.IrrigationDaily)
            {
                CurrentPositiveEffectText = CurrentPositiveEffectText.Replace("food production and", new TextObject("{=FTH5eG31}").ToString());
                CurrentPositiveEffectText = CurrentPositiveEffectText.Replace("hearth growth", new TextObject("{=vNTr4vqe}").ToString());
            }
            else 
            {
                CurrentPositiveEffectText = CurrentPositiveEffectText.Replace("garrison and garrison prisoner size,", new TextObject("{=IH7gPNBQ}").ToString());
                CurrentPositiveEffectText = CurrentPositiveEffectText.Replace("militia growth and", new TextObject("{=zbnbXIYQ}").ToString());
                CurrentPositiveEffectText = CurrentPositiveEffectText.Replace("max clan party limit", new TextObject("{=lecVbePL}").ToString());
            }

            __instance.CurrentPositiveEffectText = CurrentPositiveEffectText;
        }
    }
}
