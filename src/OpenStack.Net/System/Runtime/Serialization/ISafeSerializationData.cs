﻿#if NET35 || PORTABLE

namespace System.Runtime.Serialization
{
    /// <summary>
    /// For internal compatibility use only.
    /// </summary>
    internal interface ISafeSerializationData
    {
        /// <summary>
        /// For internal compatibility use only.
        /// </summary>
        void CompleteDeserialization(object deserialized);
    }
}

#endif
