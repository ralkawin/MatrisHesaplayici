using System.Security.Cryptography.X509Certificates;

namespace MatrisHesap
{
    
    public partial class Form1 : Form
    {
        int[,] matrixA = new int[4,4];
        int[,] matrixB = new int[4,4];
        decimal number3 = 0;
        //bool canConvert = decimal.TryParse(numString, out number3);

        public Form1()
        {
            InitializeComponent();
        }
        public void matrixSetter(short matName)
        {
            if (matName == 0)
            {
                matrixA = new int[rowA.Value, colA.Value];
                bool isThereEmptyA=false;
                do
                {
                    if (A11.Visible == true && (A11.Text.Trim() == string.Empty || !decimal.TryParse(A11.Text, out number3))) { isThereEmptyA = true;}
                    if (A12.Visible == true && (A12.Text.Trim() == string.Empty || !decimal.TryParse(A12.Text, out number3))) { isThereEmptyA = true;}
                    if (A13.Visible == true && (A13.Text.Trim() == string.Empty || !decimal.TryParse(A13.Text, out number3))) { isThereEmptyA = true;}
                    if (A14.Visible == true && (A14.Text.Trim() == string.Empty || !decimal.TryParse(A14.Text, out number3))) { isThereEmptyA = true;}
                    if (A21.Visible == true && (A21.Text.Trim() == string.Empty || !decimal.TryParse(A21.Text, out number3))) { isThereEmptyA = true;}
                    if (A22.Visible == true && (A22.Text.Trim() == string.Empty || !decimal.TryParse(A22.Text, out number3))) { isThereEmptyA = true;}
                    if (A23.Visible == true && (A23.Text.Trim() == string.Empty || !decimal.TryParse(A23.Text, out number3))) { isThereEmptyA = true;}
                    if (A24.Visible == true && (A24.Text.Trim() == string.Empty || !decimal.TryParse(A24.Text, out number3))) { isThereEmptyA = true;}
                    if (A32.Visible == true && (A32.Text.Trim() == string.Empty || !decimal.TryParse(A32.Text, out number3))) { isThereEmptyA = true;}
                    if (A31.Visible == true && (A31.Text.Trim() == string.Empty || !decimal.TryParse(A31.Text, out number3))) { isThereEmptyA = true;}
                    if (A33.Visible == true && (A33.Text.Trim() == string.Empty || !decimal.TryParse(A33.Text, out number3))) { isThereEmptyA = true;}
                    if (A34.Visible == true && (A34.Text.Trim() == string.Empty || !decimal.TryParse(A34.Text, out number3))) { isThereEmptyA = true;}
                    if (A41.Visible == true && (A41.Text.Trim() == string.Empty || !decimal.TryParse(A41.Text, out number3))) { isThereEmptyA = true;}
                    if (A42.Visible == true && (A42.Text.Trim() == string.Empty || !decimal.TryParse(A42.Text, out number3))) { isThereEmptyA = true;}
                    if (A43.Visible == true && (A43.Text.Trim() == string.Empty || !decimal.TryParse(A43.Text, out number3))) { isThereEmptyA = true;}
                    if (A44.Visible == true && (A44.Text.Trim() == string.Empty || !decimal.TryParse(A44.Text, out number3))) { isThereEmptyA = true;}
                    if (isThereEmptyA == true)
                    {
                        MessageBox.Show("Matrislerde hata var. Lütfen kontrol ediniz...");
                        return;
                    }
                } while (isThereEmptyA == true);

                if (rowA.Value > 0 && colA.Value > 0){matrixA[0, 0] = int.Parse(A11.Text);}
                if (rowA.Value > 0 && colA.Value > 1){matrixA[0, 1] = int.Parse(A12.Text);}
                if (rowA.Value > 0 && colA.Value > 2){matrixA[0, 2] = int.Parse(A13.Text);}
                if (rowA.Value > 0 && colA.Value > 3){matrixA[0, 3] = int.Parse(A14.Text);}
                if (rowA.Value > 1 && colA.Value > 0){matrixA[1, 0] = int.Parse(A21.Text);}
                if (rowA.Value > 1 && colA.Value > 1){matrixA[1, 1] = int.Parse(A22.Text);}
                if (rowA.Value > 1 && colA.Value > 2){matrixA[1, 2] = int.Parse(A23.Text);}
                if (rowA.Value > 1 && colA.Value > 3){matrixA[1, 3] = int.Parse(A24.Text);}
                if (rowA.Value > 2 && colA.Value > 0){matrixA[2, 1] = int.Parse(A32.Text);}
                if (rowA.Value > 2 && colA.Value > 1){matrixA[2, 0] = int.Parse(A31.Text);}
                if (rowA.Value > 2 && colA.Value > 2){matrixA[2, 2] = int.Parse(A33.Text);}
                if (rowA.Value > 2 && colA.Value > 3){matrixA[2, 3] = int.Parse(A34.Text);}
                if (rowA.Value > 3 && colA.Value > 0){matrixA[3, 0] = int.Parse(A41.Text);}
                if (rowA.Value > 3 && colA.Value > 1){matrixA[3, 1] = int.Parse(A42.Text);}
                if (rowA.Value > 3 && colA.Value > 2){matrixA[3, 2] = int.Parse(A43.Text);}
                if (rowA.Value > 3 && colA.Value > 3){matrixA[3, 3] = int.Parse(A44.Text);}
            }

            if (matName == 1)
            {
                matrixB = new int[rowB.Value, colB.Value];
                bool isThereEmpty = false;
                do
                {
                    if (A11.Visible == true && (B11.Text.Trim() == string.Empty || !decimal.TryParse(B11.Text, out number3))) { isThereEmpty = true;}
                    if (A12.Visible == true && (B12.Text.Trim() == string.Empty || !decimal.TryParse(B12.Text, out number3))) { isThereEmpty = true;}
                    if (A13.Visible == true && (B13.Text.Trim() == string.Empty || !decimal.TryParse(B13.Text, out number3))) { isThereEmpty = true;}
                    if (A14.Visible == true && (B14.Text.Trim() == string.Empty || !decimal.TryParse(B14.Text, out number3))) { isThereEmpty = true;}
                    if (A21.Visible == true && (B21.Text.Trim() == string.Empty || !decimal.TryParse(B21.Text, out number3))) { isThereEmpty = true;}
                    if (A22.Visible == true && (B22.Text.Trim() == string.Empty || !decimal.TryParse(B22.Text, out number3))) { isThereEmpty = true;}
                    if (A23.Visible == true && (B23.Text.Trim() == string.Empty || !decimal.TryParse(B23.Text, out number3))) { isThereEmpty = true;}
                    if (A24.Visible == true && (B24.Text.Trim() == string.Empty || !decimal.TryParse(B24.Text, out number3))) { isThereEmpty = true;}
                    if (A32.Visible == true && (B32.Text.Trim() == string.Empty || !decimal.TryParse(B32.Text, out number3))) { isThereEmpty = true;}
                    if (A31.Visible == true && (B31.Text.Trim() == string.Empty || !decimal.TryParse(B31.Text, out number3))) { isThereEmpty = true;}
                    if (A33.Visible == true && (B33.Text.Trim() == string.Empty || !decimal.TryParse(B33.Text, out number3))) { isThereEmpty = true;}
                    if (A34.Visible == true && (B34.Text.Trim() == string.Empty || !decimal.TryParse(B34.Text, out number3))) { isThereEmpty = true;}
                    if (A41.Visible == true && (B41.Text.Trim() == string.Empty || !decimal.TryParse(B41.Text, out number3))) { isThereEmpty = true;}
                    if (A42.Visible == true && (B42.Text.Trim() == string.Empty || !decimal.TryParse(B42.Text, out number3))) { isThereEmpty = true;}
                    if (A43.Visible == true && (B43.Text.Trim() == string.Empty || !decimal.TryParse(B43.Text, out number3))) { isThereEmpty = true;}
                    if (A44.Visible == true && (B44.Text.Trim() == string.Empty || !decimal.TryParse(B44.Text, out number3))) { isThereEmpty = true;}
                    if (isThereEmpty == true)
                    {
                        MessageBox.Show("Matrislerde hata var. Lütfen kontrol ediniz...");
                        return;
                    }
                } while (isThereEmpty == true);

                if (rowB.Value > 0 && colB.Value > 0) { matrixB[0, 0] = int.Parse(B11.Text); }
                if (rowB.Value > 0 && colB.Value > 1) { matrixB[0, 1] = int.Parse(B12.Text); }
                if (rowB.Value > 0 && colB.Value > 2) { matrixB[0, 2] = int.Parse(B13.Text); }
                if (rowB.Value > 0 && colB.Value > 3) { matrixB[0, 3] = int.Parse(B14.Text); }
                if (rowB.Value > 1 && colB.Value > 0) { matrixB[1, 0] = int.Parse(B21.Text); }
                if (rowB.Value > 1 && colB.Value > 1) { matrixB[1, 1] = int.Parse(B22.Text); }
                if (rowB.Value > 1 && colB.Value > 2) { matrixB[1, 2] = int.Parse(B23.Text); }
                if (rowB.Value > 1 && colB.Value > 3) { matrixB[1, 3] = int.Parse(B24.Text); }
                if (rowB.Value > 2 && colB.Value > 0) { matrixB[2, 1] = int.Parse(B32.Text); }
                if (rowB.Value > 2 && colB.Value > 1) { matrixB[2, 0] = int.Parse(B31.Text); }
                if (rowB.Value > 2 && colB.Value > 2) { matrixB[2, 2] = int.Parse(B33.Text); }
                if (rowB.Value > 2 && colB.Value > 3) { matrixB[2, 3] = int.Parse(B34.Text); }
                if (rowB.Value > 3 && colB.Value > 0) { matrixB[3, 0] = int.Parse(B41.Text); }
                if (rowB.Value > 3 && colB.Value > 1) { matrixB[3, 1] = int.Parse(B42.Text); }
                if (rowB.Value > 3 && colB.Value > 2) { matrixB[3, 2] = int.Parse(B43.Text); }
                if (rowB.Value > 3 && colB.Value > 3) { matrixB[3, 3] = int.Parse(B44.Text); }
            }
        }
        public void matrixSizer(short matName)
        {
            bool[,,] isVisible = new bool[3, 4, 4];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    isVisible[matName, i, j] = false;
                }
            }

            

