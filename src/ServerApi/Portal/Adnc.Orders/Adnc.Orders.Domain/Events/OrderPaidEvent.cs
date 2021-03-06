﻿using Adnc.Infr.EventBus;

namespace Adnc.Orders.Domain.Events
{
    /// <summary>
    /// 订单支付事件
    /// </summary>
    public sealed class OrderPaidEvent : BaseEvent<OrderPaidEvent.EventData>
    {
        public OrderPaidEvent(long id, EventData eventData, string eventSource)
            : base(id, eventData, eventSource)
        {
        }

        public class EventData
        {
            public long OrderId { get; set; }
            public decimal Amount { get; set; }
        }
    }
}
