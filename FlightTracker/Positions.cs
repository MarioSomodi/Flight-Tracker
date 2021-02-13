using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlightTrackerClassLib;

namespace FlightTracker
{
    public partial class Positions : Form
    {
        //Generating object of needed repository for CRUD operations on the DB and gathering info from API.
        private PositionRepository pR = new PositionRepository();
        //Binding source for the DataGridView.
        private BindingSource _positionsBindingSource = new BindingSource();
        //Constructor for Positions form that fills the binding source with the positions list.
        public Positions()
        {
            InitializeComponent();
            List<Position> p = pR.GetPositionsFromDB();
            if (p.Count > 0)
            {
                _positionsBindingSource.DataSource = p;
            }
            else 
            {
                dataGridViewPositions.Visible = false;
                lblEmptyList.Visible = true;
            }

        }
        //Triggers on form load fills the DataGridView with the binding source and sets the column SortMode to NotSortable so the alligment to center is correct.
        private void Positions_Load(object sender, EventArgs e)
        {
            dataGridViewPositions.DataSource = _positionsBindingSource;
            for (int i = 0; i < dataGridViewPositions.ColumnCount; i++)
            {
                dataGridViewPositions.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
    }
}
