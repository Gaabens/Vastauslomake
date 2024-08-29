namespace Vastauslomake
{
    public partial class VastauslomakeForm : Form

        
    {
        int laskuri = 0;
        int oikein = 0;
        string[] oikeatVastaukset = new string[] { "B", "D", "A", "A", "C", "A", "B", "A", "C", "D" };
        string[] vastaukset = new string[10];

        public VastauslomakeForm()
        {
            InitializeComponent();

            VastausARB.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
        }

        private void VastauslomakeForm_Load(object sender, EventArgs e)
        {

        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton && laskuri < 10) 
            {

            }
        }

    }
}