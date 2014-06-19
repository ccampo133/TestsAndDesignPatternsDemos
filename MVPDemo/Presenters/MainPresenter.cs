using System;
using MVPDemo.Models;
using MVPDemo.Views.Main;

namespace MVPDemo.Presenters
{
    public class MainPresenter : BasePresenter<IMainView>
    {
        private readonly ICapitalizer capitalizer;
        public bool ViewLoaded { get; set; }

        public MainPresenter(IMainView view, ICapitalizer capitalizer) : base(view)
        {
            this.capitalizer = capitalizer;

            // Wire up event handlers
            View.CapitalizeButtonClicked += HandleCapitalizeButtonClicked;
        }

        protected override void HandleInitialize(object sender, EventArgs e)
        {
            // Initialize the output text to "---", instead of the 
            // compile time value of "outputTextLabel";
            View.OutputText = "---";
        }

        protected override void HandleLoadView(object sender, EventArgs e)
        {
            // ... some code that loads stuff for this view ...
            ViewLoaded = true;

            // In the case that loading is unnecessary, we don't need
            // to override this method and instead can just use the
            // default implementation in the BasePresenter class.
        }

        private void HandleCapitalizeButtonClicked(object sender, EventArgs e)
        {
            string input = View.InputText;

            // Use the model (capitalizer) to get the output data to
            // show to the view.
            View.OutputText = capitalizer.Capitalize(input);
        }
    }
}
