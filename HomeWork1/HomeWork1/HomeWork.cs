using System.Collections.Generic;
using System.Linq;

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

            if (!CheckInput(destinations, clients, prices, currencies))
                return default;

            using var clientsEnumerator = clients.GetEnumerator();
            using var destinationsEnumerator = destinations.GetEnumerator();
            using var pricesEnumerator = prices.GetEnumerator();
            using var currenciesEnumerator = currencies.GetEnumerator();

            int i = 0;

            while (clientsEnumerator.MoveNext())
            {
                destinationsEnumerator.MoveNext();
                pricesEnumerator.MoveNext();
                currenciesEnumerator.MoveNext();

                currentDestination = destinationsEnumerator.Current;

                var orderPrice = pricesEnumerator.Current;
                discount = 0;

                if (currenciesEnumerator.Current == "EUR")
                {
                    orderPrice = EURtoUSD(pricesEnumerator.Current, rateEUR);
                }

                if (destinationsEnumerator.Current.Contains("Wayne Street"))
                {
                    orderPrice += 10;
                }
                else if (destinationsEnumerator.Current.Contains("North Heather Street"))
                {
                    orderPrice -= 5.36m;
                }

                if (CheckInfant(infantsIds, i))
                {
                    discount += 0.5;
                }
                else if (CheckChildren(childrenIds, i))
                {
                    discount += 0.25;
                }

                if (i != 0 && GetStreet(previousDestination) == GetStreet(currentDestination))
                {
                    discount += 0.15;
                }

                previousDestination = currentDestination;

                orderPrice -= orderPrice * (decimal)discount;
                fullPrice += orderPrice;

                i++;
            }

            return fullPrice;
        }

        private bool CheckInfant(IEnumerable<int> infantsIds, int i)
        {
            bool result = default;
            foreach (int infant in infantsIds)
            {
                if (i == infant)
                {
                    result = true;
                    break;
                }
                else
                {
                    result = false;
                }
            }

            return result;
        }

        private bool CheckChildren(IEnumerable<int> childrenIds, int i)
        {
            bool result = default;
            foreach (int children in childrenIds)
            {
                if (i == children)
                {
                    result = true;
                    break;
                }
                else
                {
                    result = false;
                }
            }

            return result;
        }

        private decimal EURtoUSD(decimal price, decimal rate)
        {
            return price * rate;
        }

        private string GetStreet(string destination)
        {
            var destinationArr = destination.Split(',');
            var address = destinationArr[0].Split(' ').ToList<string>();

            return string.Join(' ', address.Skip(1));
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