﻿using ServiceFabric.Watchdog.RuleEngine.Model;
using System.Fabric;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace ServiceFabric.Watchdog.RuleEngine.Actions
{
    [DataContract]
    public class ServiceMoveCostMediumRuleAction : ServiceMoveCostRuleAction
    {
        public override Task Execute(TriggerItem triggerItem)
        {
            TargetMoveCost = MoveCost.Medium;
            return base.Execute(triggerItem);
        }
    }
}
