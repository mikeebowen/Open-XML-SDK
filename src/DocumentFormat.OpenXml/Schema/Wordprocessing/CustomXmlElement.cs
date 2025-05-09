﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Validation.Schema;

namespace DocumentFormat.OpenXml.Wordprocessing
{
    /// <summary>
    /// Defines CustomXmlElement - the base class for the customXml elements.
    /// </summary>
    public abstract class CustomXmlElement : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the CustomXmlElement class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected CustomXmlElement(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
            : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CustomXmlElement class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected CustomXmlElement(params OpenXmlElement[] childElements)
            : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CustomXmlBlock class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        protected CustomXmlElement(string outerXml)
            : base(outerXml)
        {
        }

        /// <summary>
        /// Gets or sets the custom XML Markup Namespace.
        /// </summary>
        /// <remarks>
        /// Represents the attribute in schema: w:uri.
        /// xmlns:w=http://schemas.openxmlformats.org/wordprocessingml/2006/main.
        /// </remarks>
        public StringValue? Uri
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// Gets or sets the element name.
        /// </summary>
        /// <remarks>
        /// Represents the attribute in schema: w:element.
        /// xmlns:w=http://schemas.openxmlformats.org/wordprocessingml/2006/main.
        /// </remarks>
        public StringValue? Element
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// Gets or sets the CustomXmlProperties which represents the element tag in schema: w:customXmlPr.
        /// </summary>
        /// <remarks>
        /// xmlns:w = http://schemas.openxmlformats.org/wordprocessingml/2006/main.
        /// </remarks>
        public CustomXmlProperties? CustomXmlProperties
        {
            get => GetElement(CustomXmlProperties.ElementType) as CustomXmlProperties;
            set => SetElement(value, CustomXmlProperties.ElementType);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);

            builder.AddElement<CustomXmlElement>()
                .AddAttribute("uri", a => a.Uri)
                .AddAttribute("w:element", a => a.Element, a =>
                {
                    a.AddValidator(new StringValidator { IsNcName = true });
                });

            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 0, 1)
            {
                new ElementParticle(CustomXmlProperties.ElementType, 0, 1),
            };
        }
    }
}
