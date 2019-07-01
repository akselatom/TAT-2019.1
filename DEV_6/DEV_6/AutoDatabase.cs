
namespace DEV_6
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

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
                this.XmlDoc = new XmlDocument();
                this.XmlDoc.Load(fileName);
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
        public XmlDocument XmlDoc { get; private set; }

        /// <summary>
        /// Gets or sets the automobiles list.
        /// </summary>
        public List<Automobile> AutomobilesList { get; set; }

        /// <summary>
        /// Gets amount of brands in <see cref="XmlDoc"/>.
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
        /// The get amount of automobiles in <see cref="XmlDoc"/>
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
        /// The get auto list from <see cref="XmlDoc"/>.
        /// </summary>
        /// <returns>
        /// List of <see cref="Automobile"/>
        /// </returns>
        private List<Automobile> GetAutoListFromData()
        {
            var autoList = new List<Automobile>();
            if (this.XmlDoc.DocumentElement == null)
            {
                return null;
            }

            foreach (XmlNode node in this.XmlDoc.DocumentElement)
            {
                var brand = string.Empty;
                var model = string.Empty;
                var count = 0;
                var price = 0;
                        
                foreach (XmlNode childNode in node.ChildNodes)
                {
                    switch (childNode.Name)
                    {
                        case "brand":
                            brand = childNode.InnerText;
                            break;
                        case "model":
                            model = childNode.InnerText;
                            break;
                        case "count":
                            count = int.Parse(childNode.InnerText);
                            break;
                        case "price":
                            price = int.Parse(childNode.InnerText);
                            break;
                    }
                }

                if (brand != string.Empty && model != string.Empty)
                {
                    autoList.Add(new Automobile(brand, model, count, price));
                }
            }

            return autoList;
        }
    }
}