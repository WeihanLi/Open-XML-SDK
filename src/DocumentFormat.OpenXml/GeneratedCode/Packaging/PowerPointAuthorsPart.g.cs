﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

using DocumentFormat.OpenXml.Framework;
using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines the PowerPointAuthorsPart
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2021)]
    [ContentType(ContentTypeConstant)]
    [RelationshipTypeAttribute(RelationshipTypeConstant)]
    public partial class PowerPointAuthorsPart : OpenXmlPart, IFixedContentTypePart
    {
        internal const string ContentTypeConstant = "application/vnd.ms-powerpoint.authors+xml";
        internal const string RelationshipTypeConstant = "http://schemas.microsoft.com/office/2018/10/relationships/authors";
        private DocumentFormat.OpenXml.Office2021.PowerPoint.Comment.AuthorList? _rootElement;

        /// <summary>
        /// Creates an instance of the PowerPointAuthorsPart OpenXmlType
        /// </summary>
        internal protected PowerPointAuthorsPart()
        {
        }

        /// <summary>
        /// Gets or sets the root element of this part.
        /// </summary>
        public DocumentFormat.OpenXml.Office2021.PowerPoint.Comment.AuthorList AuthorList
        {
            get
            {
                if (_rootElement is null)
                {
                    LoadDomTree<DocumentFormat.OpenXml.Office2021.PowerPoint.Comment.AuthorList>();
                }

                return _rootElement!;
            }

            set
            {
                if (value is null)
                {
                    throw new ArgumentNullException(nameof(value));
                }

                SetDomTree(value);
            }
        }

        /// <inheritdoc/>
        public sealed override string ContentType => ContentTypeConstant;

        private protected override OpenXmlPartRootElement? InternalRootElement
        {
            get
            {
                return _rootElement;
            }

            set
            {
                _rootElement = value as DocumentFormat.OpenXml.Office2021.PowerPoint.Comment.AuthorList;
            }
        }

        internal override OpenXmlPartRootElement? PartRootElement => AuthorList;

        /// <inheritdoc/>
        public sealed override string RelationshipType => RelationshipTypeConstant;

        /// <inheritdoc/>
        internal sealed override string TargetName => "authors";

        /// <inheritdoc/>
        internal sealed override string TargetPath => ".";

        internal override bool IsInVersion(FileFormatVersions version)
        {
            return version.AtLeast(FileFormatVersions.Office2021);
        }
    }
}