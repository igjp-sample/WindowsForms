using System;
using System.Data;
using System.Windows.Forms;

namespace ScrollGrid_v19
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            // prepare the data tables
            DataSet ds = new DataSet();
            for (int i = 0; i < 3; ++ i)
            {
                DataTable dt = ds.Tables.Add();
                dt.Columns.Add("value", typeof(string));
                dt.Columns.Add("parent", typeof(string)).Unique = false;

                if (i > 0)
                { ds.Relations.Add(ds.Tables[i - 1].Columns["value"], dt.Columns["parent"]); }
            }

            // fill the data tables
            for (int i = 0; i < 100; ++ i)
            {
                DataRow drI = ds.Tables[0].NewRow();
                drI.SetField<string>("value", $"i {i}");
                ds.Tables[0].Rows.Add(drI);

                for (int j = 0; j < 20; ++ j)
                {
                    DataRow drJ = ds.Tables[1].NewRow();
                    drJ.SetField<string>("value", $"j {i}, {j}");
                    drJ.SetField<string>("parent", $"i {i}");
                    ds.Tables[1].Rows.Add(drJ);

                    for (int k = 0; k < 20; ++ k)
                    {
                        DataRow drK = ds.Tables[2].NewRow();
                        drK.SetField<string>("value", $"k {i}, {j}, {k}");
                        drK.SetField<string>("parent", $"j {i}, {j}");
                        ds.Tables[2].Rows.Add(drK);
                    }
                }
            }

            this.dgAuswertung.DataSource = ds;

            this.dgAuswertung.ActiveRowScrollRegion.ScrollPosition = 14;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.dgAuswertung.ActiveRowScrollRegion.ScrollPosition = 150;
        }


        private void ultraButton1_Click(object sender, EventArgs e)
        {
            this.dgAuswertung.ActiveRowScrollRegion.ScrollPosition = 7;
        }
    }
}
