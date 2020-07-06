using Habr_Headline_Parser.Core;
using Habr_Headline_Parser.Habr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Habr_Headline_Parser
{
    public partial class Form1 : Form
    {
        ParserWorker<string[]> parser;


        public Form1()
        {
            InitializeComponent();
            parser = new ParserWorker<string[]>(new HabrParser());

            parser.OnNewData += Parser_OnNewData;
            parser.OnCompleted += Parser_OnCompleted;
        }

        private void Parser_OnCompleted(object obj)
        {
            throw new NotImplementedException();
        }

        private void Parser_OnNewData(object arg1, string[] arg2)
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(arg2);
        }

        private void Start_Click(object sender, EventArgs e)
        {
            parser.settings = new HabrSettings((int)numericUpDown1.Value, (int)numericUpDown2.Value);
            parser.Start();
        }

        private void Abort_Click(object sender, EventArgs e)
        {

        }
    }
}
