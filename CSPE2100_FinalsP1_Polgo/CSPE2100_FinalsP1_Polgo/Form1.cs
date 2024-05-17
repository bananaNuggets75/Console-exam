using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace CSPE2100_FinalsP1_Polgo
{
    public partial class Form1 : Form
    {
        
        Class1 tri = new Triangle();
        Class1 rec = new Rectangle1();
        Class1 sqr = new Square();
        Class1 para = new Parallelogram1();
        Class1 rho = new Rhombus();
        Class1 trap = new Trapezoid();
        Class1 kite = new Kite();
        Class1 penta = new Pentagon();
        Class1 hexa = new Hexagon();

        double base1, height, width, lenght, side1, side2, diag1, diag2, lbase, sbase, peri, apo, area, z;

        private void btnSqrSolve_Click(object sender, EventArgs e)
        {
            side1 = side2 = z = 0;
            side1 = double.Parse(txtSqrSide1.Text);
            side2 = double.Parse(txtSqrSide2.Text);
            area = sqr.Calculate(side1, side2, z);

            txtSqrArea.Text = area.ToString();  
        }

        private void btnParaSolve_Click(object sender, EventArgs e)
        {
            base1 = height = z = 0;
            base1 = double.Parse(txtParaBase.Text);
            height = double.Parse(txtParaHeight.Text);
            area = para.Calculate(base1, height, z);

            txtParaArea.Text = area.ToString();
        }

        private void btnRhomSolve_Click(object sender, EventArgs e)
        {
            diag1 = diag2 = z = 0;
            diag1 = double.Parse(txtRhomDiag1.Text);
            diag2 = double.Parse(txtRhomDaig2.Text);
            area = rho.Calculate(diag1, diag2, z);

            txtRhomArea.Text = area.ToString();
        }

        private void btnTrapSolve_Click(object sender, EventArgs e)
        {
            lbase = sbase = height = 0;
            lbase = double.Parse(txtTrapLBase.Text);
            sbase = double.Parse(txtTrapSBase.Text);
            height = double.Parse(txtTrapHeight.Text);
            area = trap.Calculate(lbase, sbase, height); 

            txtTrapArea.Text = area.ToString();
        }

        private void btnKiteSolve_Click(object sender, EventArgs e)
        {
            diag1 = diag2 = z = 0;
            diag1 = double.Parse(txtKiteDiag1.Text);
            diag2 = double.Parse(txtKiteDiag2.Text);
            area = kite.Calculate(diag1, diag2, z);

            txtKiteArea.Text = area.ToString();

        }

        private void btnPentaSolve_Click(object sender, EventArgs e)
        {
            peri = apo = z = 0;
            peri = double.Parse(txtPentaPeri.Text);
            apo = double.Parse(txtPentaApo.Text);
            area = penta.Calculate(peri, apo, z);

            txtPentaArea.Text = area.ToString();
        }

        private void btnHexaSolve_Click(object sender, EventArgs e)
        {
            side1 = z = 0;
            side1 = double.Parse(txtHexaSide.Text);
            area = hexa.Calculate(side1, side2, z);

            txtHexaArea.Text = area.ToString();
        }


        private void btnRecSolve_Click(object sender, EventArgs e)
        {
            width = lenght = 0;
            width = double.Parse(txtRecWidth.Text);
            lenght = double.Parse(txtRecLenght.Text);
            area = rec.Calculate(width, height, z);

            txtRecArea.Text = area.ToString();
        }

        private void btnHexaClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnPentaClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnKiteClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnTrapClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnRhomClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnParaClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnSqrClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnRecClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnTriClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        public Form1()
        {
            InitializeComponent();
        }

        public void ClearAll()
        {
            txtTriBase.Clear();
            txtTriHeight.Clear();
            txtTriArea.Clear();

            txtRecWidth.Clear();
            txtRecLenght.Clear();
            txtRecArea.Clear();

            txtSqrSide1.Clear();
            txtSqrSide2.Clear();
            txtSqrArea.Clear();

            txtParaBase.Clear();
            txtParaHeight.Clear();
            txtParaArea.Clear();

            txtRhomDiag1.Clear();
            txtRhomDaig2.Clear();
            txtRhomArea.Clear();    

            txtTrapLBase.Clear();
            txtTrapSBase.Clear();
            txtTrapHeight.Clear();
            txtTrapArea.Clear();

            txtKiteDiag1.Clear();
            txtKiteDiag2.Clear();
            txtKiteArea.Clear();

            txtPentaPeri.Clear();
            txtPentaApo.Clear();
            txtPentaArea.Clear();

            txtHexaSide.Clear();
            txtHexaArea.Clear();
            
        }

        private void btnTriSolve_Click(object sender, EventArgs e)
        {
            base1 = height = 0;
            base1 = double.Parse(txtTriBase.Text);
            height = double.Parse(txtTriHeight.Text);
            area = tri.Calculate(base1, height, z);

            txtTriArea.Text = area.ToString();
            

        }

    }
}
