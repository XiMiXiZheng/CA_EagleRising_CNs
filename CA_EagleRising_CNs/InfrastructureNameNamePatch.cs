using HarmonyLib;
using TaleWorlds.CampaignSystem.Settlements.Buildings;
using TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.TownManagement;
using TaleWorlds.Localization;

namespace CA_EagleRising_CNs
{
    [HarmonyPatch(/*Could not decode attribute arguments.*/)]
    public class InfrastructureNameNamePatch
    {
        public static void Postfix(Building value, SettlementProjectVM __instance)
        {
            //SettlementInfrastructureData settlementInfrastructureData = SettlementInfrastructureBehavior.getSettlementInfrastructureData(Settlement.CurrentSettlement);
            //TextObject textObject = new TextObject("{=tAwRIPiy}Construction Cost: {COST}");
            if (__instance.Building.BuildingType == DefaultBuildingTypes.BuildHouseDaily)
            {
                __instance.Name = new TextObject("撒旦发射点发射点Urban Infrastructure").ToString();
                __instance.Explanation = new TextObject("Residential districts, warehouses, hospitals, sewers, public baths.  Counteracts the effects of overcrowding from high prosperity and increase granary storage size.").ToString();
                //textObject.SetTextVariable("COST", settlementInfrastructureData.UpgradeCost(SettlementInfrastructureData.InfrastructureType.urban));
                //__instance.ProductionCostText = ((value != null) ? textObject.ToString() : "");
            }
            else if (__instance.Building.BuildingType == DefaultBuildingTypes.FestivalsAndGamesDaily)
            {
                __instance.Name = new TextObject("Civil Infrastructure").ToString();
                __instance.Explanation = new TextObject("Courts, temples, public building and sort of other facilities related to the running of the state.  Generates settlement loyalty and influence for the clan that owns the town.").ToString();
                //textObject.SetTextVariable("COST", settlementInfrastructureData.UpgradeCost(SettlementInfrastructureData.InfrastructureType.admin));
                //__instance.ProductionCostText = ((value != null) ? textObject.ToString() : "");
            }

            if (__instance.Building.BuildingType == DefaultBuildingTypes.IrrigationDaily)
            {
                __instance.Name = new TextObject("Rural Infrastructure").ToString();
                __instance.Explanation = new TextObject("Irrigation projects, country roads, land clearance projects.  Generates food for settlement and hearth growth in bound villages.").ToString();
                //textObject.SetTextVariable("COST", settlementInfrastructureData.UpgradeCost(SettlementInfrastructureData.InfrastructureType.rural));
                //__instance.ProductionCostText = ((value != null) ? textObject.ToString() : "");
            }

            if (__instance.Building.BuildingType == DefaultBuildingTypes.TrainMilitiaDaily)
            {
                __instance.Name = new TextObject("Military Infrastructure").ToString();
                __instance.Explanation = new TextObject("Arourmies, outposts, training grounds and barracks.  Increases the garrison size of the settlement and training rate of militia.").ToString();
                //textObject.SetTextVariable("COST", settlementInfrastructureData.UpgradeCost(SettlementInfrastructureData.InfrastructureType.military));
                //__instance.ProductionCostText = ((value != null) ? textObject.ToString() : "");
            }
        }
    }
}