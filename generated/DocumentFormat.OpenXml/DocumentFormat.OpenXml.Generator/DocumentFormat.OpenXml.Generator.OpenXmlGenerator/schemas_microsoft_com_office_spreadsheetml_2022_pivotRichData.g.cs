﻿// <auto-generated/>

// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office.SpreadSheetML.Y2022.PivotRichData
{
    /// <summary>
    /// <para>Defines the PivotCacheRichInfo Class.</para>
    /// <para>This class is available in Microsoft365 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xprd:richInfo.</para>
    /// </summary>
    public partial class PivotCacheRichInfo : OpenXmlLeafElement
    {
        #pragma warning disable CS0109
        internal static readonly new OpenXmlQualifiedName ElementQName = new("http://schemas.microsoft.com/office/spreadsheetml/2022/pivotRichData", "richInfo");
        internal static readonly new OpenXmlQualifiedName ElementTypeName = new("http://schemas.microsoft.com/office/spreadsheetml/2022/pivotRichData", "CT_PivotCacheRichInfo");
        internal static readonly new OpenXmlSchemaType ElementType = new(ElementQName, ElementTypeName);
        #pragma warning restore CS0109

        /// <summary>
        /// Initializes a new instance of the PivotCacheRichInfo class.
        /// </summary>
        public PivotCacheRichInfo() : base()
        {
        }

        /// <summary>
        /// <para>pivotCacheGuid, this property is only available in Microsoft365 and later.</para>
        /// <para>Represents the following attribute in the schema: pivotCacheGuid</para>
        /// </summary>
        public StringValue? PivotCacheGuid
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>pivotIgnoreInvalidCache, this property is only available in Microsoft365 and later.</para>
        /// <para>Represents the following attribute in the schema: pivotIgnoreInvalidCache</para>
        /// </summary>
        public BooleanValue? PivotIgnoreInvalidCache
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id, this property is only available in Microsoft365 and later.</para>
        /// <para>Represents the following attribute in the schema: r:id</para>
        /// </summary>
        /// <remarks>
        /// xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
        /// </remarks>
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(ElementType);
            builder.Availability = FileFormatVersions.Microsoft365;
            builder.AddElement<PivotCacheRichInfo>()
                .AddAttribute("pivotCacheGuid", a => a.PivotCacheGuid, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
                })
                .AddAttribute("pivotIgnoreInvalidCache", a => a.PivotIgnoreInvalidCache)
                .AddAttribute("r:id", a => a.Id);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotCacheRichInfo>(deep);
    }
}