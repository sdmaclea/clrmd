﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Runtime.InteropServices;

namespace Microsoft.Diagnostics.Runtime.DacInterface
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct ThreadLocalModuleData
    {
        public readonly ClrDataAddress ThreadAddress;
        public readonly ClrDataAddress ModuleIndex;

        public readonly ClrDataAddress ClassData;
        public readonly ClrDataAddress DynamicClassTable;
        public readonly ClrDataAddress GCStaticDataStart;
        public readonly ClrDataAddress NonGCStaticDataStart;
    }
}