namespace DEV_6
{
    /// <summary>
    /// The automobile class
    /// </summary>
    public class Automobile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Automobile"/> class.
        /// </summary>
        /// <param name="brandName">
        /// The brand name.
        /// </param>
        /// <param name="modelName">
        /// The model name.
        /// </param>
        /// <param name="count">
        /// The cars count.
        /// </param>
        /// <param name="price">
        /// The car price.
        /// </param>
        public Automobile(string brandName, string modelName, int count, int price)
        {
            this.BrandName = brandName;
            this.ModelName = modelName;
            this.Count = count;
            this.Price = price;
        }

        /// <summary>
        /// Gets car brand name.
        /// </summary>
        public string BrandName { get; private set; }

        /// <summary>
        /// Gets car model name.
        /// </summary>
        public string ModelName { get; private set; }

        /// <summary>
        /// Gets cars count.
        /// </summary>
        public int Count { get; private set; }

        /// <summary>
        /// Gets car price.
        /// </summary>
        public int Price { get; private set; }
    }
}