// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.Search.Documents;

namespace Azure.Search.Documents.Models
{
    /// <summary> Contains a document found by a search query, plus associated metadata. </summary>
    internal partial class SearchResult
    {
        /// <summary> Initializes a new instance of <see cref="SearchResult"/>. </summary>
        /// <param name="score"> The relevance score of the document compared to other documents returned by the query. </param>
        internal SearchResult(double score)
        {
            Score = score;
            Highlights = new ChangeTrackingDictionary<string, IList<string>>();
            Captions = new ChangeTrackingList<QueryCaptionResult>();
            DocumentDebugInfo = new ChangeTrackingList<DocumentDebugInfo>();
            AdditionalProperties = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of <see cref="SearchResult"/>. </summary>
        /// <param name="score"> The relevance score of the document compared to other documents returned by the query. </param>
        /// <param name="rerankerScore"> The relevance score computed by the semantic ranker for the top search results. Search results are sorted by the RerankerScore first and then by the Score. RerankerScore is only returned for queries of type 'semantic'. </param>
        /// <param name="highlights"> Text fragments from the document that indicate the matching search terms, organized by each applicable field; null if hit highlighting was not enabled for the query. </param>
        /// <param name="captions"> Captions are the most representative passages from the document relatively to the search query. They are often used as document summary. Captions are only returned for queries of type 'semantic'. </param>
        /// <param name="documentDebugInfo"> Contains debugging information that can be used to further explore your search results. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal SearchResult(double score, double? rerankerScore, IReadOnlyDictionary<string, IList<string>> highlights, IReadOnlyList<QueryCaptionResult> captions, IReadOnlyList<DocumentDebugInfo> documentDebugInfo, IReadOnlyDictionary<string, object> additionalProperties)
        {
            Score = score;
            RerankerScore = rerankerScore;
            Highlights = highlights;
            Captions = captions;
            DocumentDebugInfo = documentDebugInfo;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> The relevance score of the document compared to other documents returned by the query. </summary>
        public double Score { get; }
        /// <summary> The relevance score computed by the semantic ranker for the top search results. Search results are sorted by the RerankerScore first and then by the Score. RerankerScore is only returned for queries of type 'semantic'. </summary>
        public double? RerankerScore { get; }
        /// <summary> Text fragments from the document that indicate the matching search terms, organized by each applicable field; null if hit highlighting was not enabled for the query. </summary>
        public IReadOnlyDictionary<string, IList<string>> Highlights { get; }
        /// <summary> Captions are the most representative passages from the document relatively to the search query. They are often used as document summary. Captions are only returned for queries of type 'semantic'. </summary>
        public IReadOnlyList<QueryCaptionResult> Captions { get; }
        /// <summary> Contains debugging information that can be used to further explore your search results. </summary>
        public IReadOnlyList<DocumentDebugInfo> DocumentDebugInfo { get; }
        /// <summary> Additional Properties. </summary>
        public IReadOnlyDictionary<string, object> AdditionalProperties { get; }
    }
}
