// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SingleObject.cs" company="SDCWORLD">
//   Sourodeep Chatterjee
// </copyright>
// <summary>
//   Defines the SingleObject type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SingletonPattern
{
    using System;

    /// <summary>
    /// The single object.
    /// </summary>
    public class SingleObject
    {
        /// <summary>
        /// The single object instance.
        /// </summary>
        private static readonly SingleObject SingleObjectInstance = new SingleObject();
        
        /// <summary>
        /// Prevents a default instance of the <see cref="SingleObject"/> class from being created.
        /// </summary>
        private SingleObject()
        {
        }

        /// <summary>
        /// The get single object instance.
        /// </summary>
        /// <returns>
        /// The <see cref="SingleObject"/>.
        /// </returns>
        public static SingleObject GetSingleObjectInstance()
        {
            return SingleObjectInstance;
        }

        /// <summary>
        /// The show message.
        /// </summary>
        public void ShowMessage()
        {
            Console.WriteLine("Hello from SingleObject class");
        }
    }
}