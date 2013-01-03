/*
  Copyright 2012 Stefano Chizzolini. http://www.pdfclown.org

  Contributors:
    * Stefano Chizzolini (original code developer, http://www.stefanochizzolini.it)

  This file should be part of the source code distribution of "PDF Clown library" (the
  Program): see the accompanying README files for more info.

  This Program is free software; you can redistribute it and/or modify it under the terms
  of the GNU Lesser General Public License as published by the Free Software Foundation;
  either version 3 of the License, or (at your option) any later version.

  This Program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY,
  either expressed or implied; without even the implied warranty of MERCHANTABILITY or
  FITNESS FOR A PARTICULAR PURPOSE. See the License for more details.

  You should have received a copy of the GNU Lesser General Public License along with this
  Program (see README files); if not, go to the GNU website (http://www.gnu.org/licenses/).

  Redistribution and use, with or without modification, are permitted provided that such
  redistributions retain the above copyright notice, license and disclaimer, along with
  this list of conditions.
*/

using org.pdfclown.documents.interaction.navigation.page;
using org.pdfclown.files;
using org.pdfclown.objects;
using org.pdfclown.util.collections.generic;

using System;
using System.Collections;
using System.Collections.Generic;

namespace org.pdfclown.documents
{
  /**
    <summary>Article threads [PDF:1.7:3.6.1].</summary>
  */
  [PDF(VersionEnum.PDF11)]
  public sealed class Articles
    : Array<Article>
  {
    #region types
    private sealed class ItemWrapper
      : org.pdfclown.objects.Array<Article>.IWrapper<Article>
    {
      public Article Wrap(
        PdfDirectObject baseObject
        )
      {return Article.Wrap(baseObject);}
    }
    #endregion

    #region static
    #region fields
    private static readonly ItemWrapper Wrapper = new ItemWrapper();
    #endregion

    #region interface
    #region public
    public static Articles Wrap(
      PdfDirectObject baseObject
      )
    {return baseObject != null ? new Articles(baseObject) : null;}
    #endregion
    #endregion
    #endregion

    #region dynamic
    #region constructors
    internal Articles(
      PdfDirectObject baseObject
      ) : base(Wrapper, baseObject)
    {}
    #endregion
    #endregion
  }
}