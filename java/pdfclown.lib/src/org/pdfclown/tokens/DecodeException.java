/*
  Copyright 2015 Stefano Chizzolini. http://www.pdfclown.org

  Contributors:
    * Stefano Chizzolini (original code developer, http://www.stefanochizzolini.it)

  This file should be part of the source code distribution of "PDF Clown library"
  (the Program): see the accompanying README files for more info.

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

package org.pdfclown.tokens;

/**
  Exception thrown in case of missing code-to-character mapping.
  
  @author Stefano Chizzolini (http://www.stefanochizzolini.it)
  @since 0.1.2.1
  @version 0.1.2.1, 04/08/15
*/
public class DecodeException
  extends RuntimeException
{
  // <static>
  // <fields>
  private static final long serialVersionUID = 1L;
  // </fields>
  // </static>

  // <dynamic>
  // <fields>
  private byte[] bytes;
  private int index;
  // </fields>

  // <constructors>
  public DecodeException(
    byte[] bytes,
    int index
    )
  {
    super(String.format("Missing character mapping for byte sequence starting with %02X at position %s", bytes[index], index));
    this.bytes = bytes;
    this.index = index;
  }
  // </constructors>

  // <interface>
  // <public>
  /**
    Gets the byte array to decode.
  */
  public byte[] getBytes(
    )
  {return bytes;}

  /**
    Gets the position of the missing sequence in the byte array to decode.
  */
  public int getIndex(
    )
  {return index;}
  // </public>
  // </interface>
  // </dynamic>
}