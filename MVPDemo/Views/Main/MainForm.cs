using System;
using System.Windows.Forms;
using MVPDemo.Models;
using MVPDemo.Presenters;

namespace MVPDemo.Views.Main
{
    public partial class MainForm : Form, IMainView
    {
        private MainPresenter Presenter { get; set; }

        public string InputText
        {
            get { return inputTextBox.Text; }
        }

        public string OutputText
        {
            get { return outputTextLabel.Text; }
            set { outputTextLabel.Text = value; }
        }

        /*
         * This form is an example of a view in production. Notice
         * that the view doesn't contain any logic code at all, but
         * instead only deals with firing events and wiring up property
         * getter/setters. The constructor of this view initiates the
         * proper presenter, as well as any of the presenter's
         * dependencies (models), and passes itself to the presenter
         * as an interface. In this particular design, the view is
         * the entry point, but another design approach would be to
         * use the presenter as the entry point (in Program.cs) and
         * have it show the view. I like the view-first approach
         * personally, for WinForms, simply because it is a more
         * natural approach to the architecture.
         * 
         * All of the proper logic takes place in the presenter and
         * model code files. This view code itself does not really
         * need to be unit tested because it is just a bunch of
         * property and field assignments, and event wiring. These
         * sorts of tests can be covered by integration tests, i.e.
         * a tester clicks on a button and notices it does nothing
         * but all unit tests pass (which may indicate that the 
         * event wiring is not set up correctly).
         * 
         */
        public MainForm()
        {
            InitializeComponent();
            Presenter = new MainPresenter(this, new Capitalizer());
        }

        public event EventHandler Initialize;
        private void OnInitialize(EventArgs e)
        {
            if (Initialize != null)
                Initialize(this, e);
        }

        public event EventHandler LoadView;
        private void OnLoadView(EventArgs e)
        {
            if (LoadView != null)
                LoadView(this, e);
        }

        public event EventHandler CapitalizeButtonClicked;
        private void OnCapitalizeButtonClicked(EventArgs e)
        {
            if (CapitalizeButtonClicked != null)
                CapitalizeButtonClicked(this, e);
        }

        private void capitalizeButton_Click(object sender, EventArgs e)
        {
            OnCapitalizeButtonClicked(e);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            OnLoadView(e);   // Load the view first.
            OnInitialize(e); // Initalize the view after loading is complete.
        }
    }
}
