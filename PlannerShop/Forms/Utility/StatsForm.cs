
using PlannerShop.Data;

namespace PlannerShop.Forms
{
    public partial class StatsForm: Form
    {
        public StatsForm()
        {
            InitializeComponent();

            int numProdotti = DBStats.GetTotalProducts();
            int numFornitori = DBStats.GetTotalSuppliers();
            int totale = DBStats.GetTotalQuantity();
            int totaleNetto = DBStats.GetTotalInventoryValueNet();
            int totaleIvato = DBStats.GetTotalInventoryValueGross();
            string marcaComune = DBStats.GetMostCommonBrand();


        }
    }
}
