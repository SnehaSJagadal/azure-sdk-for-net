// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.CognitiveServices
{
    public partial class CognitiveServicesEncryptionScopeResource : IJsonModel<CognitiveServicesEncryptionScopeData>
    {
        void IJsonModel<CognitiveServicesEncryptionScopeData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<CognitiveServicesEncryptionScopeData>)Data).Write(writer, options);

        CognitiveServicesEncryptionScopeData IJsonModel<CognitiveServicesEncryptionScopeData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<CognitiveServicesEncryptionScopeData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<CognitiveServicesEncryptionScopeData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        CognitiveServicesEncryptionScopeData IPersistableModel<CognitiveServicesEncryptionScopeData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<CognitiveServicesEncryptionScopeData>(data, options);

        string IPersistableModel<CognitiveServicesEncryptionScopeData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<CognitiveServicesEncryptionScopeData>)Data).GetFormatFromOptions(options);
    }
}
