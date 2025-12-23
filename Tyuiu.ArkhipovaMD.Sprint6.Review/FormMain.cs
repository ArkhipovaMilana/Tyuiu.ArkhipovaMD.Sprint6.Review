using Tyuiu.ArkhipovaMD.Sprint6.Review.Lib;
namespace Tyuiu.ArkhipovaMD.Sprint6.Review
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonCompile_AMD_Click(object sender, EventArgs e)
        {
            try
            {
                DataService ds = new DataService();
                int n = Convert.ToInt32(textBoxRows_AMD.Text);
                int m = Convert.ToInt32(textBoxColumns_AMD.Text);
                int n1 = Convert.ToInt32(textBoxRandomStart_AMD.Text);
                int n2 = Convert.ToInt32(textBoxRandomEnd_AMD.Text);
                int k = Convert.ToInt32(textBoxStart_AMD.Text);
                int l = Convert.ToInt32(textBoxEnd_AMD.Text);
                int r = Convert.ToInt32(textBoxTargetRow_AMD.Text);
                int[,] array = new int[n, m];

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        array[i, j] = Convert.ToInt32(dataGridViewMatrix_AMD.Rows[i].Cells[j].Value);
                    }
                }
                int result = ds.GetMatrix(array, n1, n2, r, k, l);

                MessageBox.Show($"Result : {result}");
            }
            catch (Exception ex)
            {
                MessageBox.Show (ex.Message );
            }
        }

        private void buttonGenerateMatrix_Click(object sender, EventArgs e)
        {
            try
            {
                DataService ds = new DataService();
                int n = Convert.ToInt32(textBoxRows_AMD.Text);
                int m =Convert.ToInt32(textBoxColumns_AMD.Text);
                int n1=Convert.ToInt32(textBoxRandomStart_AMD.Text);
                int n2=Convert.ToInt32(textBoxRandomEnd_AMD.Text);
                int[,] array = ds.GenerateMatrix(n, m, n1, n2);

                dataGridViewMatrix_AMD.RowCount = n;
                dataGridViewMatrix_AMD.ColumnCount = m;

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        dataGridViewMatrix_AMD.Rows[i].Cells[j].Value = array[i, j];
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
