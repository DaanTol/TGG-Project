﻿using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TGG_Logic;
using TGG_Model;

namespace TGG_UI
{
    public partial class AddEditTicket : Form
    {
        private TicketService ticketService = new TicketService();
        private EmployeeService employeeService = new EmployeeService();
        private List<Employee> employees;
        private Employee employee;
        private Ticket ticket;

        public AddEditTicket(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            ValidateIsNotSDEmployee();
        }

        public AddEditTicket(Employee employee, Ticket ticket)
        {
            InitializeComponent();
            this.employee = employee;
            this.ticket = ticket;
            ValidateIsNotSDEmployee();
            FillControlsWithTicketInformation(ticket);
        }

        private void FillControlsWithTicketInformation(Ticket ticket)
        {
            dateTimePickerTimeReported.Value = ticket.TimeAdded;
            dateTimePickerDeadline.Value = ticket.TimeDeadline;
            comboBoxEmployeeId.SelectedIndex = comboBoxEmployeeId.FindString(ticket.EmployeeID.ToString());
            textBoxTitle.Text = ticket.Title;
            comboBoxStatus.SelectedIndex = comboBoxStatus.FindString(ticket.TGGStatus.ToString());
            comboBoxPrioLevel.SelectedIndex = comboBoxPrioLevel.FindString(ticket.PriorityLevel.ToString());
            richTextBoxDescription.Text = ticket.Description;
            labelTitleAddEditTickets.Text = "Update Ticket:";
            buttonCreateUpdate.Text = "UPDATE";
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if(ticket == null)
            {
                CreateTicket();
            }
            else
            {
                UpdateTicket();
            }

            CloseForm();
        }
        private void CreateTicket()
        {
            Ticket ticket = new Ticket();

            try
            {
                ValueToTickets(ticket);

                ticketService.AddTicket(ticket);
                MessageBox.Show("The ticket has been successfully added");
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong with adding a ticket, please try and contact admin");
            }
        }
        private void UpdateTicket()
        {
            try
            {
                ValueToTickets(ticket);

                ticketService.UpdateTicketByElement(ticket);
                MessageBox.Show("Ticket Updated!");
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong with adding a ticket, please try and contact admin");
            }
        }

        private void AddTickets_Load(object sender, EventArgs e)
        {
            //put enum values in combobox
            comboBoxPrioLevel.DataSource = Enum.GetValues(typeof(TGGPriorityLevel));
            comboBoxStatus.DataSource = Enum.GetValues(typeof(TGGStatus));
        }

        private void CloseForm()
        {
            this.Close();
        }

        private void ValidateIsNotSDEmployee()
        {
            //if the employee is not a service desk employee
            if (!employee.IsSDEmployee)
            {
                //add current employee id as only option
                comboBoxEmployeeId.Items.Add(employee.EmployeeId);
            } else {
                EmployeesToComboBox();
            }
        }

        private void EmployeesToComboBox()
        {
            employees = employeeService.GetAllEmployees();
            foreach (Employee employee in employees)
            {
                //add all employees from db to combobox
                comboBoxEmployeeId.Items.Add(employee.EmployeeId);
            }
        }

        private void ValueToTickets(Ticket ticket)
        {
            //check if strig is empty or not
            if (String.IsNullOrEmpty(comboBoxEmployeeId.Text) || String.IsNullOrEmpty(textBoxTitle.Text))
            {
                MessageBox.Show("Please enter a employee id and title");
                return;
            }

            //give textbox, timePicker, combox values to Model below
            ticket.EmployeeID = int.Parse(comboBoxEmployeeId.Text);
            ticket.Title = textBoxTitle.Text;
            ticket.Description = richTextBoxDescription.Text;
            ticket.TimeAdded = dateTimePickerTimeReported.Value;
            ticket.TimeDeadline = dateTimePickerDeadline.Value;
            ticket.PriorityLevel = (TGGPriorityLevel)Enum.Parse(typeof(TGGPriorityLevel), comboBoxPrioLevel.SelectedIndex.ToString());
            ticket.TGGStatus = (TGGStatus)Enum.Parse(typeof(TGGStatus), comboBoxPrioLevel.SelectedIndex.ToString());
        }

        private void AddEditTicket_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawRectangle(Pens.White, new Rectangle(0, 0, Width - 1, Height - 1));
        }
    }
}
