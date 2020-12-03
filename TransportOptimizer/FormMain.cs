using System;
using System.Drawing;
using System.Windows.Forms;

namespace TransportOptimizer
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            UpdateProblemGridRowCount();
            UpdateProblemGridColumnCount();
        }

        private void ButtonSolve_Click(object sender, EventArgs e)
        {
            Solve();
        }

        private void Solve()
        {
            if (!ValidateGrid()) return;            
            DisableControls();
            ResolveProblemType(new Problem(ReadGridIntoArray()));
            var optimizer = new Optimizer(ReadGridIntoArray());
            var result = optimizer.Solve();
            DisplayResult(result);            
        }        

        private void DisableControls()
        {
            numUpDownConsumerCount.Enabled = false;
            numUpDownSupplierCount.Enabled = false;
            buttonSolve.Enabled = false;
        }

        private bool ValidateGrid()
        {
            for (int row = 0; row < dataGridViewProblem.Rows.Count; row++)
            {
                for (int col = 0; col < dataGridViewProblem.Columns.Count; col++)
                {
                    var cell = dataGridViewProblem.Rows[row].Cells[col];

                    if (cell.RowIndex == dataGridViewProblem.Rows.Count -1 && cell.ColumnIndex == dataGridViewProblem.Columns.Count - 1)                    
                        continue; // Utolsó cella - nem kell ellenőrizni

                    if (cell.Value == null || cell.Value == DBNull.Value || string.IsNullOrWhiteSpace(cell.Value.ToString()))
                    {
                        ShowError(cell);
                        return false;
                    }

                    var result = int.TryParse(cell.Value.ToString(), out var value);
                    if (result == false || value < 1)
                    {
                        ShowError(cell);
                        return false;
                    }
                }
            }
            return true;
        }       

        private static void ShowError(DataGridViewCell cell)
        {
            MessageBox.Show($"Hibás cellaérték ({cell.RowIndex +1 };{cell.ColumnIndex +1})\nNem lehet üres cella,\ncsak pozitív egész értékű!",
                                        "Hiba történt", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ResolveProblemType(Problem problem)
        {
            if (problem.TotalSupply == problem.TotalDemand) return; // Zárt probléma                

            if (problem.TotalSupply < problem.TotalDemand)  // Hiány - Dummy eladó hozzáadása
            {
                var row = new DataGridViewRow();
                row.HeaderCell.Value = "Sdummy";
                row.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                for (int i = 0; i < dataGridViewProblem.ColumnCount; i++)                    
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = 0 });

                row.Cells[row.Cells.Count - 1].Value = problem.TotalDemand - problem.TotalSupply;                
                dataGridViewProblem.Rows.Insert(dataGridViewProblem.RowCount - 1, row);
            }            
            else // Többlet - Dummy vevő hozzáadása
            {
                var col = new DataGridViewTextBoxColumn();
                col.HeaderText = "Ddummy";                
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dataGridViewProblem.Columns.Insert(dataGridViewProblem.ColumnCount - 1, col);
                for (int i = 0; i < dataGridViewProblem.RowCount - 1; i++)                
                    dataGridViewProblem[dataGridViewProblem.ColumnCount - 2, i].Value = 0;
                
                dataGridViewProblem[dataGridViewProblem.ColumnCount - 2, dataGridViewProblem.RowCount - 1]
                    .Value = problem.TotalSupply - problem.TotalDemand;
            }            
        }

        private string[,] ReadGridIntoArray()
        {
            string[,] data = new string[dataGridViewProblem.Rows.Count, dataGridViewProblem.Columns.Count];
            for (int i = 0; i < data.GetLength(0); i++)
                for (int j = 0; j < data.GetLength(1); j++)
                    data[i, j] = dataGridViewProblem.Rows[i].Cells[j].Value?.ToString();
            return data;
        }

        private void DisplayResult(Result result)
        {
            UpdateResultPanel(result);
            UpdateSolutionGrid(result);
        }

        private void UpdateResultPanel(Result result)
        {
            switch (result.Status)
            {
                case "Optimal": textBoxSolution.BackColor = Color.Green; break;
                case "Feasible": textBoxSolution.BackColor = Color.GreenYellow; break;
                default: textBoxSolution.BackColor = Color.Red; break;
            }

            textBoxSolution.Text = result.Status;
            labelError.Text = result.Error;
            textBoxCost.Text = result.Cost.ToString();
        }

        private void UpdateSolutionGrid(Result result)
        {
            DrawSolutionGrid(result);
            UpdateSolutionGridHeaderTexts();
        }

        private void DrawSolutionGrid(Result result)
        {
            int height = result.Solution.Length;
            int width = result.Solution[0].Length;
            dataGridViewSolution.ColumnCount = width;
            for (int r = 0; r < height; r++)
            {
                var row = new DataGridViewRow();
                row.CreateCells(dataGridViewSolution);
                for (int c = 0; c < width; c++)
                    row.Cells[c].Value = result.Solution[r][c];
                dataGridViewSolution.Rows.Add(row);
            }
        }

        private void UpdateSolutionGridHeaderTexts()
        {
            for (int i = 0; i < dataGridViewSolution.RowCount; i++)
                dataGridViewSolution.Rows[i].HeaderCell.Value = ($"S{i + 1}");

            for (int i = 0; i < dataGridViewSolution.ColumnCount; i++)
                dataGridViewSolution.Columns[i].HeaderCell.Value = ($"D{i + 1}");

            var problemLastRowHeaderName = dataGridViewProblem.Rows[dataGridViewProblem.Rows.Count - 2].HeaderCell.Value.ToString();
            if (problemLastRowHeaderName.Equals("Sdummy"))
                dataGridViewSolution.Rows[dataGridViewSolution.Rows.Count - 1].HeaderCell.Value = problemLastRowHeaderName;

            var problemLastColHeaderName = dataGridViewProblem.Columns[dataGridViewProblem.Columns.Count - 2].HeaderCell.Value.ToString();
            if (problemLastColHeaderName.Equals("Ddummy"))
                dataGridViewSolution.Columns[dataGridViewSolution.Columns.Count - 1].HeaderCell.Value = problemLastColHeaderName;
        }        

        private void NumUpDownShopCount_ValueChanged(object sender, EventArgs e)
        {
            UpdateProblemGridRowCount();
        }

        private void UpdateProblemGridRowCount()
        {
            dataGridViewProblem.RowCount = Convert.ToInt32(numUpDownSupplierCount.Value + 1);
            for (int i = 0; i < dataGridViewProblem.RowCount - 1; i++)
                dataGridViewProblem.Rows[i].HeaderCell.Value = ($"S{i + 1}");

            foreach (DataGridViewRow row in dataGridViewProblem.Rows)            
                row.ReadOnly = false;            

            dataGridViewProblem.Rows[dataGridViewProblem.RowCount - 1].HeaderCell.Value = "Kereslet";
        }

        private void NumUpDownCustomerCount_ValueChanged(object sender, EventArgs e)
        {
            UpdateProblemGridColumnCount();
        }

        private void UpdateProblemGridColumnCount()
        {
            dataGridViewProblem.ColumnCount = Convert.ToInt32(numUpDownConsumerCount.Value + 1);
            for (int i = 0; i < dataGridViewProblem.ColumnCount - 1; i++)
                dataGridViewProblem.Columns[i].HeaderCell.Value = ($"D{i + 1}");

            foreach (DataGridViewColumn column in dataGridViewProblem.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
                column.ReadOnly = false;
                column.Width = 40;
            }

            dataGridViewProblem.Columns[dataGridViewProblem.ColumnCount - 1].HeaderCell.Value = "Kínálat";
            dataGridViewProblem.Columns[dataGridViewProblem.ColumnCount - 1].Width = 100;
        }        

        private void ButtonResetForm_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetForm()
        {
            numUpDownConsumerCount.Value = 2;
            numUpDownSupplierCount.Value = 2;
            textBoxCost.Text = "";
            textBoxSolution.Text = "";
            labelError.Text = "";
            textBoxSolution.BackColor = Color.FromArgb(64, 64, 64);            
            dataGridViewSolution.Rows.Clear();
            dataGridViewSolution.Columns.Clear();
            ResetProblemGridCells();
            EnableControls();
        }        

        private void ResetProblemGridCells()
        {
            dataGridViewProblem.Rows.Clear();
            dataGridViewProblem.Columns.Clear();
            UpdateProblemGridRowCount();
            UpdateProblemGridColumnCount();
            foreach (DataGridViewRow row in dataGridViewProblem.Rows)
                row.ReadOnly = false;
        }

        private void EnableControls()
        {
            numUpDownConsumerCount.Enabled = true;
            numUpDownSupplierCount.Enabled = true;
            buttonSolve.Enabled = true;
        }

        private void DataGridViewProblem_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.CellStyle.BackColor = Color.DarkGray;
            e.CellStyle.ForeColor = Color.White;

            if (e.ColumnIndex == dataGridViewProblem.Columns.Count - 1)
            {
                e.CellStyle.BackColor = Color.LightYellow;
                e.CellStyle.ForeColor = Color.Black;
            }

            if (e.RowIndex == dataGridViewProblem.Rows.Count - 1)
            {
                e.CellStyle.BackColor = Color.LightBlue;
                e.CellStyle.ForeColor = Color.Black;
            }                

            if ((e.ColumnIndex == dataGridViewProblem.Columns.Count - 1) && (e.RowIndex == dataGridViewProblem.Rows.Count - 1))
            {
                e.CellStyle.BackColor = Color.Black;
                dataGridViewProblem.ReadOnly = false;
                dataGridViewProblem.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly = true;
            }                
        }

        private void DataGridViewProblem_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            if (e.Column.Index == dataGridViewProblem.Columns.Count - 1)
                e.Column.Width = 100;
            else e.Column.Width = 60;
        }

        private void DataGridViewProblem_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {            
            DataGridViewCell cell = dataGridViewProblem.CurrentCell;
            if (cell == null)  return;

            var lastColumn = dataGridViewProblem.Columns.Count - 1;
            var lastRow = dataGridViewProblem.Rows.Count - 1;
            if (cell.ColumnIndex != lastColumn && cell.RowIndex != lastRow && cell.Value?.ToString() == "x")
                cell.Value = int.MaxValue;

            if (!int.TryParse(cell.Value?.ToString(), out int newInteger) || newInteger < 0)
                cell.Value = "";
        }

        private void DataGridViewSolution_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.CellStyle.BackColor = Color.DarkGray;
            if (e.Value == null) return;            

            var cellValue = int.Parse(e.Value.ToString());
            if (cellValue > 0)
            {
                e.CellStyle.BackColor = Color.LightGreen;
                e.CellStyle.ForeColor = Color.Black;
            }                        
        }

        private void DataGridViewSolution_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewSolution.ClearSelection();
        }

        private void DataGridViewSolution_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.Width = 40;
        }

        private void TextBoxSolution_BackColorChanged(object sender, EventArgs e)
        {
            panelSolutionBackground.BackColor = textBoxSolution.BackColor;
        }

        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            var form = new FormHelp();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }
    }
}
