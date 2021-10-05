using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutlookTest.Core
{
    public interface IRegionDialogService
    {
        void Show(string name, IDialogParameters dialogParameters, Action<IDialogResult> callback);
    }
}