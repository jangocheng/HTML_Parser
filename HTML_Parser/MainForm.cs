using System;
using HTML_Parser.Core;
using HTML_Parser.Habra;
using System.Windows.Forms;

namespace HTML_Parser
{
    public partial class MainForm : Form
    {
        ParserWorker<string[]> parser;

        public MainForm()
        {
            InitializeComponent();
            parser = new ParserWorker<string[]>(new HabraParser());
            parser.OnNewData += Parser_OnNewData;
            parser.OnCompleted += Parser_OnCompleted;

        }

        private void Parser_OnCompleted(object obj)
        {
            MessageBox.Show("All works done!");
        }

        private void Parser_OnNewData(object arg1, string[] arg2)
        {
            listTitles.Items.AddRange(arg2);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            parser.ParserSettings = new HabraSettings((int)numericStart.Value, (int)numericEnd.Value);
            parser.Start();
        }


        private void endButton_Click(object sender, EventArgs e)
        {
            parser.Stop();
        }
    }
}
