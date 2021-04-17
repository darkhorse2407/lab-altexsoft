using System;
using System.Linq;
using System.Collections.Generic;

namespace HomeWork1
{
    public class HomeWork
    {

        private decimal GetFullPrice(
                                    IEnumerable<string> destinations,
                                    IEnumerable<string> clients,
                                    IEnumerable<int> infantsIds,
                                    IEnumerable<int> childrenIds,
                                    IEnumerable<decimal> prices,
                                    IEnumerable<string> currencies)
        {
            decimal fullPrice = default;
            double discount = default;
            string previousDestination = default;
            string currentDestination = default;
            decimal rateEUR = 1.20m;

            if (!(CheckInput(destinations, clients, prices, currencies)))
                return default;

            for (int i = 0; i < clients.Count(); i++)
            {
                destinations.GetEnumerator().MoveNext();
                clients.GetEnumerator().MoveNext();
                prices.GetEnumerator().MoveNext();
                currencies.GetEnumerator().MoveNext();

                previousDestination = currentDestination;
                currentDestination = destinations.GetEnumerator().Current;

                decimal orderPrice = prices.GetEnumerator().Current;

                if (currencies.GetEnumerator().Current == "EUR")
                {
                    orderPrice = EURtoUSD(prices.GetEnumerator().Current, rateEUR);
                }

                if (destinations.GetEnumerator().Current.Contains("Wayne Street")){
                    orderPrice += 10;
                }
                else if(destinations.GetEnumerator().Current.Contains("North Heather Street")){
                    orderPrice -= 5.36m;
                }

                if(CheckInfant(infantsIds, i))
                {
                    discount += 0.5;
                }
                else if(CheckChildren(childrenIds, i))
                {
                    discount += 0.25;
                }

                if(previousDestination == currentDestination)
                {
                    discount += 0.15;
                }

                orderPrice = orderPrice * (decimal)discount;
                fullPrice += orderPrice;
            }

            return fullPrice;
        }


        private bool CheckInfant(IEnumerable<int> infantsIds, int i)
        {
            bool result = default;
            foreach (int infant in infantsIds)
            {
                if (i == infant)
                    result = true;
                else
                    result = false;
            }

            return result;
        }

        private bool CheckChildren(IEnumerable<int> childrenIds, int i)
        {
            bool result = default;
            foreach (int infant in childrenIds)
            {
                if (i == infant)
                    result = true;
                else
                    result = false;
            }

            return result;
        }

        private decimal EURtoUSD(decimal price, decimal rate)
        {
            decimal USDprice = default;

            USDprice = price * rate;

            return USDprice;
        }

        private string GetStreet(string destination)
        {
            string[] destinationArr = destination.Split(',');
            List<string> address = new List<string>();
            string dest = default;

            address = destinationArr[0].Split(' ').ToList<string>();

            dest = string.Join(' ', address.Skip(1));

            return dest;
        }

        private bool CheckInput(IEnumerable<string> destinations, IEnumerable<string> clients,
            IEnumerable<decimal> prices, IEnumerable<string> currencies)
        {
            bool result;
            if (destinations.Count() == clients.Count() && destinations.Count() == prices.Count() &&
                destinations.Count() == currencies.Count())
                result = true;
            else
                result = false;
            return result;
        }

        public decimal InvokePriceCalculatiion()
        {
            var destinations = new[]
            {
                "949 Fairfield Court, Madison Heights, MI 48071",
                "367 Wayne Street, Hendersonville, NC 28792",
                "910 North Heather Street, Cocoa, FL 32927",
                "911 North Heather Street, Cocoa, FL 32927",
                "706 Tarkiln Hill Ave, Middleburg, FL 32068",
            };

            var clients = new[]
            {
                "Autumn Baldwin",
                "Jorge Hoffman",
                "Amiah Simmons",
                "Sariah Bennett",
                "Xavier Bowers",
            };

            var infantsIds = new[] { 2 };
            var childrenIds = new[] { 3, 4 };

            var prices = new[] { 100, 25.23m, 58, 23.12m, 125 };
            var currencies = new[] { "USD", "USD", "EUR", "USD", "USD" };

            return GetFullPrice(destinations, clients, infantsIds, childrenIds, prices, currencies);
        }
    }
}