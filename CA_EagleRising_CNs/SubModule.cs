using System.Collections.Generic;
using TaleWorlds.Library;
using TaleWorlds.Localization;
using TaleWorlds.MountAndBlade;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;
using TaleWorlds.ObjectSystem;
using HarmonyLib;

namespace CA_EagleRising_CNs
{
    public class SubModule : MBSubModuleBase
    {
        protected override void OnSubModuleLoad()
        {
            base.OnSubModuleLoad();
            var harmony = new Harmony("CA_EagleRising_CNs");
            harmony.PatchAll();
        }

        protected override void OnSubModuleUnloaded()
        {
            base.OnSubModuleUnloaded();
        }

        protected override void OnBeforeInitialModuleScreenSetAsRoot()
        {
            base.OnBeforeInitialModuleScreenSetAsRoot();
            InformationManager.DisplayMessage(new InformationMessage(((object)new TextObject("{=!}CA鹰之崛起汉化加载成功", (Dictionary<string, object>)null)).ToString(), Colors.Green));
        }

        protected override void OnGameStart(Game game, IGameStarter gameStarterObject)
        {
            //if (game.GameType is Campaign) 
            //{
            //    var allPolicies = MBObjectManager.Instance.GetObjectTypeList<PolicyObject>();

            //    allPolicies.ForEach(policyObject => {
            //        switch (policyObject.StringId)
            //        {
            //            case "_publicLandCommissions":
            //                policyObject.Initialize(new TextObject("{=EvPsmObX}Adaptive Pantheon"),
            //                    new TextObject("{=d80c80x4}Gods of conquered subjects are integrated into the kingdom's pantheon."),
            //                    new TextObject("{=IQbsX6NP}incorporating foreign gods into their Pantheon"),
            //                    new TextObject("{=hqNP3eVq}+1 loyalty in settlements where the settlement's culture is differenet than the clan owner's culture\n-2 Influence in settlements where the settlement's culture is differenet than the clan owner's culture"),
            //                    -0.4f, 0.4f, 0.4f);
            //                break;
            //            case "_adaptivePantheon":
            //                policyObject.Initialize(new TextObject("{=EvPsmObX}Adaptive Pantheon"), 
            //                    new TextObject("{=d80c80x4}Gods of conquered subjects are integrated into the kingdom's pantheon."), 
            //                    new TextObject("{=IQbsX6NP}incorporating foreign gods into their Pantheon"), 
            //                    new TextObject("{=hqNP3eVq}+1 loyalty in settlements where the settlement's culture is differenet than the clan owner's culture\n-2 Influence in settlements where the settlement's culture is differenet than the clan owner's culture"),
            //                    -0.4f, 0.4f, 0.4f);
            //                break;
            //            case "_privateTaxCollectors":
            //                policyObject.Initialize(new TextObject("{=yaEzBNBa}Private Tax Collectors"),
            //                    new TextObject("{=z1vo2gnr}Tax farming contracts are auctioned off by the state to private induvials.  Although tax collectors provide direct and immediate funds for the state, their method in extorting excessive amounts of money makes them unpopular with the locals"),
            //                    new TextObject("{=3BlrFOHG}start auctioning tax collection rights"),
            //                    new TextObject("{=BiNDpyLY}+15% taxes in towns and castles\n-2 loyalty in towns and castles"),
            //                    -0.4f, 0.4f, 0.4f);
            //                break;
            //            case "_penalLabor":
            //                policyObject.Initialize(new TextObject("{=dcJ56OiA}Penal Labor"), 
            //                    new TextObject("{=IvTDs065}Those unable to pay their ransoms or debts are used as labor by the state until their debts are repaid"), 
            //                    new TextObject("{=cvTm0kTN}using criminal and debtors for labor"), 
            //                    new TextObject("{=4hk6b69m}Each prisoner in a town or castles's dungeon will generate 0.25 construction progress and -0.01 security.\nOn average it takes about a year for prisoners to earn enough to ransom themselves"),
            //                    -0.4f, 0.4f, 0.4f);
            //                break;
            //            case "_miltaryWorkforce":
            //                policyObject.Initialize(new TextObject("{=zpGNlZFy}Military Workforce"),
            //                    new TextObject("{=74Wl2cgq}When soldiers aren't busy on campaign, they will instead be used be used for building and infrastructure progress"),
            //                    new TextObject("{=LuYF4EEA}using soldiers for construction projects"),
            //                    new TextObject("{=fapbpQS0}Settlement garrisons and lord's parties in a castle or town owned by their clan will generate 0.15 construction progress per day per party size.\nTroop wages are increased 10%"),
            //                    -0.4f, 0.4f, 0.4f);
            //                break;
            //            case "_stoneMasonGuild":
            //                policyObject.Initialize(new TextObject("{=Ssre9Hzs}Stone Mason Guild"),
            //                    new TextObject("{=BppY9mfS}The state will grant special rights and priveleges to the stone mason guild"),
            //                    new TextObject("{=8bcT4SZc}granting special rights and priveleges to the stone mason guild"),
            //                    new TextObject("{=VfB2gCwC}Boosting settlement projects is 25% more effective\nThe cost of boosting settlement projects increased by 30%"),
            //                    -0.4f, 0.4f, 0.4f);
            //                break;
            //            case "_standingArmies":
            //                policyObject.Initialize(new TextObject("{=3EJc6Xnk}Standing Armies"),
            //                    new TextObject("{=xZsMBMhZ}Proffesional career soldiers will replace the seasonal levies and form permanant armies."),
            //                    new TextObject("{=3myVdW73}reoganizing their levies into standing armies"),
            //                    new TextObject("{=1d3NWQib}Every non-mercenary clan get +2 party slots and the faction leader's clan get +4 party slots\nTroop wages are increased by 15%"),
            //                    -0.4f, 0.4f, 0.4f);
            //                break;
            //            case "_grainDole":
            //                policyObject.Initialize(new TextObject("{=3LU7g9a6}Grain Dole"),
            //                    new TextObject("{=l1Yf1qbr}The state stockpiles grain and sells it at a reduced rate to the poorest citizens"),
            //                    new TextObject("{=VRMLo4Lp}subsidizing grain purchases for poor citizens"),
            //                    new TextObject("{=LMUODbwg}+ 1 loyalty in all towns and castles\n+ 2 food for every 1000 settlement prosperity\nthe cost of this program is 50 for every 1000 settlement prosperity"),
            //                    -0.4f, 0.4f, 0.4f);
            //                break;
            //            case "_patronage":
            //                policyObject.Initialize(new TextObject("{=Unhm0Vr5}Patronage"),
            //                    new TextObject("{=5GpH7IeV}A hierarchical mutually beneficial system, where the patron normally provide his clients with material and financial support and the clients repays patron with political support or work to boost the prestige of their patron."),
            //                    new TextObject("{=l0WhoXHE}adaopting a patron-client system"),
            //                    new TextObject("{=cYlDQyir}Kingdom leaders pay 200 gold to each vassal, while vassals pay 1 influence to the leader every day\nSettlement owners pay 10 gold each day to every notables.  Settlement owners earns 0.05 influence per notable and notables earn 0.1 power per day\nWill result in relations improving over time"),
            //                    -0.4f, 0.4f, 0.4f);
            //                break;
            //            default:
            //                break;
            //        }
            //    });
            //}
        }
    }
}
