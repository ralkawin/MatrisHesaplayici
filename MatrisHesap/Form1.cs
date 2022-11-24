using System.Drawing.Drawing2D;
using System.Security.Cryptography.X509Certificates;

namespace MatrisHesap
{
    
    public partial class Form1 : Form
    {
        int[,] matrixA = new int[4,4];
        int[,] matrixB = new int[4,4];
        int[,] matrixC = new int[4,4];
        int rowC=4, colC=4;
        public Form1()
        {
            InitializeComponent();
        }

        public bool isThereNumber(int matName)
        {
            decimal numberA = 0;
            decimal numberB = 0;
            bool isThere = true;

            if (matName == 0)
            {
                if (A11.Visible == true && ((A11.Text.Trim() == string.Empty) || !decimal.TryParse(A11.Text, out numberA))) { isThere = false; }
                if (A12.Visible == true && ((A12.Text.Trim() == string.Empty) || !decimal.TryParse(A12.Text, out numberA))) { isThere = false; }
                if (A13.Visible == true && ((A13.Text.Trim() == string.Empty) || !decimal.TryParse(A13.Text, out numberA))) { isThere = false; }
                if (A14.Visible == true && ((A14.Text.Trim() == string.Empty) || !decimal.TryParse(A14.Text, out numberA))) { isThere = false; }
                if (A21.Visible == true && ((A21.Text.Trim() == string.Empty) || !decimal.TryParse(A21.Text, out numberA))) { isThere = false; }
                if (A22.Visible == true && ((A22.Text.Trim() == string.Empty) || !decimal.TryParse(A22.Text, out numberA))) { isThere = false; }
                if (A23.Visible == true && ((A23.Text.Trim() == string.Empty) || !decimal.TryParse(A23.Text, out numberA))) { isThere = false; }
                if (A24.Visible == true && ((A24.Text.Trim() == string.Empty) || !decimal.TryParse(A24.Text, out numberA))) { isThere = false; }
                if (A32.Visible == true && ((A32.Text.Trim() == string.Empty) || !decimal.TryParse(A32.Text, out numberA))) { isThere = false; }
                if (A31.Visible == true && ((A31.Text.Trim() == string.Empty) || !decimal.TryParse(A31.Text, out numberA))) { isThere = false; }
                if (A33.Visible == true && ((A33.Text.Trim() == string.Empty) || !decimal.TryParse(A33.Text, out numberA))) { isThere = false; }
                if (A34.Visible == true && ((A34.Text.Trim() == string.Empty) || !decimal.TryParse(A34.Text, out numberA))) { isThere = false; }
                if (A41.Visible == true && ((A41.Text.Trim() == string.Empty) || !decimal.TryParse(A41.Text, out numberA))) { isThere = false; }
                if (A42.Visible == true && ((A42.Text.Trim() == string.Empty) || !decimal.TryParse(A42.Text, out numberA))) { isThere = false; }
                if (A43.Visible == true && ((A43.Text.Trim() == string.Empty) || !decimal.TryParse(A43.Text, out numberA))) { isThere = false; }
                if (A44.Visible == true && ((A44.Text.Trim() == string.Empty) || !decimal.TryParse(A44.Text, out numberA))) { isThere = false; }
            }

            if (matName == 1)
            {
                if (B11.Visible == true && ((B11.Text.Trim() == string.Empty) || !decimal.TryParse(B11.Text, out numberB))) { isThere = false; }
                if (B12.Visible == true && ((B12.Text.Trim() == string.Empty) || !decimal.TryParse(B12.Text, out numberB))) { isThere = false; }
                if (B13.Visible == true && ((B13.Text.Trim() == string.Empty) || !decimal.TryParse(B13.Text, out numberB))) { isThere = false; }
                if (B14.Visible == true && ((B14.Text.Trim() == string.Empty) || !decimal.TryParse(B14.Text, out numberB))) { isThere = false; }
                if (B21.Visible == true && ((B21.Text.Trim() == string.Empty) || !decimal.TryParse(B21.Text, out numberB))) { isThere = false; }
                if (B22.Visible == true && ((B22.Text.Trim() == string.Empty) || !decimal.TryParse(B22.Text, out numberB))) { isThere = false; }
                if (B23.Visible == true && ((B23.Text.Trim() == string.Empty) || !decimal.TryParse(B23.Text, out numberB))) { isThere = false; }
                if (B24.Visible == true && ((B24.Text.Trim() == string.Empty) || !decimal.TryParse(B24.Text, out numberB))) { isThere = false; }
                if (B32.Visible == true && ((B32.Text.Trim() == string.Empty) || !decimal.TryParse(B32.Text, out numberB))) { isThere = false; }
                if (B31.Visible == true && ((B31.Text.Trim() == string.Empty) || !decimal.TryParse(B31.Text, out numberB))) { isThere = false; }
                if (B33.Visible == true && ((B33.Text.Trim() == string.Empty) || !decimal.TryParse(B33.Text, out numberB))) { isThere = false; }
                if (B34.Visible == true && ((B34.Text.Trim() == string.Empty) || !decimal.TryParse(B34.Text, out numberB))) { isThere = false; }
                if (B41.Visible == true && ((B41.Text.Trim() == string.Empty) || !decimal.TryParse(B41.Text, out numberB))) { isThere = false; }
                if (B42.Visible == true && ((B42.Text.Trim() == string.Empty) || !decimal.TryParse(B42.Text, out numberB))) { isThere = false; }
                if (B43.Visible == true && ((B43.Text.Trim() == string.Empty) || !decimal.TryParse(B43.Text, out numberB))) { isThere = false; }
                if (B44.Visible == true && ((B44.Text.Trim() == string.Empty) || !decimal.TryParse(B44.Text, out numberB))) { isThere = false; }
            }

            return isThere;
        }
        public void matrixSetter(short matName)
        {
            if (matName == 0)
            {
                matrixA = new int[rowA.Value, colA.Value];

                do
                {
                    if (isThereNumber(0) == true)
                    {
                        if (A11.Visible == true) { matrixA[0, 0] = int.Parse(A11.Text); }
                        if (A12.Visible == true) { matrixA[0, 1] = int.Parse(A12.Text); }
                        if (A13.Visible == true) { matrixA[0, 2] = int.Parse(A13.Text); }
                        if (A14.Visible == true) { matrixA[0, 3] = int.Parse(A14.Text); }
                        if (A21.Visible == true) { matrixA[1, 0] = int.Parse(A21.Text); }
                        if (A22.Visible == true) { matrixA[1, 1] = int.Parse(A22.Text); }
                        if (A23.Visible == true) { matrixA[1, 2] = int.Parse(A23.Text); }
                        if (A24.Visible == true) { matrixA[1, 3] = int.Parse(A24.Text); }
                        if (A32.Visible == true) { matrixA[2, 1] = int.Parse(A32.Text); }
                        if (A31.Visible == true) { matrixA[2, 0] = int.Parse(A31.Text); }
                        if (A33.Visible == true) { matrixA[2, 2] = int.Parse(A33.Text); }
                        if (A34.Visible == true) { matrixA[2, 3] = int.Parse(A34.Text); }
                        if (A41.Visible == true) { matrixA[3, 0] = int.Parse(A41.Text); }
                        if (A42.Visible == true) { matrixA[3, 1] = int.Parse(A42.Text); }
                        if (A43.Visible == true) { matrixA[3, 2] = int.Parse(A43.Text); }
                        if (A44.Visible == true) { matrixA[3, 3] = int.Parse(A44.Text); }
                    } 
                    else 
                    {
                        MessageBox.Show("A matrisinde eksik veya hatalý deðerler var. Lütfen kontrol ediniz...");
                        return;
                    }
                } while (isThereNumber(0) == false);
            }

            if (matName == 1)
            {
                matrixB = new int[rowB.Value, colB.Value];

                do
                {
                    if (isThereNumber(1) == true)
                    {
                        if (B11.Visible == true) { matrixB[0, 0] = int.Parse(B11.Text); }
                        if (B12.Visible == true) { matrixB[0, 1] = int.Parse(B12.Text); }
                        if (B13.Visible == true) { matrixB[0, 2] = int.Parse(B13.Text); }
                        if (B14.Visible == true) { matrixB[0, 3] = int.Parse(B14.Text); }
                        if (B21.Visible == true) { matrixB[1, 0] = int.Parse(B21.Text); }
                        if (B22.Visible == true) { matrixB[1, 1] = int.Parse(B22.Text); }
                        if (B23.Visible == true) { matrixB[1, 2] = int.Parse(B23.Text); }
                        if (B24.Visible == true) { matrixB[1, 3] = int.Parse(B24.Text); }
                        if (B32.Visible == true) { matrixB[2, 1] = int.Parse(B32.Text); }
                        if (B31.Visible == true) { matrixB[2, 0] = int.Parse(B31.Text); }
                        if (B33.Visible == true) { matrixB[2, 2] = int.Parse(B33.Text); }
                        if (B34.Visible == true) { matrixB[2, 3] = int.Parse(B34.Text); }
                        if (B41.Visible == true) { matrixB[3, 0] = int.Parse(B41.Text); }
                        if (B42.Visible == true) { matrixB[3, 1] = int.Parse(B42.Text); }
                        if (B43.Visible == true) { matrixB[3, 2] = int.Parse(B43.Text); }
                        if (B44.Visible == true) { matrixB[3, 3] = int.Parse(B44.Text); }
                    }
                    else
                    {
                        MessageBox.Show("B matrisinde eksik veya hatalý deðerler var. Lütfen kontrol ediniz...");
                        return;
                    }
                } while (isThereNumber(1) == false);
            }

            if(matName == 2)
            {
                if (C11.Visible == true){C11.Text = matrixC[0, 0].ToString();}
                if (C12.Visible == true){C12.Text = matrixC[0, 1].ToString();}
                if (C13.Visible == true){C13.Text = matrixC[0, 2].ToString();}
                if (C14.Visible == true){C14.Text = matrixC[0, 3].ToString();}
                if (C21.Visible == true){C21.Text = matrixC[1, 0].ToString();}
                if (C22.Visible == true){C22.Text = matrixC[1, 1].ToString();}
                if (C23.Visible == true){C23.Text = matrixC[1, 2].ToString();}
                if (C24.Visible == true){C24.Text = matrixC[1, 3].ToString();}
                if (C31.Visible == true){C31.Text = matrixC[2, 0].ToString();}
                if (C32.Visible == true){C32.Text = matrixC[2, 1].ToString();}
                if (C33.Visible == true){C33.Text = matrixC[2, 2].ToString();}
                if (C34.Visible == true){C34.Text = matrixC[2, 3].ToString();}
                if (C41.Visible == true){C41.Text = matrixC[3, 0].ToString();}
                if (C42.Visible == true){C42.Text = matrixC[3, 1].ToString();}
                if (C43.Visible == true){C43.Text = matrixC[3, 2].ToString();}
                if (C44.Visible == true){C44.Text = matrixC[3, 3].ToString();}
            }
        }
        public void matrixSizer(short matName)
        {
            bool[,,] isVisible = new bool[3, 4, 4];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
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

            if (matName == 2)
            {
                for (int i = 0; i < rowC; i++)
                {
                    for (int j = 0; j < colC; j++)
                    {
                        isVisible[matName, i, j] = true;
                    }
                }

                C11.Visible = isVisible[2, 0, 0];
                C12.Visible = isVisible[2, 0, 1];
                C13.Visible = isVisible[2, 0, 2];
                C14.Visible = isVisible[2, 0, 3];
                C21.Visible = isVisible[2, 1, 0];
                C22.Visible = isVisible[2, 1, 1];
                C23.Visible = isVisible[2, 1, 2];
                C24.Visible = isVisible[2, 1, 3];
                C31.Visible = isVisible[2, 2, 0];
                C32.Visible = isVisible[2, 2, 1];
                C33.Visible = isVisible[2, 2, 2];
                C34.Visible = isVisible[2, 2, 3];
                C41.Visible = isVisible[2, 3, 0];
                C42.Visible = isVisible[2, 3, 1];
                C43.Visible = isVisible[2, 3, 2];
                C44.Visible = isVisible[2, 3, 3];
            }
        }

