using SelectedCellsGridViewTelerikBug.Models;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SelectedCellsGridViewTelerikBug
{
    public partial class Form1 : Form
    {
        private const int PEOPLE_COUNT = 20_000;
        private List<Person> _people;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            _people = Seeder.GetPeople(PEOPLE_COUNT).ToList();
            radGridView1.ColumnCount = 6;
            radGridView1.RowCount = _people.Count;
            radGridView1.CurrentRow = radGridView1.Rows[0];
            radGridView1.CurrentColumn = radGridView1.Columns[0];
        }

        private void radGridView1_CellValueNeeded(object sender, Telerik.WinControls.UI.GridViewCellValueEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) 
            {
                return;
            }

            e.Value = _people[e.RowIndex][e.ColumnIndex];
        }

        private void radGridView1_SelectionChanged(object sender, System.EventArgs e)
        {
            lblTotalRows.Text = $"Total rows: {radGridView1.RowCount}";
            lblSelectedCells.Text = $"Selected cells: {radGridView1.SelectedCells.Count}";
        }
    }
}
