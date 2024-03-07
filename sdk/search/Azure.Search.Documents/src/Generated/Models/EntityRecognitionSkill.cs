// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Search.Documents;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> This skill is deprecated. Use the V3.EntityRecognitionSkill instead. </summary>
    public partial class EntityRecognitionSkill : SearchIndexerSkill
    {
        /// <summary> Initializes a new instance of <see cref="EntityRecognitionSkill"/>. </summary>
        /// <param name="oDataType"> A URI fragment specifying the type of skill. </param>
        /// <param name="name"> The name of the skill which uniquely identifies it within the skillset. A skill with no name defined will be given a default name of its 1-based index in the skills array, prefixed with the character '#'. </param>
        /// <param name="description"> The description of the skill which describes the inputs, outputs, and usage of the skill. </param>
        /// <param name="context"> Represents the level at which operations take place, such as the document root or document content (for example, /document or /document/content). The default is /document. </param>
        /// <param name="inputs"> Inputs of the skills could be a column in the source data set, or the output of an upstream skill. </param>
        /// <param name="outputs"> The output of a skill is either a field in a search index, or a value that can be consumed as an input by another skill. </param>
        /// <param name="categories"> A list of entity categories that should be extracted. </param>
        /// <param name="defaultLanguageCode"> A value indicating which language code to use. Default is `en`. </param>
        /// <param name="includeTypelessEntities"> Determines whether or not to include entities which are well known but don't conform to a pre-defined type. If this configuration is not set (default), set to null or set to false, entities which don't conform to one of the pre-defined types will not be surfaced. </param>
        /// <param name="minimumPrecision"> A value between 0 and 1 that be used to only include entities whose confidence score is greater than the value specified. If not set (default), or if explicitly set to null, all entities will be included. </param>
        internal EntityRecognitionSkill(string oDataType, string name, string description, string context, IList<InputFieldMappingEntry> inputs, IList<OutputFieldMappingEntry> outputs, IList<EntityCategory> categories, EntityRecognitionSkillLanguage? defaultLanguageCode, bool? includeTypelessEntities, double? minimumPrecision) : base(oDataType, name, description, context, inputs, outputs)
        {
            Categories = categories;
            DefaultLanguageCode = defaultLanguageCode;
            IncludeTypelessEntities = includeTypelessEntities;
            MinimumPrecision = minimumPrecision;
            ODataType = oDataType ?? "#Microsoft.Skills.Text.EntityRecognitionSkill";
        }
        /// <summary> A value indicating which language code to use. Default is `en`. </summary>
        public EntityRecognitionSkillLanguage? DefaultLanguageCode { get; set; }
        /// <summary> A value between 0 and 1 that be used to only include entities whose confidence score is greater than the value specified. If not set (default), or if explicitly set to null, all entities will be included. </summary>
        public double? MinimumPrecision { get; set; }
    }
}
