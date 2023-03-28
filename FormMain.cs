using Microsoft.VisualBasic.Logging;
using System.Text;
using System.Web;

namespace TimestampPreserver
{
    public partial class FormMain : Form
    {
        private const string TIMESTAMPS_FILE = ".timestamps.txt";
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder log = new StringBuilder();
            try
            {
                // Get the timestamps for each file
                StringBuilder timestamps = new StringBuilder();
                DirectoryInfo dinfo = new DirectoryInfo(textBoxPath.Text);
                foreach (FileInfo finfo in dinfo.GetFiles())
                {
                    if (finfo.Name == TIMESTAMPS_FILE) continue;

                    timestamps.AppendLine(String.Format("{0}|{1}|{2}|{3}",
                        finfo.Name,
                        finfo.CreationTime.ToString(),
                        finfo.LastWriteTime.ToString(),
                        finfo.LastAccessTime.ToString()));

                    log.AppendLine(String.Format("Timestamp saved for: {0}", finfo.Name));
                }

                // Save the timestamps
                string outputFile = Path.GetFullPath(textBoxPath.Text) + "\\" + TIMESTAMPS_FILE;
                File.WriteAllText(outputFile, timestamps.ToString());
                log.AppendLine(String.Format("Output file: {0}", outputFile));
            }
            catch (Exception ex)
            {
                log.AppendLine(String.Format("ERROR: {0}", ex.ToString()));
            }
            finally
            {
                textBoxLog.Text = log.ToString();
            }
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            StringBuilder log = new StringBuilder();
            try
            {
                string inputFile = Path.GetFullPath(textBoxPath.Text) + "\\" + TIMESTAMPS_FILE;

                if (!File.Exists(inputFile))
                {
                    log.AppendLine(String.Format("ERROR: Input file does not exist: {0}", inputFile));
                    return;
                }

                foreach (string line in File.ReadAllLines(inputFile))
                {
                    string[] parts = line.Split("|");
                    string fullPath = Path.GetFullPath(textBoxPath.Text) + "\\" + parts[0];
                    if (File.Exists(fullPath))
                    {
                        File.SetCreationTime(fullPath, DateTime.Parse(parts[1]));
                        File.SetLastWriteTime(fullPath, DateTime.Parse(parts[2]));
                        File.SetLastAccessTime(fullPath, DateTime.Parse(parts[3]));
                        log.AppendLine(String.Format("Timestamps applied to {0}", fullPath));
                    }
                    else
                    {
                        log.AppendLine(String.Format("ERROR: File does not exist: {0}", fullPath));
                        if (checkBoxContinueOnError.Checked) continue;
                        else break;
                    }
                }
            }
            catch (Exception ex)
            {
                log.AppendLine(String.Format("ERROR: {0}", ex.ToString()));
            }
            finally
            {
                textBoxLog.Text = log.ToString();
            }
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            textBoxLog.Width = this.ClientSize.Width - textBoxLog.Left * 2;
            textBoxLog.Height = this.ClientSize.Height - textBoxLog.Top - textBoxLog.Left;
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();

            if (Directory.Exists(textBoxPath.Text))
                dlg.SelectedPath = textBoxPath.Text;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBoxPath.Text = dlg.SelectedPath;
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (Directory.Exists(Clipboard.GetText()))
                textBoxPath.Text = Clipboard.GetText();

            FormMain_Resize(null, null);
        }
    }
}