// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Search.Documents;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Using the Text Analytics API, extracts personal information from an input text and gives you the option of masking it. </summary>
    public partial class PiiDetectionSkill : SearchIndexerSkill
    {
        /// <summary> Initializes a new instance of <see cref="PiiDetectionSkill"/>. </summary>
        /// <param name="inputs"> Inputs of the skills could be a column in the source data set, or the output of an upstream skill. </param>
        /// <param name="outputs"> The output of a skill is either a field in a search index, or a value that can be consumed as an input by another skill. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="inputs"/> or <paramref name="outputs"/> is null. </exception>
        public PiiDetectionSkill(IEnumerable<InputFieldMappingEntry> inputs, IEnumerable<OutputFieldMappingEntry> outputs) : base(inputs, outputs)
        {
            if (inputs == null)
            {
                throw new ArgumentNullException(nameof(inputs));
            }
            if (outputs == null)
            {
                throw new ArgumentNullException(nameof(outputs));
            }

            PiiCategories = new ChangeTrackingList<string>();
            ODataType = "#Microsoft.Skills.Text.PIIDetectionSkill";
        }

        /// <summary> Initializes a new instance of <see cref="PiiDetectionSkill"/>. </summary>
        /// <param name="oDataType"> A URI fragment specifying the type of skill. </param>
        /// <param name="name"> The name of the skill which uniquely identifies it within the skillset. A skill with no name defined will be given a default name of its 1-based index in the skills array, prefixed with the character '#'. </param>
        /// <param name="description"> The description of the skill which describes the inputs, outputs, and usage of the skill. </param>
        /// <param name="context"> Represents the level at which operations take place, such as the document root or document content (for example, /document or /document/content). The default is /document. </param>
        /// <param name="inputs"> Inputs of the skills could be a column in the source data set, or the output of an upstream skill. </param>
        /// <param name="outputs"> The output of a skill is either a field in a search index, or a value that can be consumed as an input by another skill. </param>
        /// <param name="defaultLanguageCode"> A value indicating which language code to use. Default is `en`. </param>
        /// <param name="minPrecision"> A value between 0 and 1 that be used to only include entities whose confidence score is greater than the value specified. If not set (default), or if explicitly set to null, all entities will be included. </param>
        /// <param name="maskingMode"> A parameter that provides various ways to mask the personal information detected in the input text. Default is 'none'. </param>
        /// <param name="mask"> The character used to mask the text if the maskingMode parameter is set to replace. Default is '*'. </param>
        /// <param name="modelVersion"> The version of the model to use when calling the Text Analytics service. It will default to the latest available when not specified. We recommend you do not specify this value unless absolutely necessary. </param>
        /// <param name="piiCategories"> A list of PII entity categories that should be extracted and masked. </param>
        /// <param name="domain"> If specified, will set the PII domain to include only a subset of the entity categories. Possible values include: 'phi', 'none'. Default is 'none'. </param>
        internal PiiDetectionSkill(string oDataType, string name, string description, string context, IList<InputFieldMappingEntry> inputs, IList<OutputFieldMappingEntry> outputs, string defaultLanguageCode, double? minPrecision, PiiDetectionSkillMaskingMode? maskingMode, string mask, string modelVersion, IList<string> piiCategories, string domain) : base(oDataType, name, description, context, inputs, outputs)
        {
            DefaultLanguageCode = defaultLanguageCode;
            MinPrecision = minPrecision;
            MaskingMode = maskingMode;
            Mask = mask;
            ModelVersion = modelVersion;
            PiiCategories = piiCategories;
            Domain = domain;
            ODataType = oDataType ?? "#Microsoft.Skills.Text.PIIDetectionSkill";
        }
        /// <summary> A value between 0 and 1 that be used to only include entities whose confidence score is greater than the value specified. If not set (default), or if explicitly set to null, all entities will be included. </summary>
        public double? MinPrecision { get; set; }
        /// <summary> A parameter that provides various ways to mask the personal information detected in the input text. Default is 'none'. </summary>
        public PiiDetectionSkillMaskingMode? MaskingMode { get; set; }
        /// <summary> The character used to mask the text if the maskingMode parameter is set to replace. Default is '*'. </summary>
        public string Mask { get; set; }
        /// <summary> The version of the model to use when calling the Text Analytics service. It will default to the latest available when not specified. We recommend you do not specify this value unless absolutely necessary. </summary>
        public string ModelVersion { get; set; }
        /// <summary> A list of PII entity categories that should be extracted and masked. </summary>
        public IList<string> PiiCategories { get; }
        /// <summary> If specified, will set the PII domain to include only a subset of the entity categories. Possible values include: 'phi', 'none'. Default is 'none'. </summary>
        public string Domain { get; set; }
    }
}