        private void setA_Click(object sender, EventArgs e)
        {
            matrixSetter(0);
            if(isThereNumber(0) && rowA.Value == colA.Value) { detA.Text = determinant(matrixA, rowA.Value, colA.Value).ToString(); }
        }
        private void setB_Click(object sender, EventArgs e)
        {
            matrixSetter(1);
            if (isThereNumber(1) && rowB.Value == colB.Value) { detB.Text = determinant(matrixB, rowA.Value, colA.Value).ToString(); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            matrixSizer(0);
            matrixSizer(1);
            matrixSizer(2);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rowA.Value == rowB.Value && colA.Value == colB.Value && (comboBox1.SelectedIndex==2 || comboBox1.SelectedIndex == 3))
            {
                rowC = rowA.Value;
                colC = colA.Value;
                matrixSizer(2);
                return;
            }

            if (colA.Value == rowB.Value && (comboBox1.SelectedIndex==0))
            {
                rowC = rowA.Value;
                colC = colB.Value;
                matrixSizer(2);
                return;
            }
        }

        private void calculator_Click(object sender, EventArgs e)
        {       
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    if (colA.Value == rowB.Value && isThereNumber(0) == true && isThereNumber(1) == true)
                    {
                        matrixSetter(0);
                        matrixSetter(1);
                        rowC = rowA.Value;
                        colC = colB.Value;
                        matrixC = new int[rowC, colC];
                        matrixSizer(2);

                        for (int i = 0; i < rowC; i++)
                        {
                            for (int j = 0; j < colC; j++)
                            {
                                matrixC[i, j] = 0;
                            }
                        }

                        for (int i = 0; i < rowA.Value; i++)
                        {
                            for (int j = 0; j < colB.Value; j++)
                            {
                                for (int k = 0; k < colA.Value; k++)
                                {
                                    matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                                }
                            }
                        }

                        matrixSetter(2);

                        if (rowC == colC) { detC.Text = determinant(matrixC, rowC, colC).ToString(); }
                    }
                    else
                    {
                        MessageBox.Show("Bu iþlemi yapabilmeniz için A matrisinin sütun sayýsý B matrisinin satýr sayýsýna eþit ve matrisler dolu olmalýdýr.");
                    }
                    break;
                case 1:
                    if (colB.Value == rowA.Value && isThereNumber(0) == true && isThereNumber(1) == true)
                    {
                        matrixSetter(0);
                        matrixSetter(1);
                        rowC = rowB.Value;
                        colC = colA.Value;
                        matrixC = new int[rowC, colC];
                        matrixSizer(2);

                        for (int i = 0; i < rowC; i++)
                        {
                            for (int j = 0; j < colC; j++)
                            {
                                matrixC[i, j] = 0;
                            }
                        }

                        for (int i = 0; i < rowB.Value; i++)
                        {
                            for (int j = 0; j < colA.Value; j++)
                            {
                                for (int k = 0; k < colB.Value; k++)
                                {
                                    matrixC[i, j] += matrixB[i, k] * matrixA[k, j];
                                }
                            }
                        }

                        matrixSetter(2);
                    }
                    else
                    {
                        MessageBox.Show("Bu iþlemi yapabilmeniz için B matrisinin sütun sayýsý A matrisinin satýr sayýsýna eþit ve matrisler dolu olmalýdýr.");
                    }
                    break;
                case 2:
                    if (rowA.Value == rowB.Value && colA.Value == colB.Value && isThereNumber(0) == true && isThereNumber(1) == true)
                    {
                        matrixSetter(0);
                        matrixSetter(1);
                        rowC = rowA.Value;
                        colC = colA.Value;
                        matrixSizer(2);
                        matrixC = new int[rowC, colC];

                        for (int i = 0; i < rowC; i++)
                        {
                            for (int j = 0; j < colC; j++)
                            {
                                matrixC[i, j] = matrixA[i, j] + matrixB[i, j];
                            }
                        }
                        matrixSetter(2);
                    }
                    else { MessageBox.Show("Toplama iþlemi yapabilmeniz için matrisler dolu ve eþit boyutta olmalýdýr."); }
                    break;

                case 3:
                    if (rowA.Value == rowB.Value && colA.Value == colB.Value && isThereNumber(0) == true && isThereNumber(1) == true)
                    {
                        matrixSetter(0);
                        matrixSetter(1);
                        rowC = rowA.Value;
                        colC = colA.Value;
                        matrixSizer(2);
                        matrixC = new int[rowC, colC];

                        for (int i = 0; i < rowC; i++)
                        {
                            for (int j = 0; j < colC; j++)
                            {
                                matrixC[i, j] = matrixA[i, j] - matrixB[i, j];
                            }
                        }
                        matrixSetter(2);
                    }
                    else { MessageBox.Show("Çýkartma iþlemi yapabilmeniz için matrisler dolu ve eþit boyutta olmalýdýr."); }
                    break;
                case 8:
                    if (isThereNumber(0) == true && rowA.Value == colA.Value) 
                    {
                        matrixSetter(0);
                        rowC = rowA.Value;
                        colC = colA.Value;
                        int[,] minorMatrixA = new int[rowA.Value, colA.Value];
                        matrixC = new int[rowC, colC];
                        matrixSizer(2);

                        for (int i=0; i<rowA.Value; i++)
                        {
                            for (int j=0; j<colA.Value; j++)
                            {
                                minorMatrixA[i, j] = minor(0, i, j);
                            }
                        }
                        matrixC = minorMatrixA;
                        matrixSetter(2);
                    } else { MessageBox.Show("Matriste hata var, lütfen kontrol edip tekrar deneyin. \n\t-Matris tam dolu ve tam sayýlar içermelidir.\n\t-Matris kare matris olmalý."); }
                    break;
                case 9:
                    if (isThereNumber(1) == true && rowB.Value == colB.Value)
                    {
                        matrixSetter(1);
                        rowC = rowB.Value;
                        colC = colB.Value;
                        int[,] minorMatrixB = new int[rowB.Value, colB.Value];
                        matrixC = new int[rowC, colC];
                        matrixSizer(2);

                        for (int i = 0; i < rowB.Value; i++)
                        {
                            for (int j = 0; j < colB.Value; j++)
                            {
                                minorMatrixB[i, j] = minor(0, i, j);
                            }
                        }
                        matrixC = minorMatrixB;
                        matrixSetter(2);
                    }
                    else { MessageBox.Show("Matriste hata var, lütfen kontrol edip tekrar deneyin. \n\t-Matris tam dolu ve tam sayýlar içermelidir.\n\t-Matris kare matris olmalý."); }
                    break;
                case 4:
                    matrixSetter(0);
                    rowC = colA.Value;
                    colC = rowA.Value;
                    matrixC = new int[rowC, colC];
                    matrixC = transpose(matrixA, rowA.Value, colA.Value);
                    matrixSizer(2);
                    matrixSetter(2);
                    break;
                case 5:
                    MatrixSetter(1);
                    rowC = colB.Value;
                    colC = rowB.Value;
                    matrixC = new int[rowC, colC];
                    matrixC = transpose(matrixB, rowB.Value, colB.Value);
                    matrixSizer(2);
                    matrixSetter(2);
                case -1:
                    MessageBox.Show("Lütfen bir iþlem seçiniz.");
                    break;
                default:
                    MessageBox.Show("Bu iþlem geliþtirme aþamasýndadýr.");
                    break;
            }

