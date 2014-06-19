using System;
using MVPDemo.Views;

namespace MVPDemo.Presenters
{
    /*
     * This abstract, generic class is used as the base presenter
     * class from which all presenters should inherit from. It
     * provides a default constructor as well as a default view
     * property. The view type is generic, but there is a constraint 
     * on that enforces that the type of view must implement the 
     * IView interface (which is the basic view interface used by 
     * all views). 
     * 
     * It provides basic implementations for Initialize and Load
     * event handlers, which are the events specified by IView.
     * Any class that inherits from BasePresenter can override
     * these implementations however, to handle their own loading
     * and initialization.
     * 
     */
    public abstract class BasePresenter<TView> where TView : class, IView
    {
        public TView View { get; private set; }

        // Default constructor
        protected BasePresenter(TView view)
        {
            if(view == null)
                throw new ArgumentNullException("view");

            View = view;
            View.Initialize += HandleInitialize;
            View.LoadView += HandleLoadView;
        }

        // In many cases, these methods will never need to do anything because
        // the view may not have load/initialize events. Because of this, set 
        // the default implementations to do nothing. In the case that these 
        // events do exist and need to be handled, just let the child classes 
        // deal with the implementation.
        protected virtual void HandleInitialize(object sender, EventArgs e) {}
        protected virtual void HandleLoadView(object sender, EventArgs e){}
    }
}
