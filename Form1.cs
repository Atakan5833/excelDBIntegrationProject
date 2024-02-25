using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;

namespace excelDBIntegrationProject
{

    public partial class Form1 : Form
    {

        SqlConnection baglanti = new SqlConnection(@"Data Source=F58\SQLEXPRESS;Initial Catalog=Projeler;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }

        private void btnVTReading_Click(object sender, EventArgs e)
        {
            Excel.Application excelUygulama = new Excel.Application();
            excelUygulama.Visible = true;
            Excel.Workbook workbook = excelUygulama.Workbooks.Add(System.Reflection.Missing.Value);
            Excel.Worksheet Personel1 = workbook.Worksheets[1];

            string[] baslik = { "Personel No", "Ad", "Soyad", "Semt", "Þehir" };
            Excel.Range range;
            for(int i = 0; i < baslik.Length; i++)
            {
                range = Personel1.Cells[1, (1 + i)];//1.satýr , 1. sütuna sonra arta arta devam et demek
                range.Value2 = baslik[i];
            }



            try
            {
                baglanti.Open();
                string sqlCumlesi = "SELECT * FROM Personel";
                SqlCommand sqlKomut = new SqlCommand(sqlCumlesi, baglanti);
                SqlDataReader sdr = sqlKomut.ExecuteReader();

                int satir = 2;

                while (sdr.Read())
                {
                    string PersonelNo = sdr[0].ToString();
                    string Ad = sdr[1].ToString();
                    string Soyad = sdr[2].ToString();
                    string Semt = sdr[3].ToString();
                    string Sehir = sdr[4].ToString();
                    richTextBox1.Text = richTextBox1.Text+ PersonelNo + " "+ Ad +" "+Soyad+ " "+Semt+" "+Sehir+"\r";

                    range = Personel1.Cells[satir, 1];
                    range.Value2 = PersonelNo;
                    range = Personel1.Cells[satir, 2];
                    range.Value2 = Ad;
                    range = Personel1.Cells[satir, 3];
                    range.Value2 = Soyad;
                    range = Personel1.Cells[satir, 4];
                    range.Value2 = Semt;
                    range = Personel1.Cells[satir, 5];
                    range.Value2 = Sehir;
                    satir++;
                }

            }
            catch (Exception ex) {
                MessageBox.Show("SQL Query Hatasý!!"+"\n"+ex.ToString());
            }
            finally
            {
                if (baglanti != null)
                    baglanti.Close();
            }
        }
    }
}
