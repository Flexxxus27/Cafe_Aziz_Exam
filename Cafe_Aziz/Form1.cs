using System.Windows.Forms;

namespace Cafe_Aziz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lstMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Открытие файла
        private void OpFile_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string[] dishes = File.ReadAllLines(openFileDialog.FileName);
                    lstMenu.Items.Clear();
                    lstMenu.Items.AddRange(dishes);
                }
            }
            txSum.Text = sum.ToString() + "р";
            sum = 0;
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        //Добавление блюда и 
        int sum = 0;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < lstMenu.SelectedItems.Count; i++)
            {
                lstCh.Items.Add(lstMenu.SelectedItems[i]);
            }
            

            foreach (var item in lstCh.Items)
            {
                string[] part = item.ToString().Split('-');
                if (part.Length == 2 && int.TryParse(part.Last(), out int number))
                {
                    sum += number;
                }

            }
            txSum.Text = sum.ToString() + "р";
            sum = 0;
        }


        private void lstCh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Отчистка всего списка
        private void btnClean_Click(object sender, EventArgs e)
        {
            lstCh.Items.Clear();
            txSum.Text = sum.ToString() + "р";
            sum = 0;
        }

        //Удаление продуктов по 1му
        private void btnRemove_Click(object sender, EventArgs e)
        {
            for (int i = lstCh.SelectedItems.Count - 1; i >= 0; i--)
            {
                lstCh.Items.Remove(lstCh.SelectedItems[i]);
            }
            foreach (var item in lstCh.Items)
            {
                string[] part = item.ToString().Split('-');
                if (part.Length == 2 && int.TryParse(part.Last(), out int number))
                {
                    sum += number;
                }

            }
            txSum.Text = sum.ToString() + "р";
            sum = 0;
        }

        private void txSum_TextChanged(object sender, EventArgs e)
        {
           
        }

        // Расчет стоимости 
        /*private void btnCheck_Click(object sender, EventArgs e)
        {
            int sum = 0;

            foreach (var item in lstCh.Items)
            {
                string[] part = item.ToString().Split('-');
                if(part.Length == 2 && int.TryParse(part.Last(), out int number))
                {
                    sum += number;
                }
                
            }
            txSum.Text = sum.ToString();
        }*/
    }
}
