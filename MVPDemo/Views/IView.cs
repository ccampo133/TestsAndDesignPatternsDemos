using System;

namespace MVPDemo.Views
{
    // This is the base interface for all views.
    public interface IView
    {
        event EventHandler Initialize;
        event EventHandler LoadView;
    }
}
