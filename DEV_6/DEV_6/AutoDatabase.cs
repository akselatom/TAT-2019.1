
namespace DEV_6
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml.Linq;

    /// <summary>
    /// class working with xml-file witch contains information about car warehouse
    /// </summary>
    public class AutoDatabase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoDatabase"/> class.
        /// </summary>
        /// <param name="fileName">
        /// The name of xml-file
        /// </param>
        public AutoDatabase(string fileName = "AutomobileData.xml")
        {
            try
            {
                this.XDocument = XDocument.Load(fileName);

                this.AutomobilesList = this.GetAutoListFromData();
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("error while reading xml file. Try to place your xml file into program directory");
            }
        }

        /// <summary>
        /// Gets xml document witch contains information about car warehouse.
        /// </summary>
        public XDocument XDocument { get; private set; }

        /// <summary>
        /// Gets or sets the automobiles list.
        /// </summary>
        public List<Automobile> AutomobilesList { get; set; }

        /// <summary>
        /// Gets amount of brands in <see cref="XDocument"/>.
        /// </summary>
        /// <returns>
        /// Amount of brands
        /// </returns>
        public int GetAmountOfBrands()
        {
            var usedBrandsList = new List<string>();
            foreach (var automobile in this.AutomobilesList)
            {
                if (!usedBrandsList.Contains(automobile.BrandName))
                {
                    usedBrandsList.Add(automobile.BrandName);
                }
            }

            return usedBrandsList.Count;
        }

        /// <summary>
        /// The get amount of automobiles in <see cref="XDocument"/>
        /// </summary>
        /// <returns>
        /// amount of automobiles.
        /// </returns>
        public int GetAmountOfAutomobiles()
        {
            var amountOfAutomobiles = 0;
            foreach (var auto in this.AutomobilesList)
            {
                amountOfAutomobiles += auto.Count;
            }

            return amountOfAutomobiles;
        }

        /// <summary>
        /// Get average price of all automobiles.
        /// </summary>
        /// <returns>
        /// average price of all automobiles.
        /// </returns>
        public double GetAveragePriceOfAllAutomobiles()
        {
            var averagePrice = 0;
            foreach (var automobile in this.AutomobilesList)
            {
                averagePrice += automobile.Price;
            }

            return averagePrice / (double)this.GetAmountOfAutomobiles();
        }

        /// <summary>
        /// The get average price of all automobiles.
        /// </summary>
        /// <param name="brandName">
        /// The brand name.
        /// </param>
        /// <returns>
        /// average cost of cars of the specified brand.
        /// </returns>
        public double GetAveragePriceOfAllAutomobiles(string brandName)
        {
            var price = 0;
            var amountOfCars = 0;
            foreach (var automobile in this.AutomobilesList)
            {
                if (automobile.BrandName != brandName)
                {
                    continue;
                }

                price += automobile.Price * automobile.Count;
                amountOfCars += automobile.Count;
            }

            return price / (double)amountOfCars;
        }

        /// <summary>
        /// The get auto list from <see cref="XDocument"/>.
        /// </summary>
        /// <returns>
        /// List of <see cref="Automobile"/>
        /// </returns>
        private List<Automobile> GetAutoListFromData()
        {
            if (this.XDocument == null)
            {
                return null;
            }

            try
            {
                var listOfVehicles = this.XDocument.Element("automobile").Elements("auto").Select(
                    xe => new Automobile(
                        brandName: xe.Element("brand").Value,
                        modelName: xe.Element("model").Value,
                        count: int.Parse(xe.Element("count").Value),
                        price: int.Parse(xe.Element("price").Value)));
                return listOfVehicles.ToList();
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("error while reading xml file");
                throw;
            }
        }
    }
}