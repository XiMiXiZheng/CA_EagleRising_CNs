using HarmonyLib;
using TaleWorlds.CampaignSystem.Settlements.Buildings;
using TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.TownManagement;
using TaleWorlds.Localization;

namespace CA_EagleRising_CNs
{
    [HarmonyPatch(typeof(SettlementProjectVM), "Building", MethodType.Setter)]
    public class InfrastructureNameNamePatch
    {
        public static void Postfix(Building value, SettlementProjectVM __instance)
        {
            if (__instance.Building.BuildingType == DefaultBuildingTypes.BuildHouseDaily)
            {
                __instance.Name = new TextObject("{=N2fXW1Kv}Urban Infrastructure").ToString();
                __instance.Explanation = new TextObject("{=T2bxWTHf}Residential districts, warehouses, hospitals, sewers, public baths.  Counteracts the effects of overcrowding from high prosperity and increase granary storage size.").ToString();
            }
            else if (__instance.Building.BuildingType == DefaultBuildingTypes.FestivalsAndGamesDaily)
            {
                __instance.Name = new TextObject("{=KvhxTFzv}Civil Infrastructure").ToString();
                __instance.Explanation = new TextObject("{=HWzAPlhF}Courts, temples, public building and sort of other facilities related to the running of the state.  Generates settlement loyalty and influence for the clan that owns the town.").ToString();
            }

            if (__instance.Building.BuildingType == DefaultBuildingTypes.IrrigationDaily)
            {
                __instance.Name = new TextObject("{=L6mPPFGx}Rural Infrastructure").ToString();
                __instance.Explanation = new TextObject("{=hu0grwZH}Irrigation projects, country roads, land clearance projects.  Generates food for settlement and hearth growth in bound villages.").ToString();
            }

            if (__instance.Building.BuildingType == DefaultBuildingTypes.TrainMilitiaDaily)
            {
                __instance.Name = new TextObject("{=LEGu1Nh2}Military Infrastructure").ToString();
                __instance.Explanation = new TextObject("{=5Ez2TILC}Arourmies, outposts, training grounds and barracks.  Increases the garrison size of the settlement and training rate of militia.").ToString();
            }
        }
    }
}