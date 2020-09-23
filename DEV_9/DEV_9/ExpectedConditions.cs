namespace DEV_9
{
    using System;
    using System.Runtime.Remoting.Messaging;

    using OpenQA.Selenium;

    public static class ExpectedConditions
    {
        /// <summary>
        /// An expectation for checking whether an element is visible.
        /// </summary>
        /// <param name="locator">
        /// The locator used to find the element
        /// </param>
        /// <returns>
        /// The <see cref="IWebElement"/> once it is located, visible and clickable./>.
        /// </returns>
        public static Func<IWebDriver, IWebElement> ElementIsClickable(By locator)
        {
            return driver =>
                {
                    var element = driver.FindElement(locator);
                    return (element != null && element.Enabled && element.Displayed) ? element : null;
                };
        }
    }
}