using FastColoredTextBoxNS;
using System.Diagnostics;
using System.Windows.Forms;

namespace osmonIdeTiny
{
    public partial class Form1 : Form
    {
        Style styleKeyword = new TextStyle(Brushes.Blue, null, FontStyle.Bold);
        Style styleString = new TextStyle(Brushes.Red, null, FontStyle.Regular);
        Style styleComment = new TextStyle(Brushes.Green, null, FontStyle.Italic);
        public Form1()
        {
            InitializeComponent();
            mainEditorBox.TextChanged += mainEditorBox_TextChanged;
        }

        private void ochishToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void yangiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void shriftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                mainEditorBox.Font = fontDialog.Font;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Osmon files (*.osm)|*.osm|All files (*.*)|*.*";
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                string fileContents = File.ReadAllText(fileName);
                mainEditorBox.Text = fileContents;
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Osmon files (*.osm)|*.osm";
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {

                string fileName = saveFileDialog.FileName;
                string fileContents = mainEditorBox.Text;

                File.WriteAllText(fileName, fileContents);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void mainEditorBox_Load(object sender, EventArgs e)
        {

        }

        private void mainEditorBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            e.ChangedRange.ClearStyle(styleKeyword, styleString, styleComment);

            // Define the regular expressions to match the different parts of the code
            string keywords = @"\b(if|else|while|for|foreach|break|continue|ha|yoq|joy|agar|tuga|unda|toki|qachonki|qayta|toxta|qaytar|yangi|funksiya|nol|tur|shu|guruh|label|goto)\b";
            string strings = "\"(.*?)\"";
            string comments = @"//(.*?)$|/\*(.*?)\*/";


            // Apply the styles to the matching ranges of text in the control
            e.ChangedRange.SetStyle(styleKeyword, keywords);
            e.ChangedRange.SetStyle(styleString, strings);
            e.ChangedRange.SetStyle(styleComment, comments);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void korinishToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            // Get the path of the selected file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "OSM files (*.osm)|*.osm";
            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            string programName = openFileDialog.FileName;

            // Build the command to execute
            string command = "osmon.exe \"" + programName + "\"";

            // Start the process and redirect standard output and error
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/c " + command;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;

            Process process = new Process();
            process.StartInfo = startInfo;

            // Attach event handlers to capture output and error messages
            process.OutputDataReceived += new DataReceivedEventHandler((s, args) =>
            {
                if (!string.IsNullOrEmpty(args.Data))
                {
                    // Write output to the console and the output textbox
                    Console.WriteLine(args.Data);
                    terminalBox.AppendText(args.Data + Environment.NewLine);
                }
            });

            process.ErrorDataReceived += new DataReceivedEventHandler((s, args) =>
            {
                if (!string.IsNullOrEmpty(args.Data))
                {
                    // Write error messages to the console and the output textbox
                    Console.WriteLine("Error: " + args.Data);
                    terminalBox.AppendText("Error: " + args.Data + Environment.NewLine);
                }
            });

            // Start the process and begin reading from its output streams
            process.Start();
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();
            process.WaitForExit();
        }

    }
}