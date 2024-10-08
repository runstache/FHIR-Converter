﻿// -------------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using Microsoft.Health.Fhir.Liquid.Converter.Models;

namespace Microsoft.Health.Fhir.Liquid.Converter.Processors
{
    public interface IConvertProcessorFactory
    {
        public IFhirConverter GetProcessor(DataType inputDataType, ConvertDataOutputFormat outputFormat, ProcessorSettings processorSettings = null);
    }
}
