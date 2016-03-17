using CRM_4S.Business;
using CRM_4S.Business.BusinessModel;
using CRM_4S.Model.DataModel;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CRM_4S.DataAnalyse
{
    public partial class FmDataAnalyseView : Form
    {
        public FmDataAnalyseView()
        {
            InitializeComponent();
        }

        #region Public Controls

        private BarEditItem txtConsName = null;
        public BarEditItem TxtConsName
        {
            get { return txtConsName; }
            set
            {
                txtConsName = value;
                if (txtConsName != null)
                {
                    txtConsName.EditValueChanged += BarEditItem_EditValueChanged;
                }
            }
        }

        private BarEditItem txtConsPhone = null;
        public BarEditItem TxtConsPhone
        {
            get { return txtConsPhone; }
            set
            {
                txtConsPhone = value;
                if (txtConsPhone != null)
                {
                    txtConsPhone.EditValueChanged += BarEditItem_EditValueChanged;
                }
            }
        }

        private BarEditItem dtStartDate = null;
        public BarEditItem DtStartDate
        {
            get { return dtStartDate; }
            set
            {
                dtStartDate = value;
                if (dtStartDate != null)
                {
                    //dtStartDate.EditValueChanged += BarEditItem_EditValueChanged;
                }
            }
        }

        private BarEditItem dtEndDate = null;
        public BarEditItem DtEndDate
        {
            get { return dtEndDate; }
            set
            {
                dtEndDate = value;
                if (dtEndDate != null)
                {
                    //dtEndDate.EditValueChanged += BarEditItem_EditValueChanged;
                }
            }
        }

        void BarEditItem_EditValueChanged(object sender, EventArgs e)
        {
            RefreshAnalyseView();
        }

        private BarButtonItem btnSingleAnalyse = null;
        public BarButtonItem BtnSingleAnalyse
        {
            get { return btnSingleAnalyse; }
            set
            {
                btnSingleAnalyse = value;
                if (btnSingleAnalyse != null)
                {
                    btnSingleAnalyse.ItemClick += btnSingleAnalyse_ItemClick;
                }
            }
        }

        private BarButtonItem btnGroupAnalyse = null;
        public BarButtonItem BtnGroupAnalyse
        {
            get { return btnGroupAnalyse; }
            set
            {
                btnGroupAnalyse = value;
                if (btnGroupAnalyse != null)
                {
                    btnGroupAnalyse.ItemClick += btnGroupAnalyse_ItemClick;
                }
            }
        }

        void btnGroupAnalyse_ItemClick(object sender, ItemClickEventArgs e)
        {
            Object rowData = gridViewConsultant.GetRow(gridViewConsultant.GetSelectedRows()[0]);
            var rowInfo = rowData as UserShopRoleInfo;
            var groupInfo = this.GroupList.FirstOrDefault(m => m.Id == rowInfo.User.GroupId);
            new FmAnalyseResult(rowInfo.User, groupInfo).Show();
        }


        void btnSingleAnalyse_ItemClick(object sender, ItemClickEventArgs e)
        {
            Object rowData = gridViewConsultant.GetRow(gridViewConsultant.GetSelectedRows()[0]);
            var rowInfo = rowData as UserShopRoleInfo;
            new FmAnalyseResult(rowInfo.User).Show();
        }

        #endregion


        private IList<UserGroupInfo> groupList = null;
        private IList<UserGroupInfo> GroupList
        {
            get
            {
                if (groupList == null)
                {
                    groupList = UserBusiness.Instance.GetGroups(GlobalCaches.Instance.CurUser.ShopId);
                }
                return groupList;
            }
        }


        private void gridViewConsultant_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {

            if (e.Column.Name == "clmUserGroup" && this.GroupList != null)
            {
                int cValue = (int)e.CellValue;
                e.DisplayText = cValue == 0 ? "" : this.GroupList.FirstOrDefault(m => m.Id == cValue).Name;
            }
        }

        private void FmDataAnalyseView_Load(object sender, EventArgs e)
        {

            //this.DtStartDate.EditValue = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            //this.dtEndDate.EditValue = DateTime.Now;
            RefreshAnalyseView();
        }

        private void gridViewConsultant_MouseDown(object sender, MouseEventArgs e)
        {
            // 判断是否为左键双击
            if (e.Button != MouseButtons.Left || e.Clicks != 2)
                return;

            GridHitInfo hInfo = gridViewConsultant.CalcHitInfo(new Point(e.X, e.Y));
            //判断光标是否在行范围内  
            if (!hInfo.InRow || !hInfo.InRowCell)
                return;

            btnSingleAnalyse_ItemClick(sender, null);
        }

        private List<UserShopRoleInfo> dataSource = null;
        private List<UserShopRoleInfo> DataSource
        {
            get
            {
                if (dataSource == null || dataSource.Count == 0)
                {
                    dataSource = new List<UserShopRoleInfo>();
                    if (GlobalCaches.Instance.ConsultantInfos.Count > 0)
                    {
                        foreach (var info in GlobalCaches.Instance.ConsultantInfos)
                        {
                            dataSource.Add(new UserShopRoleInfo() { User = info });
                        }
                    }
                }
                return dataSource;
            }
        }
        private void RefreshAnalyseView()
        {
            string consName = this.TxtConsName.EditValue.ToString().Trim();
            string consPhone = this.TxtConsPhone.EditValue.ToString().Trim();
            var gridSource = this.DataSource;
            if (!string.IsNullOrEmpty(consName) || !string.IsNullOrEmpty(consPhone))
            {
                gridSource = this.DataSource.Where(e =>
                 {
                     bool bName = true, bPhone = true;
                     if (!string.IsNullOrEmpty(consName))
                         bName = e.User.RealName.Contains(consName);
                     if (!string.IsNullOrEmpty(consPhone))
                         bPhone = e.User.Phone.Contains(consPhone);
                     return bName && bPhone;
                 }).ToList();
            }
            gridControlConsultant.DataSource = gridSource;
            gridControlConsultant.DefaultView.RefreshData();
        }
    }
}
