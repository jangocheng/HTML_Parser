using System;
using HTML_Parser.Core;
using HTML_Parser.Habra;
using System.Windows.Forms;

namespace HTML_Parser
{
    /// <summary>
    /// Simple GUI using WinForms
    /// </summary>
    public partial class MainForm : Form
    {
        
        ParserWorker<string[]> parser;

        public MainForm()
        {
            InitializeComponent();
            parser = new ParserWorker<string[]>(new HabraParser());

            //
            parser.OnNewData += Parser_OnNewData;


            parser.OnCompleted += Parser_OnCompleted;

        }

        //Handle OnCompleted parser's event
        private void Parser_OnCompleted(object obj)
        {
            MessageBox.Show("All works done!");
        }

        //Handle OnNewData parser's event - add new data to listBox
        private void Parser_OnNewData(object arg1, string[] arg2)
        {
            listTitles.Items.AddRange(arg2);
        }

        //Start button logic
        private void startButton_Click(object sender, EventArgs e)
        {
            parser.ParserSettings = new HabraSettings((int)numericStart.Value, (int)numericEnd.Value);
            parser.Start();
        }

        //Stop button logic
        private void endButton_Click(object sender, EventArgs e)
        {
            parser.Stop();
        }
    }
}
