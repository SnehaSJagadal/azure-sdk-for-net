// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Analytics.Synapse.Artifacts;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(ActivityConverter))]
    public partial class Activity : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (Optional.IsDefined(OnInactiveMarkAs))
            {
                writer.WritePropertyName("onInactiveMarkAs"u8);
                writer.WriteStringValue(OnInactiveMarkAs.Value.ToString());
            }
            if (Optional.IsCollectionDefined(DependsOn))
            {
                writer.WritePropertyName("dependsOn"u8);
                writer.WriteStartArray();
                foreach (var item in DependsOn)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(UserProperties))
            {
                writer.WritePropertyName("userProperties"u8);
                writer.WriteStartArray();
                foreach (var item in UserProperties)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static Activity DeserializeActivity(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AppendVariable": return AppendVariableActivity.DeserializeAppendVariableActivity(element);
                    case "AzureDataExplorerCommand": return AzureDataExplorerCommandActivity.DeserializeAzureDataExplorerCommandActivity(element);
                    case "AzureFunctionActivity": return AzureFunctionActivity.DeserializeAzureFunctionActivity(element);
                    case "AzureMLBatchExecution": return AzureMLBatchExecutionActivity.DeserializeAzureMLBatchExecutionActivity(element);
                    case "AzureMLExecutePipeline": return AzureMLExecutePipelineActivity.DeserializeAzureMLExecutePipelineActivity(element);
                    case "AzureMLUpdateResource": return AzureMLUpdateResourceActivity.DeserializeAzureMLUpdateResourceActivity(element);
                    case "Container": return ControlActivity.DeserializeControlActivity(element);
                    case "Copy": return CopyActivity.DeserializeCopyActivity(element);
                    case "Custom": return CustomActivity.DeserializeCustomActivity(element);
                    case "DataLakeAnalyticsU-SQL": return DataLakeAnalyticsUsqlActivity.DeserializeDataLakeAnalyticsUsqlActivity(element);
                    case "DatabricksNotebook": return DatabricksNotebookActivity.DeserializeDatabricksNotebookActivity(element);
                    case "DatabricksSparkJar": return DatabricksSparkJarActivity.DeserializeDatabricksSparkJarActivity(element);
                    case "DatabricksSparkPython": return DatabricksSparkPythonActivity.DeserializeDatabricksSparkPythonActivity(element);
                    case "Delete": return DeleteActivity.DeserializeDeleteActivity(element);
                    case "ExecuteDataFlow": return ExecuteDataFlowActivity.DeserializeExecuteDataFlowActivity(element);
                    case "ExecutePipeline": return ExecutePipelineActivity.DeserializeExecutePipelineActivity(element);
                    case "ExecuteSSISPackage": return ExecuteSsisPackageActivity.DeserializeExecuteSsisPackageActivity(element);
                    case "Execution": return ExecutionActivity.DeserializeExecutionActivity(element);
                    case "Fail": return FailActivity.DeserializeFailActivity(element);
                    case "Filter": return FilterActivity.DeserializeFilterActivity(element);
                    case "ForEach": return ForEachActivity.DeserializeForEachActivity(element);
                    case "GetMetadata": return GetMetadataActivity.DeserializeGetMetadataActivity(element);
                    case "HDInsightHive": return HDInsightHiveActivity.DeserializeHDInsightHiveActivity(element);
                    case "HDInsightMapReduce": return HDInsightMapReduceActivity.DeserializeHDInsightMapReduceActivity(element);
                    case "HDInsightPig": return HDInsightPigActivity.DeserializeHDInsightPigActivity(element);
                    case "HDInsightSpark": return HDInsightSparkActivity.DeserializeHDInsightSparkActivity(element);
                    case "HDInsightStreaming": return HDInsightStreamingActivity.DeserializeHDInsightStreamingActivity(element);
                    case "IfCondition": return IfConditionActivity.DeserializeIfConditionActivity(element);
                    case "Lookup": return LookupActivity.DeserializeLookupActivity(element);
                    case "Script": return ScriptActivity.DeserializeScriptActivity(element);
                    case "SetVariable": return SetVariableActivity.DeserializeSetVariableActivity(element);
                    case "SparkJob": return SynapseSparkJobDefinitionActivity.DeserializeSynapseSparkJobDefinitionActivity(element);
                    case "SqlPoolStoredProcedure": return SqlPoolStoredProcedureActivity.DeserializeSqlPoolStoredProcedureActivity(element);
                    case "SqlServerStoredProcedure": return SqlServerStoredProcedureActivity.DeserializeSqlServerStoredProcedureActivity(element);
                    case "Switch": return SwitchActivity.DeserializeSwitchActivity(element);
                    case "SynapseNotebook": return SynapseNotebookActivity.DeserializeSynapseNotebookActivity(element);
                    case "Until": return UntilActivity.DeserializeUntilActivity(element);
                    case "Validation": return ValidationActivity.DeserializeValidationActivity(element);
                    case "Wait": return WaitActivity.DeserializeWaitActivity(element);
                    case "WebActivity": return WebActivity.DeserializeWebActivity(element);
                    case "WebHook": return WebHookActivity.DeserializeWebHookActivity(element);
                }
            }
            return UnknownActivity.DeserializeUnknownActivity(element);
        }

        internal partial class ActivityConverter : JsonConverter<Activity>
        {
            public override void Write(Utf8JsonWriter writer, Activity model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override Activity Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeActivity(document.RootElement);
            }
        }
    }
}
