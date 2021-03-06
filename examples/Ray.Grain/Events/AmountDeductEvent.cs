﻿using ProtoBuf;
using Ray.Core.Event;

namespace Ray.Grain.Events
{
    [ProtoContract(ImplicitFields = ImplicitFields.AllFields)]
    public class AmountDeductEvent : IEvent
    {
        public decimal Amount { get; set; }
        public decimal Balance { get; set; }
        public AmountDeductEvent() { }
        public AmountDeductEvent(decimal amount, decimal balance)
        {
            Amount = amount;
            Balance = balance;
        }
    }
}
