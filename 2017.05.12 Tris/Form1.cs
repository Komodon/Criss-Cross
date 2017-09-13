using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2017._05._12_Tris
{
    public partial class Form1 : Form
    {
        int par;
        bool reset;
        Image cross = Image.FromFile("cross.png");
        Image circle = Image.FromFile("circle.png");


        string simbolo;
        string[,] m = new string[3, 3];
        
        public Form1()
        {
            InitializeComponent();

            dgvCampo.ColumnHeadersVisible = false;
            dgvCampo.RowHeadersVisible = false;
            
            dgvCampo.ReadOnly = true;
            dgvCampo.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCampo.DefaultCellStyle.Font = new Font("Calibri", 20);

            dgvCampo.RowCount = 3;
            for (int i = 0; i < 3; i++) dgvCampo.Rows[i].Height = dgvCampo.Height / 3;
            
            dgvCampo.ColumnCount = 3;
            for (int i = 0; i < 3; i++) dgvCampo.Columns[i].Width = dgvCampo.Width / 3;
            
            InitCampo(ref m);
            CopiaMatGrid(m);

            simbolo = "X";
            reset = false;
        }

        /// <summary>
        /// Inizializza il 'campo' con string vuote
        /// </summary>
        /// <param name="c"></param>
        void InitCampo(ref string[,] m)
        {
            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    m[r, c] = "";
                }
            }
        }

        /// <summary>
        /// Controlla se c'è un Vincitore
        /// </summary>
        /// <param name="c"></param>
        /// <param name="simbolo"></param>
        /// <returns></returns>
        bool ControllaVittoria(string[,] c, string simbolo)
        {
            par = 0;

            if (c[0, 0] == simbolo && c[0, 1] == simbolo && c[0, 2] == simbolo) return true;
            if (c[1, 0] == simbolo && c[1, 1] == simbolo && c[1, 2] == simbolo) return true;
            if (c[2, 0] == simbolo && c[2, 1] == simbolo && c[2, 2] == simbolo) return true;
            if (c[0, 0] == simbolo && c[1, 0] == simbolo && c[2, 0] == simbolo) return true;
            if (c[0, 1] == simbolo && c[1, 1] == simbolo && c[2, 1] == simbolo) return true; 
            if (c[0, 2] == simbolo && c[1, 2] == simbolo && c[2, 2] == simbolo) return true;
            if (c[0, 0] == simbolo && c[1, 1] == simbolo && c[2, 2] == simbolo) return true;
            if (c[0, 2] == simbolo && c[1, 1] == simbolo && c[2, 0] == simbolo) return true;

            for (int r = 0; r < 3; r++) { for (int co = 0; co < 3; co++) { if(m[r,co] != "") par++; } }

            return false;
        }

        /// <summary>
        /// Copia il valore della Matrice all'interno della DataGridView
        /// </summary>
        /// <param name="m"></param>
        void CopiaMatGrid(string[,] m)
        {
            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    dgvCampo.Rows[r].Cells[c].Value = m[r, c];
                }
            }
        }
        
        private void dgvCampo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (m[e.RowIndex, e.ColumnIndex] == "")
            {
                reset = true;
                m[e.RowIndex, e.ColumnIndex] = simbolo;

                if (ControllaVittoria(m, simbolo) && par < 9)
                {
                    MessageBox.Show("Giocatore " + simbolo + " ha Vinto!");
                    Restart();
                }
                else if (par >= 9)
                {
                    MessageBox.Show("PARITA'!");
                    Restart();
                }

                if (simbolo == "X" && reset) simbolo = "O"; else simbolo = "X";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Restart();
        }

        /// <summary>
        /// Ricomincia da Capo
        /// </summary>
        void Restart()
        {
            Form1 test = new Form1();
            test.Show();
            this.Hide();
        }

        private void dgvCampo_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            Rectangle cell = e.CellBounds;
            
            if (m[e.RowIndex, e.ColumnIndex] == "X")
                e.Graphics.DrawImage(cross, cell);

            else
            if (m[e.RowIndex, e.ColumnIndex] == "O")
                e.Graphics.DrawImage(circle, cell);

            else e.Graphics.FillRectangle(Brushes.White, cell);
            

            e.Graphics.DrawRectangle(Pens.Black, cell);
            e.Handled = true;
        }
    }
}