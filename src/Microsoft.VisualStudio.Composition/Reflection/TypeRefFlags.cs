﻿// Copyright (c) Microsoft. All rights reserved.

namespace Microsoft.VisualStudio.Composition.Reflection
{
    using System;

    /// <summary>
    /// Flags that describe a type.
    /// </summary>
    [Flags]
    public enum TypeRefFlags
    {
        /// <summary>
        /// No flags.
        /// </summary>
        None = 0x0,

        /// <summary>
        /// Identifies an array.
        /// </summary>
        Array = 0x1,

        /// <summary>
        /// Identifies a value type (as opposed to a reference type).
        /// </summary>
        IsValueType = 0x2,
    }
}
