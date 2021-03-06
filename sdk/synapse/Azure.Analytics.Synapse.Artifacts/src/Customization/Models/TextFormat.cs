﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The data stored in text format. </summary>
    public partial class TextFormat : DatasetStorageFormat
    {
        /// <summary> Initializes a new instance of TextFormat. </summary>
        public TextFormat()
        {
            Type = "TextFormat";
        }

        /// <summary> The column delimiter. Type: string (or Expression with resultType string). </summary>
        public object ColumnDelimiter { get; }
        /// <summary> The row delimiter. Type: string (or Expression with resultType string). </summary>
        public object RowDelimiter { get; }
        /// <summary> The escape character. Type: string (or Expression with resultType string). </summary>
        public object EscapeChar { get; }
        /// <summary> The quote character. Type: string (or Expression with resultType string). </summary>
        public object QuoteChar { get; }
        /// <summary> The null value string. Type: string (or Expression with resultType string). </summary>
        public object NullValue { get; }
        /// <summary> The code page name of the preferred encoding. If miss, the default value is ΓÇ£utf-8ΓÇ¥, unless BOM denotes another Unicode encoding. Refer to the ΓÇ£NameΓÇ¥ column of the table in the following link to set supported values: https://msdn.microsoft.com/library/system.text.encoding.aspx. Type: string (or Expression with resultType string). </summary>
        public object EncodingName { get; }
        /// <summary> Treat empty column values in the text file as null. The default value is true. Type: boolean (or Expression with resultType boolean). </summary>
        public object TreatEmptyAsNull { get; }
        /// <summary> The number of lines/rows to be skipped when parsing text files. The default value is 0. Type: integer (or Expression with resultType integer). </summary>
        public object SkipLineCount { get; }
        /// <summary> When used as input, treat the first row of data as headers. When used as output,write the headers into the output as the first row of data. The default value is false. Type: boolean (or Expression with resultType boolean). </summary>
        public object FirstRowAsHeader { get; }
    }
}
