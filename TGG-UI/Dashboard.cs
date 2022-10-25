using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TGG_Model;
using TGG_Logic;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TGG_UI
{
    public partial class Dashboard : Form
    {
        private TicketService ticketService;
        private List<Ticket> tickets;
        private Employee employee;
        public Dashboard(Employee employee)
        {
            InitializeComponent();
            ticketService = new TicketService();
            this.employee = employee;
            UpdateDashboard();
            ChangeNavBar();
        }
        private void ChangeNavBar()
        {
            //make the employee management invisible
            if(!employee.IsSDEmployee)
            {
                navigationBarPanel.ColumnStyles[2].Width = 0;
            }
        }

        private void UpdateDashboard()
        {
            tickets = ticketService.GetAllTickets();
            FillCharts();
            FillTopBar();
        }

        public void FillCharts()
        {
            //fill all three charts
            for(int i = Enum.GetValues(typeof(TGGPriorityLevel)).Length - 1; i >= 0; i--)
            {
                FillChart((TGGPriorityLevel)i);
            }
        }
        public void FillChart(TGGPriorityLevel priorityLevel)
        {
            int countOfPendingTickets = tickets.Count(n => n.PriorityLevel == priorityLevel && n.TGGStatus == TGGStatus.Pending);
            int countOfOpenTickets = tickets.Count(n => n.PriorityLevel == priorityLevel && n.TGGStatus == TGGStatus.Open);
            int countOfOverdueTickets = tickets.Count(n => n.PriorityLevel == priorityLevel && n.TimeDeadline <= DateTime.Today);
            ((Chart)(flowLayoutPanelCharts.Controls[(int)priorityLevel])).Series[0].Points[0].SetValueXY(countOfPendingTickets.ToString(), countOfPendingTickets);
            ((Chart)(flowLayoutPanelCharts.Controls[(int)priorityLevel])).Series[0].Points[1].SetValueXY(countOfOpenTickets.ToString(), countOfOpenTickets);
            ((Chart)(flowLayoutPanelCharts.Controls[(int)priorityLevel])).Series[0].Points[2].SetValueXY(countOfOverdueTickets.ToString(), countOfOverdueTickets);
            CheckIfEmptyChart((Chart)(flowLayoutPanelCharts.Controls[(int)priorityLevel]));
        }
        public void CheckIfEmptyChart(Chart chart)
        {
            //check for amount of points that are empty.
            int count = 0;
            foreach(DataPoint dataPoints in chart.Series[0].Points)
            {
                if (dataPoints.YValues[0] == 0)
                {
                    count++;
                }
            }
            //if all of the charts are empty, then tell the user it's empty
            if(count == chart.Series[0].Points.Count())
            {
                TextAnnotation ta = new TextAnnotation();
                ta.X = 30;
                ta.Y = 45;
                ta.Text = $"No tickets found with \n{chart.Titles[0].Text}";
                ta.Font = new Font(Font.FontFamily, 10f);
                chart.Annotations.Add(ta);
            }
        }
        public void FillTopBar()
        {
            labelAmountOverdue.Text = tickets.Count(n => n.TimeDeadline <= DateTime.Today).ToString();
            labelAmountPendingHU.Text = tickets.Count(
                n => n.PriorityLevel == TGGPriorityLevel.High && n.TGGStatus ==TGGStatus.Pending).ToString();
            labelAmountOpenHU.Text = tickets.Count(
                n => n.PriorityLevel == TGGPriorityLevel.High && n.TGGStatus ==TGGStatus.Open).ToString();   
            labelAmountOpenPendingNU.Text = tickets.Count(
                n => n.PriorityLevel <= TGGPriorityLevel.High && (n.TGGStatus ==TGGStatus.Open|| n.TGGStatus ==TGGStatus.Pending)).ToString();
            
        }

        private void buttonShowAllTickets_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TicketsOverview(employee).ShowDialog();
            this.Close();
        }

        private void ticketOverviewButton_Click(object sender, EventArgs e)
        {
            buttonShowAllTickets_Click(sender, e);
        }

        private void employeeOverviewButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Employees(employee).ShowDialog();
            this.Close();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
