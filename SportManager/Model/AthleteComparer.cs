using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace SportManager.Model
{
    class AthleteComparer : IComparer<Athlete>

    {
        public AthleteOrderType OrderType { get; set; }

        public AthleteComparer(AthleteOrderType orderType)
        {
            OrderType = orderType;
        }

        public int Compare([AllowNull] Athlete a1, [AllowNull] Athlete a2)
        {
            switch (OrderType)
            {
                case AthleteOrderType.Name:
                    return a1.Name.CompareTo(a2.Name);
                case AthleteOrderType.Surname:
                    return a1.Surname.CompareTo(a2.Surname);
                case AthleteOrderType.Subscription:
                    return a1.SubscriptionDate.CompareTo(a2.SubscriptionDate);
                case AthleteOrderType.Weight:
                    return a1.Weight.CompareTo(a2.Weight);
                default:
                    return a1.Name.CompareTo(a2.Name);
            }

           
        }
    }

    enum AthleteOrderType:int
    {
        Name = 1, Surname = 2, Subscription = 3, Weight = 4
    }
}
