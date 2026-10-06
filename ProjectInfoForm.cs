using System;
using System.Windows.Forms;

namespace OliveBranchBakes
{
    public partial class ProjectInfoForm : Form
    {
        public ProjectInfoForm()
        {
            InitializeComponent();

            lblInfo.Text =
                "Project Name: Olive Branch Bakes" +
                "\n\nStudent: Elias Afangideh" +
                "\n\nPhase: Phase 1 - Problem Analysis" +
                "\n\nClass: CIS 211 Object-Oriented Programming" +
                "\n\nDate: " + DateTime.Today.ToShortDateString() +
                "\n\nDescription: Bakery order management application that tracks customers, orders, allergies, and order status.";
        }
    }
}