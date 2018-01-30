using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste_new
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Somar obj_somar = new Somar();
        Subtrair newsub = new Subtrair();
        Multiplica newmult = new Multiplica();
        Divide newdiv = new Divide();

        private void button1_Click(object sender, EventArgs e)
        {
            txb_res.Text = obj_somar.soma(txb_num1.Text, txb_num2.Text);
        }

        private void txb_subtrai_Click(object sender, EventArgs e)
        {
            txb_res.Text = newsub.subtrai(txb_num1.Text, txb_num2.Text);
        }

        private void btn_multiplica_Click(object sender, EventArgs e)
        {
            txb_res.Text = newmult.vezes(txb_num1.Text, txb_num2.Text);
        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            txb_res.Text = newdiv.dividir(txb_num1.Text, txb_num2.Text);  
        }

        private void txb_res_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void zerarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txb_num1.Text = "";
            txb_num2.Text = "";
            txb_res.Text = "";
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
