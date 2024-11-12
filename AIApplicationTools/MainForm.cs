using System.Diagnostics;
using UglyToad.PdfPig;
using UglyToad.PdfPig.DocumentLayoutAnalysis.TextExtractor;

namespace AIApplicationTools
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Buttons_Copy_Click();
        }

        private void Button_ChangeFile_Click(object sender, EventArgs e)
        {
            // Open a File Dialog to select a file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PDF Files (*.pdf)|*.pdf|All Files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.Multiselect = false;
            openFileDialog.ShowDialog();
            TextBox_SelectedFile.Text = openFileDialog.FileName;
        }

        private void Button_ReadPDF_Click(object sender, EventArgs e)
        {
            Debug.Print("Reading PDF file.");
            if (TextBox_SelectedFile.Text == "")
            {
                MessageBox.Show("Please select a file first.");
                return;
            }

            if (File.Exists(TextBox_SelectedFile.Text))
            {
                using (var document = PdfDocument.Open(TextBox_SelectedFile.Text))
                {
                    foreach (var page in document.GetPages())
                    {
                        var text = ContentOrderTextExtractor.GetText(page);
                        string GPTQuery = CONSTANTS.OutputFormat;
                        GPTQuery += text;
                        AskChatGPT(GPTQuery);
                    }
                }
            }
            else
            {
                MessageBox.Show("File does not exist.");
                return;
            }
        }

        static async Task AskChatGPT(string askString)
        {
            var apiKey = Environment.GetEnvironmentVariable("OPENAI_API_KEY");
            var chatClient = new ChatGPTClient(apiKey);
            try
            {
                var response = await chatClient.GetResponseAsync(askString);
                Debug.Print(response);
            }
            catch (Exception ex)
            {
                Debug.Print("Error: " + ex.Message);
            }
        }

        private void Label_State_Click(object sender, EventArgs e)
        {

        }

        private void Buttons_Copy_Click()
        {
            Button_FirstName.Click += new System.EventHandler(this.Button_Click);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            System.Windows.Forms.Clipboard.SetText(button.Text);
        }
    }
}
