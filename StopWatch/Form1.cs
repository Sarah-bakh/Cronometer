namespace StopWatch
{
    public partial class frmStopWatch : Form
    {
        public frmStopWatch()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StopWatch.Visible = true;
            Clock.Visible = false;
            stTimer.Enabled = true;
            clTimer.Enabled = false;

            stSecond.Text = "0";
            stMinutes.Text = "0";
            stHours.Text = "0";
        }
        int intSecond = 0;
        int intMiutes = 0;
        int intHour = 0;
        private void stTimer_Tick(object sender, EventArgs e)
        {
            intSecond++;
            if (intSecond > 59)
            {
                {
                    intMiutes++;
                    intSecond = 0;
                }
                if (intMiutes > 59)
                {
                    intHour++;
                    intMiutes = 0;
                }
            }

            stHours.Text = intHour.ToString();
            stMinutes.Text = intMiutes.ToString();
            stSecond.Text = intSecond.ToString();
        }

        private void btnClock_Click(object sender, EventArgs e)
        {
            btnStart.Enabled=false;
            btnStop_Resum.Enabled=false;
            btnReset.Enabled=false;
            StopWatch.Visible = false;
            Clock.Visible = true;
            stTimer.Enabled = false;
            clTimer.Enabled = true;

            clHours.Text = DateTime.Now.Hour.ToString();
            clMinuts.Text = DateTime.Now.Minute.ToString();
            clSecond.Text = DateTime.Now.Second.ToString();
        }

        private void clTimer_Tick(object sender, EventArgs e)
        {
            clHours.Text = DateTime.Now.Hour.ToString();
            clMinuts.Text = DateTime.Now.Minute.ToString();
            clSecond.Text = DateTime.Now.Second.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool sw = true;
        private void btnSwap_Click(object sender, EventArgs e)
        {
            btnStart.Enabled=true;
            btnStop_Resum.Enabled = true;
            btnReset.Enabled=true;
            
            if (clTimer.Enabled==true) { sw = false; }
            if (sw)
            {

                sw = false;
                Clock.Visible = true;
                StopWatch.Visible = false;
                clTimer.Enabled = true;

                clHours.Text = DateTime.Now.Hour.ToString();
                clMinuts.Text = DateTime.Now.Minute.ToString();
                clSecond.Text = DateTime.Now.Second.ToString();

            }
            else
            {

                sw = true;
                Clock.Visible = false;
                StopWatch.Visible = true;
                clTimer.Enabled = false;
                stTimer.Enabled = true;
            }
        }
        public bool sr = true;
        private void btnStop_Resum_Click(object sender, EventArgs e)
        {

            if (sr)
            {
                btnStop_Resum.Text = "Resum";
                btnStart.Enabled = false;
                StopWatch.Visible = true;
                Clock.Visible = false;
                stTimer.Enabled = false;
                sr = false;
            }
            else
            {
                btnStop_Resum.Text = "Stop";
                btnStart.Enabled = false;
                StopWatch.Visible = true;
                Clock.Visible = false;
                stTimer.Enabled = true;
                sr = true;

            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnStop_Resum.Enabled = false;
            StopWatch.Visible = true;
            Clock.Visible = false;
            stTimer.Enabled=false;
            stSecond.Text = "0";
            stMinutes.Text = "0";
            stHours.Text = "0";
            intSecond = 0;
            intMiutes = 0;
            intHour = 0;
        }
    }
}
