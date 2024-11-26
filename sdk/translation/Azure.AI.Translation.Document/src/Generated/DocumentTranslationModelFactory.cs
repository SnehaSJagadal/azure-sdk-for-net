// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Azure.AI.Translation.Document
{
    /// <summary> Model factory for models. </summary>
    public static partial class DocumentTranslationModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="Document.DocumentTranslationInput"/>. </summary>
        /// <param name="source"> Source of the input documents. </param>
        /// <param name="targets"> Location of the destination for the output. </param>
        /// <param name="storageUriKind"> Storage type of the input documents source string. </param>
        /// <returns> A new <see cref="Document.DocumentTranslationInput"/> instance for mocking. </returns>
        public static DocumentTranslationInput DocumentTranslationInput(TranslationSource source = null, IEnumerable<TranslationTarget> targets = null, StorageInputUriKind? storageUriKind = null)
        {
            targets ??= new List<TranslationTarget>();

            return new DocumentTranslationInput(source, targets?.ToList(), storageUriKind, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Document.TranslationTarget"/>. </summary>
        /// <param name="targetUri"> Location of the folder / container with your documents. </param>
        /// <param name="categoryId"> Category / custom system for translation request. </param>
        /// <param name="languageCode"> Target Language. </param>
        /// <param name="glossaries"> List of Glossary. </param>
        /// <param name="storageSource"> Storage Source. </param>
        /// <returns> A new <see cref="Document.TranslationTarget"/> instance for mocking. </returns>
        public static TranslationTarget TranslationTarget(Uri targetUri = null, string categoryId = null, string languageCode = null, IEnumerable<TranslationGlossary> glossaries = null, TranslationStorageSource? storageSource = null)
        {
            glossaries ??= new List<TranslationGlossary>();

            return new TranslationTarget(
                targetUri,
                categoryId,
                languageCode,
                glossaries?.ToList(),
                storageSource,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Document.TranslationGlossary"/>. </summary>
        /// <param name="glossaryUri">
        /// Location of the glossary.
        /// We will use the file extension to extract the
        /// formatting if the format parameter is not supplied.
        ///
        /// If the translation
        /// language pair is not present in the glossary, it will not be applied
        /// </param>
        /// <param name="format"> Format. </param>
        /// <param name="formatVersion"> Optional Version.  If not specified, default is used. </param>
        /// <param name="storageSource"> Storage Source. </param>
        /// <returns> A new <see cref="Document.TranslationGlossary"/> instance for mocking. </returns>
        public static TranslationGlossary TranslationGlossary(Uri glossaryUri = null, string format = null, string formatVersion = null, TranslationStorageSource? storageSource = null)
        {
            return new TranslationGlossary(glossaryUri, format, formatVersion, storageSource, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Document.SupportedFileFormats"/>. </summary>
        /// <param name="value"> list of objects. </param>
        /// <returns> A new <see cref="Document.SupportedFileFormats"/> instance for mocking. </returns>
        public static SupportedFileFormats SupportedFileFormats(IEnumerable<DocumentTranslationFileFormat> value = null)
        {
            value ??= new List<DocumentTranslationFileFormat>();

            return new SupportedFileFormats(value?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Document.DocumentTranslationFileFormat"/>. </summary>
        /// <param name="format"> Name of the format. </param>
        /// <param name="fileExtensions"> Supported file extension for this format. </param>
        /// <param name="contentTypes"> Supported Content-Types for this format. </param>
        /// <param name="defaultFormatVersion"> Default version if none is specified. </param>
        /// <param name="formatVersions"> Supported Version. </param>
        /// <param name="type"> Supported Type for this format. </param>
        /// <returns> A new <see cref="Document.DocumentTranslationFileFormat"/> instance for mocking. </returns>
        public static DocumentTranslationFileFormat DocumentTranslationFileFormat(string format = null, IEnumerable<string> fileExtensions = null, IEnumerable<string> contentTypes = null, string defaultFormatVersion = null, IEnumerable<string> formatVersions = null, FileFormatType? type = null)
        {
            fileExtensions ??= new List<string>();
            contentTypes ??= new List<string>();
            formatVersions ??= new List<string>();

            return new DocumentTranslationFileFormat(
                format,
                fileExtensions?.ToList(),
                contentTypes?.ToList(),
                defaultFormatVersion,
                formatVersions?.ToList(),
                type,
                serializedAdditionalRawData: null);
        }
    }
}
