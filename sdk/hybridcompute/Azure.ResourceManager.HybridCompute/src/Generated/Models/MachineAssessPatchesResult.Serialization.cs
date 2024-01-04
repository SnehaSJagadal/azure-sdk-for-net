// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.HybridCompute.Models
{
    public partial class MachineAssessPatchesResult
    {
        internal static MachineAssessPatchesResult DeserializeMachineAssessPatchesResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<MachineOperationStatus> status = default;
            Optional<Guid> assessmentActivityId = default;
            Optional<bool> rebootPending = default;
            Optional<AvailablePatchCountByClassification> availablePatchCountByClassification = default;
            Optional<DateTimeOffset> startDateTime = default;
            Optional<DateTimeOffset> lastModifiedDateTime = default;
            Optional<PatchOperationStartedBy> startedBy = default;
            Optional<PatchServiceUsed> patchServiceUsed = default;
            Optional<HybridComputeOSType> osType = default;
            Optional<ResponseError> errorDetails = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new MachineOperationStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("assessmentActivityId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    assessmentActivityId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("rebootPending"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rebootPending = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("availablePatchCountByClassification"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    availablePatchCountByClassification = AvailablePatchCountByClassification.DeserializeAvailablePatchCountByClassification(property.Value);
                    continue;
                }
                if (property.NameEquals("startDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastModifiedDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastModifiedDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("startedBy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startedBy = new PatchOperationStartedBy(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("patchServiceUsed"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    patchServiceUsed = new PatchServiceUsed(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("osType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    osType = new HybridComputeOSType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("errorDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    errorDetails = JsonSerializer.Deserialize<ResponseError>(property.Value.GetRawText());
                    continue;
                }
            }
            return new MachineAssessPatchesResult(Optional.ToNullable(status), Optional.ToNullable(assessmentActivityId), Optional.ToNullable(rebootPending), availablePatchCountByClassification.Value, Optional.ToNullable(startDateTime), Optional.ToNullable(lastModifiedDateTime), Optional.ToNullable(startedBy), Optional.ToNullable(patchServiceUsed), Optional.ToNullable(osType), errorDetails.Value);
        }
    }
}
