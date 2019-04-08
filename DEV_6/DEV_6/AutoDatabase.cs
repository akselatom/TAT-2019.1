
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
            }
            catch (XmlException)
            {
                Console.WriteLine("error while reading xml file");
            }
        }

        /// <summary>
        /// Gets xml document witch contains information about car warehouse.
        /// </summary>
        public XmlDocument XmlDoc { get; private set; }

        /// <summary>
        /// Gets amount of brands in <see cref="XmlDoc"/>.
        /// </summary>
        /// <returns>
        /// Amount of brands
        /// </returns>
        public int GetAmountOfBrands()
        {
            var usedBrandsList = new List<string>();
            foreach (var brandName in this.GetChildNodeInnerText("brand"))
            {
                if (!usedBrandsList.Contains(brandName))
                {
                    usedBrandsList.Add(brandName);
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
            foreach (var count in this.GetChildNodeInnerText("count"))
            {
                amountOfAutomobiles += int.Parse(count);
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
            for (int i = 0; i < this.GetChildNodeInnerText("price").Count; i++)
            {
                ////total price = number of cars * car price.
                averagePrice += int.Parse(this.GetChildNodeInnerText("price")[i])
                                * int.Parse(this.GetChildNodeInnerText("count")[i]);
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
            var averagePrice = 0;
            var amountOfCars = 0;
            var xmlDocDocumentElement = this.XmlDoc.DocumentElement;
            if (xmlDocDocumentElement != null)
            {
                foreach (XmlNode node in xmlDocDocumentElement)
                {
                    foreach (XmlNode childNode in node.ChildNodes)
                    {
                        if (childNode.Name != "brand" && childNode.InnerText != brandName)
                        {
                            continue;
                        }

                        var price = 0;
                        var numberOfCars = 0;
                        foreach (XmlNode subChildNode in node.ChildNodes)
                        {
                            switch (subChildNode.Name)
                            {
                                case "price":
                                    price += int.Parse(subChildNode.InnerText);
                                    break;
                                case "number":
                                    numberOfCars = int.Parse(subChildNode.InnerText);
                                    break;
                            }
                        }

                        averagePrice += price * numberOfCars;
                        amountOfCars += numberOfCars;
                    }
                }
            }
            else
            {
                throw new ArgumentNullException(this.GetAmountOfAutomobiles().ToString(), "Trying to work with empty xml-file");
            }

            return averagePrice / (double)amountOfCars;
        }

        /// <summary>
        /// The get child node inner text.
        /// </summary>
        /// <param name="childNodeName">
        /// The child node name.
        /// </param>
        /// <returns>
        /// The <see cref="List{T}"/> of inner text of all child nodes.
        /// </returns>
        private List<string> GetChildNodeInnerText(string childNodeName)
        {
            var xmlDocDocumentElement = this.XmlDoc.DocumentElement;
            var innerTexts = new List<string>();

            if (xmlDocDocumentElement != null)
            {
                foreach (XmlNode node in xmlDocDocumentElement)
                {
                    foreach (XmlNode childNode in node.ChildNodes)
                    {
                        if (childNode.Name != childNodeName)
                        {
                            continue;
                        }

                        innerTexts.Add(childNode.InnerText);     
                    }
                }
            }
            else
            {
                throw new ArgumentNullException(this.GetAmountOfAutomobiles().ToString(), "Trying to work with empty xml-file");
            }

            return innerTexts;
        }
    }
}