            if (rowC == colC)
            {
                detC.Text = determinant(matrixC, rowC, colC).ToString();
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

        public void cleanerA_Click(object sender, EventArgs e)
        {
            A11.Clear();
            A12.Clear();
            A13.Clear();
            A14.Clear();
            A21.Clear();
            A22.Clear();
            A23.Clear();
            A24.Clear();
            A32.Clear();
            A31.Clear();
            A33.Clear();
            A34.Clear();
            A41.Clear();
            A42.Clear();
            A43.Clear();
            A44.Clear();
        }

        public void cleanerB_Click(object sender, EventArgs e)
        {
            B11.Clear();
            B12.Clear();
            B13.Clear();
            B14.Clear();
            B21.Clear();
            B22.Clear();
            B23.Clear();
            B24.Clear();
            B32.Clear();
            B31.Clear();
            B33.Clear();
            B34.Clear();
            B41.Clear();
            B42.Clear();
            B43.Clear();
            B44.Clear();
        }

        private void setAbirim_Click(object sender, EventArgs e)
        {
            if(rowA.Value == colA.Value)
            {
                if (A11.Visible == true) { A11.Text = "1"; }
                if (A12.Visible == true) { A12.Text = "0"; }
                if (A13.Visible == true) { A13.Text = "0"; }
                if (A14.Visible == true) { A14.Text = "0"; }
                if (A21.Visible == true) { A21.Text = "0"; }
                if (A22.Visible == true) { A22.Text = "1"; }
                if (A23.Visible == true) { A23.Text = "0"; }
                if (A24.Visible == true) { A24.Text = "0"; }
                if (A32.Visible == true) { A32.Text = "0"; }
                if (A31.Visible == true) { A31.Text = "0"; }
                if (A33.Visible == true) { A33.Text = "1"; }
                if (A34.Visible == true) { A34.Text = "0"; }
                if (A41.Visible == true) { A41.Text = "0"; }
                if (A42.Visible == true) { A42.Text = "0"; }
                if (A43.Visible == true) { A43.Text = "0"; }
                if (A44.Visible == true) { A44.Text = "1"; }
                matrixSetter(0);
            }
            else
            {
                MessageBox.Show("Yalnýzca kare matrisler birim matris olabilir.");
            }
            
        }

        private void setBbirim_Click(object sender, EventArgs e)
        {
            if (rowB.Value == colB.Value)
            {
                if (B11.Visible == true) { B11.Text = "1"; }
                if (B12.Visible == true) { B12.Text = "0"; }
                if (B13.Visible == true) { B13.Text = "0"; }
                if (B14.Visible == true) { B14.Text = "0"; }
                if (B21.Visible == true) { B21.Text = "0"; }
                if (B22.Visible == true) { B22.Text = "1"; }
                if (B23.Visible == true) { B23.Text = "0"; }
                if (B24.Visible == true) { B24.Text = "0"; }
                if (B32.Visible == true) { B32.Text = "0"; }
                if (B31.Visible == true) { B31.Text = "0"; }
                if (B33.Visible == true) { B33.Text = "1"; }
                if (B34.Visible == true) { B34.Text = "0"; }
                if (B41.Visible == true) { B41.Text = "0"; }
                if (B42.Visible == true) { B42.Text = "0"; }
                if (B43.Visible == true) { B43.Text = "0"; }
                if (B44.Visible == true) { B44.Text = "1"; }
                matrixSetter(1);
            }
            else
            {
                MessageBox.Show("Yalnýzca kare matrisler birim matris olabilir.");
            }
            
        }

        public int minor(int matName, int row, int col)
        {
            int[,] minorMatrix = new int[2,2];
            int minor=0;
            
            if(matName == 0 && isThereNumber(0) == true)
            {
                minorMatrix = new int[rowA.Value - 1, colA.Value - 1];
                int k=0, l= 0;

                for (int i = 0; i < rowA.Value - 1; i++)
                {
                    if (i < row) { k = i; } else { k = i + 1; }
                    for (int j = 0; j < colA.Value - 1; j++)
                    {
                        if (j < col) { l = j; } else { l = j + 1; }
                        minorMatrix[i, j] = matrixA[k, l];
                    }
                }
                minor = determinant(minorMatrix, rowA.Value - 1, colA.Value - 1);
            }
            

            if (matName == 1 && isThereNumber(1) == true)
            {
                minorMatrix = new int[rowB.Value - 1, colB.Value - 1];
                int k = 0, l = 0;

                for (int i = 0; i < rowB.Value - 1; i++)
                {
                    if (i < row - 1) { k = i; } else { k = i + 1; }
                    for (int j = 0; j < colB.Value - 1; j++)
                    {
                        if (j < col - 1) { l = j; } else { l = j + 1; }
                        minorMatrix[i, j] = matrixB[k, l];
                    }
                }
                minor = determinant(minorMatrix, rowB.Value - 1, colB.Value - 1);
            }
            
            return minor;
        }
        public int determinant(int[,] matName, int detOrow, int detOcol)
        {
            int detValue = 0, detRow = 0, detCol = 0, sarrusRow, sarrusCol;
            detRow = detOrow;
            detCol = detOcol;
            int[,] detMatrix = new int[detRow, detCol];
            int[,] sarrusMatrix;
            

            
            
            if (matName == matrixA) 
            {
                detRow = rowA.Value;
                detCol = colA.Value;
                detMatrix = new int[rowA.Value, colA.Value];
                detMatrix = matrixA;
            }

            if (matName == matrixB)
            {
                detRow = rowB.Value;
                detCol = colB.Value;
                detMatrix = new int[rowB.Value, colB.Value];
                detMatrix = matrixB;
            }

            if (matName == matrixC)
            {
                detRow = rowC;
                detCol = colC;
                detMatrix = new int[rowC, colC];
                detMatrix = matrixC;
            }

            else
            {
                detRow = detOrow;
                detCol = detOcol;
                detMatrix = new int[detOrow, detOcol];
                detMatrix = matName;
            }

            if (detRow == 1 && detCol == 1) { detValue = detMatrix[0, 0]; return detValue; }

            else if (detRow == 2 && detCol == 2) { detValue = detMatrix[0, 0] * detMatrix[1, 1] - detMatrix[0, 1] * detMatrix[1, 0]; return detValue; }
            
            else if (detRow == 3 && detCol == 3)
            {
                sarrusRow = detRow + 2;
                sarrusCol = detCol;
                sarrusMatrix = new int[sarrusRow, sarrusCol];

                for (int i=0; i < 5; i++)
                {
                    for (int j=0; j < 3; j++)
                    {
                        if (i < 3) { sarrusMatrix[i, j] = detMatrix[i, j]; }
                        else { sarrusMatrix[i, j] = detMatrix[i - 3, j]; }
                    }
                }

                detValue = (sarrusMatrix[0, 2] * sarrusMatrix[1, 1] * sarrusMatrix[2, 0]
                           + sarrusMatrix[1, 2] * sarrusMatrix[2, 1] * sarrusMatrix[3, 0]
                           + sarrusMatrix[2, 2] * sarrusMatrix[3, 1] * sarrusMatrix[4, 0]) 
                           -(sarrusMatrix[0, 0] * sarrusMatrix[1, 1] * sarrusMatrix[2, 2]
                           + sarrusMatrix[1, 0] * sarrusMatrix[2, 1] * sarrusMatrix[3, 2]
                           + sarrusMatrix[2, 0] * sarrusMatrix[3, 1] * sarrusMatrix[4, 2]);
                return detValue;
            }
            else if (detRow == 4 && detCol == 4) 
            { 
                MessageBox.Show("Bu matris için determinant hesabý geliþtirme aþamasýndadýr.");
                return 0;
            }

            else 
            { 
                MessageBox.Show("Kare olmayan matrisler için determinant hesabý yapýlamaz.");
                return 0;
            }
        }

        public int[,] transpose(int[,] matName, int row, int col)
        {
            int[,] transMatrix = new int[col, row];
            
            for (int i=0; i<row; i++)
            {
                for (int j=0; j<col; j++)
                {
                    transMatrix[j, i] = matName[i, j];
                }
            }

            return transMatrix;
        }

        private void colB_Scroll(object sender, EventArgs e)
        {
            matrixSizer(1);
        }
    }
}