            if(matName == 0)
            {
                for (int i = 0; i < rowA.Value; i++)
                {
                    for (int j = 0; j < colA.Value; j++)
                    {
                        isVisible[matName, i, j] = true;
                    }
                }

                A11.Visible = isVisible[0, 0, 0];
                A12.Visible = isVisible[0, 0, 1];
                A13.Visible = isVisible[0, 0, 2];
                A14.Visible = isVisible[0, 0, 3];
                A21.Visible = isVisible[0, 1, 0];
                A22.Visible = isVisible[0, 1, 1];
                A23.Visible = isVisible[0, 1, 2];
                A24.Visible = isVisible[0, 1, 3];
                A31.Visible = isVisible[0, 2, 0];
                A32.Visible = isVisible[0, 2, 1];
                A33.Visible = isVisible[0, 2, 2];
                A34.Visible = isVisible[0, 2, 3];
                A41.Visible = isVisible[0, 3, 0];
                A42.Visible = isVisible[0, 3, 1];
                A43.Visible = isVisible[0, 3, 2];
                A44.Visible = isVisible[0, 3, 3];
            }

            if(matName == 1)
            {
                for (int i = 0; i < rowB.Value; i++)
                {
                    for (int j = 0; j < colB.Value; j++)
                    {
                        isVisible[matName, i, j] = true;
                    }
                }

                B11.Visible = isVisible[1, 0, 0];
                B12.Visible = isVisible[1, 0, 1];
                B13.Visible = isVisible[1, 0, 2];
                B14.Visible = isVisible[1, 0, 3];
                B21.Visible = isVisible[1, 1, 0];
                B22.Visible = isVisible[1, 1, 1];
                B23.Visible = isVisible[1, 1, 2];
                B24.Visible = isVisible[1, 1, 3];
                B31.Visible = isVisible[1, 2, 0];
                B32.Visible = isVisible[1, 2, 1];
                B33.Visible = isVisible[1, 2, 2];
                B34.Visible = isVisible[1, 2, 3];
                B41.Visible = isVisible[1, 3, 0];
                B42.Visible = isVisible[1, 3, 1];
                B43.Visible = isVisible[1, 3, 2];
                B44.Visible = isVisible[1, 3, 3];
            }
        }

        private void setA_Click(object sender, EventArgs e)
        {
            matrixA = new int[rowA.Value, colA.Value];

        }
        private void setB_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Visible = false;
            label4.Visible = false;
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            matrixSizer(0);
            matrixSizer(1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex==10 || comboBox1.SelectedIndex == 11)
            {
                label3.Visible = true;
                label4.Visible = true;
                comboBox2.Visible = true;
                comboBox3.Visible = true;
            } 
            else 
            {
                label3.Visible = false;
                label4.Visible = false;
                comboBox2.Visible = false;
                comboBox3.Visible = false;
            }
        }

        private void calculator_Click(object sender, EventArgs e)
        {
            matrixSetter(0);
            listBox1.Items.Clear();

            for(int i=0; i<rowA.Value; i++)
            {
                for(int j=0; j<colA.Value; j++)
                {
                    listBox1.Items.Add(matrixA[i, j].ToString());

                }
            }
        }

        private void rowA_Scroll(object sender, EventArgs e)
        {
            matrixSizer(0);
        }

        private void colA_Scroll(object sender, EventArgs e)
        {
            matrixSizer(0);
        }

        private void rowB_Scroll(object sender, EventArgs e)
        {
            matrixSizer(1);
        }

        private void colB_Scroll(object sender, EventArgs e)
        {
            matrixSizer(1);
        }
    }
}