using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula04AppBanco
{
    public partial class Form2 : Form
    {// Juntar dois forms//
        // variável global//

        public List<string> extratos = new List<string>();

        // public = variável publica//
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // mostrar o que ta salvo nos extratos/loop//
            // for comando pra loop//

            for (int i = 0; i < extratos.Count; i++)
            {
                ListExtratos.Items.Add(extratos[i]);
                i++;

            }


            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
