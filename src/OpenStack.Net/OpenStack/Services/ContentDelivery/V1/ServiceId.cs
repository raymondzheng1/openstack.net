﻿namespace OpenStack.Services.ContentDelivery.V1
{
    using System;
    using Newtonsoft.Json;
    using OpenStack.ObjectModel;

    /// <summary>
    /// Represents the unique identifier of a <see cref="Service"/> resource in the Content Delivery Service.
    /// </summary>
    /// <seealso cref="Service"/>
    /// <seealso cref="IContentDeliveryService"/>
    /// <threadsafety static="true" instance="false"/>
    /// <preliminary/>
    [JsonConverter(typeof(ServiceId.Converter))]
    public sealed class ServiceId : ResourceIdentifier<ServiceId>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceId"/> class
        /// with the specified identifier value.
        /// </summary>
        /// <param name="id">The identifier value.</param>
        /// <exception cref="ArgumentNullException">If <paramref name="id"/> is <see langword="null"/>.</exception>
        /// <exception cref="ArgumentException">If <paramref name="id"/> is empty.</exception>
        public ServiceId(string id)
            : base(id)
        {
        }

        /// <summary>
        /// Provides support for serializing and deserializing <see cref="ServiceId"/>
        /// objects to JSON string values.
        /// </summary>
        /// <threadsafety static="true" instance="false"/>
        private sealed class Converter : ConverterBase
        {
            /// <inheritdoc/>
            protected override ServiceId FromValue(string id)
            {
                return new ServiceId(id);
            }
        }
    }
}
