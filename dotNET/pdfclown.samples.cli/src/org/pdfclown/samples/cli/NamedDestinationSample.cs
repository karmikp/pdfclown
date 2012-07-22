using org.pdfclown.documents;
using org.pdfclown.documents.contents;
using org.pdfclown.documents.contents.composition;
using org.pdfclown.documents.contents.objects;
using org.pdfclown.documents.interaction.navigation.document;
using org.pdfclown.files;
using org.pdfclown.objects;

using System;
using System.Collections.Generic;
using System.Drawing;

namespace org.pdfclown.samples.cli
{
  /**
    <summary>This sample demonstrates how to manipulate the named destinations within a PDF document.</summary>
  */
  public class NamedDestinationSample
    : Sample
  {
    public override bool Run(
      )
    {
      // 1. Opening the PDF file...
      string filePath = PromptFileChoice("Please select a PDF file");
      File file = new File(filePath);
      Document document = file.Document;
      Pages pages = document.Pages;

      // 2. Inserting page destinations...
      Names names = document.Names;
      if(names == null)
      {document.Names = names = new Names(document);}

      NamedDestinations destinations = names.Destinations;
      if(destinations == null)
      {names.Destinations = destinations = new NamedDestinations(document);}

      destinations["d31e1142"] = new LocalDestination(pages[0]);
      if(pages.Count > 1)
      {
        destinations["N84afaba6"] = new LocalDestination(pages[1], Destination.ModeEnum.FitHorizontal, 0, null);
        destinations["d38e1142"] = new LocalDestination(pages[1]);
        destinations["M38e1142"] = new LocalDestination(pages[1]);
        destinations["d3A8e1142"] = new LocalDestination(pages[1]);
        destinations["z38e1142"] = new LocalDestination(pages[1]);
        destinations["f38e1142"] = new LocalDestination(pages[1]);
        destinations["e38e1142"] = new LocalDestination(pages[1]);
        destinations["B84afaba6"] = new LocalDestination(pages[1]);
        destinations["Z38e1142"] = new LocalDestination(pages[1]);

        if(pages.Count > 2)
        {destinations["1845505298"] = new LocalDestination(pages[2], Destination.ModeEnum.XYZ, new PointF(50, Single.NaN), null);}
      }

      // 3. Serialize the PDF file!
      Serialize(file, "Named destinations", "manipulating named destinations");

      return true;
    }
  }
}