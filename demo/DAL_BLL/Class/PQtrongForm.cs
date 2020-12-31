using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
namespace DAL_BLL.Class
{
    public class PQtrongForm
    {
        QLDiemTHPTDataContext db = new QLDiemTHPTDataContext();

        public BarItemVisibility loadper(string id, int groupname, string pername)
        {
            var per = db.Permissions.Single(t => t.ID_Group == groupname && t.Per_Code.Equals(pername)).ID_Per;
            var kq = db.Details.FirstOrDefault(t => t.ID_NV == id && t.ID_Group == groupname && t.ID_Per == per);
            BarButtonItem barButtonItem = new BarButtonItem();
            if (id == "LND004")
            {
                barButtonItem.Visibility = BarItemVisibility.Always;
            }
            else
            {
                if (kq == null)
                {
                    barButtonItem.Visibility = BarItemVisibility.Never;
                }
                else
                {
                    var kq1 = db.Details.FirstOrDefault(t => t.ID_NV == id && t.ID_Group == groupname && t.ID_Per == per).Action_Check;
                    if (kq1 == true)
                        barButtonItem.Visibility = BarItemVisibility.Always;
                    else barButtonItem.Visibility = BarItemVisibility.Never;
                }
            }
            return barButtonItem.Visibility;
        }

        public bool loaddgv(string id, int groupname, string pername)
        {
            if (id == "LND004")
            {
                return true;
            }
            else
            {
                var per1 = db.Permissions.SingleOrDefault(t => t.Per_Code == pername).ID_Per;
                if (per1 == null)
                {
                    return false;
                }
                else
                {
                    var kq = db.Details.Single(t => t.ID_NV == id && t.ID_Group == groupname && t.ID_Per == per1).Action_Check;
                    if (kq == null)
                    {
                        return false;
                    }
                    else
                    {
                        if (kq == false)
                            return false;
                        else return true;
                    }
                }
            }
        }
        public string loadMagv(string id)
        {
            return db.NGUOIDUNGs.FirstOrDefault(t => t.MaLoai == id).TenND;
        }
    }
}
