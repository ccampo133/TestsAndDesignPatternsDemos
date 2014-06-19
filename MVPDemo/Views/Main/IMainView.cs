using System;

namespace MVPDemo.Views.Main
{
    public interface IMainView : IView
    {
        string InputText { get; }
        string OutputText { get; set; }
        event EventHandler CapitalizeButtonClicked;
    }
}
