// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Projects
{
    public partial class ThreadRun : IUtf8JsonSerializable, IJsonModel<ThreadRun>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ThreadRun>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ThreadRun>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ThreadRun>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ThreadRun)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
            writer.WritePropertyName("object"u8);
            writer.WriteStringValue(Object);
            writer.WritePropertyName("thread_id"u8);
            writer.WriteStringValue(ThreadId);
            writer.WritePropertyName("assistant_id"u8);
            writer.WriteStringValue(AssistantId);
            writer.WritePropertyName("status"u8);
            writer.WriteStringValue(Status.ToString());
            if (Optional.IsDefined(RequiredAction))
            {
                if (RequiredAction != null)
                {
                    writer.WritePropertyName("required_action"u8);
                    writer.WriteObjectValue(RequiredAction, options);
                }
                else
                {
                    writer.WriteNull("required_action");
                }
            }
            if (LastError != null)
            {
                writer.WritePropertyName("last_error"u8);
                writer.WriteObjectValue(LastError, options);
            }
            else
            {
                writer.WriteNull("last_error");
            }
            writer.WritePropertyName("model"u8);
            writer.WriteStringValue(Model);
            writer.WritePropertyName("instructions"u8);
            writer.WriteStringValue(Instructions);
            writer.WritePropertyName("tools"u8);
            writer.WriteStartArray();
            foreach (var item in Tools)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("created_at"u8);
            writer.WriteNumberValue(CreatedAt, "U");
            if (ExpiresAt != null)
            {
                writer.WritePropertyName("expires_at"u8);
                writer.WriteNumberValue(ExpiresAt.Value, "U");
            }
            else
            {
                writer.WriteNull("expires_at");
            }
            if (StartedAt != null)
            {
                writer.WritePropertyName("started_at"u8);
                writer.WriteNumberValue(StartedAt.Value, "U");
            }
            else
            {
                writer.WriteNull("started_at");
            }
            if (CompletedAt != null)
            {
                writer.WritePropertyName("completed_at"u8);
                writer.WriteNumberValue(CompletedAt.Value, "U");
            }
            else
            {
                writer.WriteNull("completed_at");
            }
            if (CancelledAt != null)
            {
                writer.WritePropertyName("cancelled_at"u8);
                writer.WriteNumberValue(CancelledAt.Value, "U");
            }
            else
            {
                writer.WriteNull("cancelled_at");
            }
            if (FailedAt != null)
            {
                writer.WritePropertyName("failed_at"u8);
                writer.WriteNumberValue(FailedAt.Value, "U");
            }
            else
            {
                writer.WriteNull("failed_at");
            }
            if (IncompleteDetails != null)
            {
                writer.WritePropertyName("incomplete_details"u8);
                writer.WriteObjectValue(IncompleteDetails, options);
            }
            else
            {
                writer.WriteNull("incomplete_details");
            }
            if (Usage != null)
            {
                writer.WritePropertyName("usage"u8);
                writer.WriteObjectValue(Usage, options);
            }
            else
            {
                writer.WriteNull("usage");
            }
            if (Optional.IsDefined(Temperature))
            {
                if (Temperature != null)
                {
                    writer.WritePropertyName("temperature"u8);
                    writer.WriteNumberValue(Temperature.Value);
                }
                else
                {
                    writer.WriteNull("temperature");
                }
            }
            if (Optional.IsDefined(TopP))
            {
                if (TopP != null)
                {
                    writer.WritePropertyName("top_p"u8);
                    writer.WriteNumberValue(TopP.Value);
                }
                else
                {
                    writer.WriteNull("top_p");
                }
            }
            if (MaxPromptTokens != null)
            {
                writer.WritePropertyName("max_prompt_tokens"u8);
                writer.WriteNumberValue(MaxPromptTokens.Value);
            }
            else
            {
                writer.WriteNull("max_prompt_tokens");
            }
            if (MaxCompletionTokens != null)
            {
                writer.WritePropertyName("max_completion_tokens"u8);
                writer.WriteNumberValue(MaxCompletionTokens.Value);
            }
            else
            {
                writer.WriteNull("max_completion_tokens");
            }
            if (TruncationStrategy != null)
            {
                writer.WritePropertyName("truncation_strategy"u8);
                writer.WriteObjectValue(TruncationStrategy, options);
            }
            else
            {
                writer.WriteNull("truncation_strategy");
            }
            if (ToolChoice != null)
            {
                writer.WritePropertyName("tool_choice"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(ToolChoice);
#else
                using (JsonDocument document = JsonDocument.Parse(ToolChoice))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            else
            {
                writer.WriteNull("tool_choice");
            }
            if (ResponseFormat != null)
            {
                writer.WritePropertyName("response_format"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(ResponseFormat);
#else
                using (JsonDocument document = JsonDocument.Parse(ResponseFormat))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            else
            {
                writer.WriteNull("response_format");
            }
            if (Metadata != null && Optional.IsCollectionDefined(Metadata))
            {
                writer.WritePropertyName("metadata"u8);
                writer.WriteStartObject();
                foreach (var item in Metadata)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            else
            {
                writer.WriteNull("metadata");
            }
            if (Optional.IsDefined(ToolResources))
            {
                if (ToolResources != null)
                {
                    writer.WritePropertyName("tool_resources"u8);
                    writer.WriteObjectValue(ToolResources, options);
                }
                else
                {
                    writer.WriteNull("tool_resources");
                }
            }
            if (Optional.IsDefined(ParallelToolCalls))
            {
                writer.WritePropertyName("parallelToolCalls"u8);
                writer.WriteBooleanValue(ParallelToolCalls.Value);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        ThreadRun IJsonModel<ThreadRun>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ThreadRun>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ThreadRun)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeThreadRun(document.RootElement, options);
        }

        internal static ThreadRun DeserializeThreadRun(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            string @object = default;
            string threadId = default;
            string assistantId = default;
            RunStatus status = default;
            RequiredAction requiredAction = default;
            RunError lastError = default;
            string model = default;
            string instructions = default;
            IReadOnlyList<ToolDefinition> tools = default;
            DateTimeOffset createdAt = default;
            DateTimeOffset? expiresAt = default;
            DateTimeOffset? startedAt = default;
            DateTimeOffset? completedAt = default;
            DateTimeOffset? cancelledAt = default;
            DateTimeOffset? failedAt = default;
            IncompleteRunDetails incompleteDetails = default;
            RunCompletionUsage usage = default;
            float? temperature = default;
            float? topP = default;
            int? maxPromptTokens = default;
            int? maxCompletionTokens = default;
            TruncationObject truncationStrategy = default;
            BinaryData toolChoice = default;
            BinaryData responseFormat = default;
            IReadOnlyDictionary<string, string> metadata = default;
            UpdateToolResourcesOptions toolResources = default;
            bool? parallelToolCalls = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("object"u8))
                {
                    @object = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("thread_id"u8))
                {
                    threadId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("assistant_id"u8))
                {
                    assistantId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = new RunStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("required_action"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        requiredAction = null;
                        continue;
                    }
                    requiredAction = RequiredAction.DeserializeRequiredAction(property.Value, options);
                    continue;
                }
                if (property.NameEquals("last_error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        lastError = null;
                        continue;
                    }
                    lastError = RunError.DeserializeRunError(property.Value, options);
                    continue;
                }
                if (property.NameEquals("model"u8))
                {
                    model = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("instructions"u8))
                {
                    instructions = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tools"u8))
                {
                    List<ToolDefinition> array = new List<ToolDefinition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ToolDefinition.DeserializeToolDefinition(item, options));
                    }
                    tools = array;
                    continue;
                }
                if (property.NameEquals("created_at"u8))
                {
                    createdAt = DateTimeOffset.FromUnixTimeSeconds(property.Value.GetInt64());
                    continue;
                }
                if (property.NameEquals("expires_at"u8))
                {
                    DeserializeNullableDateTimeOffset(property, ref expiresAt);
                    continue;
                }
                if (property.NameEquals("started_at"u8))
                {
                    DeserializeNullableDateTimeOffset(property, ref startedAt);
                    continue;
                }
                if (property.NameEquals("completed_at"u8))
                {
                    DeserializeNullableDateTimeOffset(property, ref completedAt);
                    continue;
                }
                if (property.NameEquals("cancelled_at"u8))
                {
                    DeserializeNullableDateTimeOffset(property, ref cancelledAt);
                    continue;
                }
                if (property.NameEquals("failed_at"u8))
                {
                    DeserializeNullableDateTimeOffset(property, ref failedAt);
                    continue;
                }
                if (property.NameEquals("incomplete_details"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        incompleteDetails = null;
                        continue;
                    }
                    incompleteDetails = IncompleteRunDetails.DeserializeIncompleteRunDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("usage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        usage = null;
                        continue;
                    }
                    usage = RunCompletionUsage.DeserializeRunCompletionUsage(property.Value, options);
                    continue;
                }
                if (property.NameEquals("temperature"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        temperature = null;
                        continue;
                    }
                    temperature = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("top_p"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        topP = null;
                        continue;
                    }
                    topP = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("max_prompt_tokens"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        maxPromptTokens = null;
                        continue;
                    }
                    maxPromptTokens = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("max_completion_tokens"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        maxCompletionTokens = null;
                        continue;
                    }
                    maxCompletionTokens = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("truncation_strategy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        truncationStrategy = null;
                        continue;
                    }
                    truncationStrategy = TruncationObject.DeserializeTruncationObject(property.Value, options);
                    continue;
                }
                if (property.NameEquals("tool_choice"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        toolChoice = null;
                        continue;
                    }
                    toolChoice = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("response_format"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        responseFormat = null;
                        continue;
                    }
                    responseFormat = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("metadata"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        metadata = new ChangeTrackingDictionary<string, string>();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    metadata = dictionary;
                    continue;
                }
                if (property.NameEquals("tool_resources"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        toolResources = null;
                        continue;
                    }
                    toolResources = UpdateToolResourcesOptions.DeserializeUpdateToolResourcesOptions(property.Value, options);
                    continue;
                }
                if (property.NameEquals("parallelToolCalls"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    parallelToolCalls = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ThreadRun(
                id,
                @object,
                threadId,
                assistantId,
                status,
                requiredAction,
                lastError,
                model,
                instructions,
                tools,
                createdAt,
                expiresAt,
                startedAt,
                completedAt,
                cancelledAt,
                failedAt,
                incompleteDetails,
                usage,
                temperature,
                topP,
                maxPromptTokens,
                maxCompletionTokens,
                truncationStrategy,
                toolChoice,
                responseFormat,
                metadata,
                toolResources,
                parallelToolCalls,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ThreadRun>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ThreadRun>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ThreadRun)} does not support writing '{options.Format}' format.");
            }
        }

        ThreadRun IPersistableModel<ThreadRun>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ThreadRun>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeThreadRun(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ThreadRun)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ThreadRun>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ThreadRun FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeThreadRun(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
