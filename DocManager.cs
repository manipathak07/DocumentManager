using System;

namespace DocumentManager
{
    public partial class DocManager : Form
    {
        public DocManager()
        {
            InitializeComponent();
        }



        private void btnCopyFile_Click(object sender, EventArgs e)
        {
            string sourcePath = txtFCFrom.Text;
            string destinationPath = txtFCto.Text;

            try
            {
                File.Copy(sourcePath, destinationPath, true);
                txtFCFrom.Text = null; txtFCto.Text = null;
                MessageBox.Show("File copied successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while copying the file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteFile_Click(object sender, EventArgs e)
        {
            string deleteFilePath = txtFDPath.Text;
            try
            {
                File.Delete(deleteFilePath);
                txtFDPath.Text = null;
                MessageBox.Show("File Deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQueryFiles_Click(object sender, EventArgs e)
        {
            string queryFilePath = txtQFPath.Text;
            try
            {

                if (Directory.Exists(queryFilePath))
                {
                    string[] files = Directory.GetFiles(queryFilePath, "*.*", SearchOption.AllDirectories);

                    foreach (string file in files)
                    {
                        string fileName = Path.GetFileName(file);
                        lstQLView.Items.Add(fileName);
                    }
                    txtQFPath.Text = null;
                }
                else
                {
                    MessageBox.Show("The specified folder does not exist.");
                }
                MessageBox.Show("File listed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while listing the file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCF_Click(object sender, EventArgs e)
        {
            string createFolderPath = @$"{txtCFPath.Text}\{txtCFFolderName.Text}";

            try
            {
                Directory.CreateDirectory(createFolderPath);
                txtCFPath.Text = null;
                txtCFFolderName.Text = null;
                MessageBox.Show("File Deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnSubmitWait_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtWait.Text, out int waitTime))
            {
                System.Threading.Thread.Sleep(waitTime * 1000);

                // Code to execute after the wait
                MessageBox.Show("Wait completed!");

            }
            else
            {
                // Invalid input, handle the error
                MessageBox.Show("Invalid wait time!");
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string filePath = txtFilePath.Text;
            string searchString = txtSearchString.Text;

            int rowCount = 0;

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine())
                        != null)
                    {
                        if (line.Contains(searchString))
                        {
                            rowCount++;
                        }
                    }
                }

                MessageBox.Show($"Number of rows containing the search string: {rowCount}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}