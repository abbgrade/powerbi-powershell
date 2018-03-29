﻿/*
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License.
 */

namespace Microsoft.PowerBI.Common.Abstractions
{
    public enum PowerBIEnvironmentType
    {
#if DEBUG
        OneBox = 100,
        EDog = 101,
        DXT = 102,
#endif
        Public = 0,
        China = 3
    }
}