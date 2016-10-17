using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpPDFLabel.Labels.LetterLabels.Avery
{
	/// <summary>
	/// Dimensions: 41.275mm x 25.4mm 
	/// Per Sheet: 30 per sheet 
	/// Inkjet code: J8160
	/// </summary>
	public class L8160 : Label
    {
        public L8160()
        {
            _Width = 66.675;
            _Height = 25.4;
            _HorizontalGapWidth = 2.5;
            _VerticalGapHeight = 0;
            
            _PageMarginTop = 12.7;
            _PageMarginBottom = 10.6;
            _PageMarginLeft = 6.5;
            _PageMarginRight = 7.9;

            PageSize = Enums.PageSize.Letter;
            LabelsPerRow = 3;
            LabelRowsPerPage = 10;
        }
    }
}
