// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="CellsSignImageOptionsData.cs">
//  Copyright (c) 2003-2018 Aspose Pty Ltd
// </copyright>
// <summary>
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GroupDocs.Signature.Cloud.Sdk.Model 
{
  using System;  
  using System.Collections;
  using System.Collections.Generic;
  using System.Runtime.Serialization;
  using System.Text;
  using Newtonsoft.Json;
  using Newtonsoft.Json.Converters;

  /// <summary>
  /// Represents the Image Sign Options for Cells Documents.
  /// </summary>  
  public class CellsSignImageOptionsData : SignImageOptionsData 
  {                       
        /// <summary>
        /// Gets or sets the space between Sign and worksheet edges. (works ONLY if horizontal or vertical alignment are specified).
        /// </summary>  
        public PaddingData Margin { get; set; }

        /// <summary>
        /// Gets or sets worksheet number for signing. Minimal value is 1.
        /// </summary>  
        public int? DocumentPageNumber { get; set; }

        /// <summary>
        /// Gets or sets the position of the top edge of the Signature area in pixels. This property is mutually exclusive with Row property. If Top property is set RowNumber will be reset to 0.
        /// </summary>  
        public int? Top { get; set; }

        /// <summary>
        /// Gets or sets the position of the left edge of the Signature area in pixels. This property is mutually exclusive with Column property. If Left property is set ColumnNumber will be reset to 0.
        /// </summary>  
        public int? Left { get; set; }

        /// <summary>
        /// Gets or sets worksheet number for signing. DocumentPageNumber parameter contains the same value.
        /// </summary>  
        public int? SheetNumber { get; set; }

        /// <summary>
        /// Gets or sets the top row number of signature (min value is 0). Top parameter contains the same value.
        /// </summary>  
        public int? RowNumber { get; set; }

        /// <summary>
        /// Gets or sets the left column number of signature (min value is 0). Left parameter contains the same value.
        /// </summary>  
        public int? ColumnNumber { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class CellsSignImageOptionsData {\n");
          sb.Append("  Margin: ").Append(this.Margin).Append("\n");
          sb.Append("  DocumentPageNumber: ").Append(this.DocumentPageNumber).Append("\n");
          sb.Append("  Top: ").Append(this.Top).Append("\n");
          sb.Append("  Left: ").Append(this.Left).Append("\n");
          sb.Append("  SheetNumber: ").Append(this.SheetNumber).Append("\n");
          sb.Append("  RowNumber: ").Append(this.RowNumber).Append("\n");
          sb.Append("  ColumnNumber: ").Append(this.ColumnNumber).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
