using Infragistics.Controls.Editors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutlookTest.Core
{
    public interface ISupportRichText
    {
        XamRichTextEditor RichTextEditor { get; set; }
    }
}
