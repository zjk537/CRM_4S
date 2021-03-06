﻿using CRM_4S.Business;
using CRM_4S.Business.BusinessModel;
using CRM_4S.Business.ViewModel;
using CRM_4S.Model.EnumType;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CRM_4S.OrderManager
{
    public partial class FmOrderView : Form
    {
        public FmOrderView()
        {
            InitializeComponent();
            initView();
            OrderRecordBusiness.Instance.OnDataChanged += new EventHandler<CusEventArgs>((object sender, CusEventArgs args) => { RefreshView(); });
        }

        #region Public Control
        BarButtonItem btnAdd = null;
        public BarButtonItem BtnAdd
        {
            get { return btnAdd; }
            set
            {
                btnAdd = value;
                if (btnAdd != null)
                {
                    btnAdd.ItemClick += btnAdd_ItemClick;
                }
            }
        }
        BarButtonItem btnUpdate = null;
        public BarButtonItem BtnUpdate
        {
            get { return btnUpdate; }
            set
            {
                btnUpdate = value;
                if (btnUpdate != null)
                {
                    btnUpdate.ItemClick += btnUpdate_ItemClick;
                }
            }
        }

        BarButtonItem btnDelete = null;
        public BarButtonItem BtnDelete
        {
            get { return btnDelete; }
            set
            {
                btnDelete = value;
                if (btnDelete != null)
                {
                    btnDelete.ItemClick += btnDelete_ItemClick;
                }
            }
        }

        BarButtonItem btnRefresh = null;
        public BarButtonItem BtnRefresh
        {
            get { return btnRefresh; }
            set
            {
                btnRefresh = value;
                if (btnRefresh != null)
                {
                    btnRefresh.ItemClick += btnRefresh_ItemClick;
                }
            }
        }

        private void btnAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            new FmOrderInfo().ShowDialog();
        }

        private void btnUpdate_ItemClick(object sender, ItemClickEventArgs e)
        {
            Object rowData = gridViewOrderRecord.GetRow(gridViewOrderRecord.GetSelectedRows()[0]);
            var cOrderInfo = rowData as CustomerOrderRecordInfo;
            if (cOrderInfo != null && cOrderInfo.OrderRecord.Status == 3) // 已取消的订单不能修改
                return;

            new FmOrderInfo(cOrderInfo.OrderRecord, cOrderInfo.Customer).ShowDialog();
        }

        private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {


            DialogResult result = XtraMessageBox.Show("确认要取消订单，取消后不能恢复！", "提示", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Object rowData = gridViewOrderRecord.GetRow(gridViewOrderRecord.GetSelectedRows()[0]);
                CustomerOrderRecordInfo info = rowData as CustomerOrderRecordInfo;
                OrderRecordBusiness.Instance.CancelOrderRecord(info.OrderRecord.Id);
            }
        }

        private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            RefreshView();
        }
        #endregion

        private void initView()
        {
            //this.gridViewOrderRecord.IndicatorWidth = 50;
        }

        private void RefreshView()
        {
            var listResults = OrderRecordBusiness.Instance.GetCustomerOrderRecords(this.QInfo);
            gridControlOrderRecord.DataSource = listResults;
            gridControlOrderRecord.DefaultView.RefreshData();
            if (listResults.Count == 0)
                this.btnDelete.Enabled = this.btnUpdate.Enabled = false;
            else
            {
                this.btnDelete.Enabled = listResults.FirstOrDefault().OrderRecord.Status == (int)OrderStatus.PrePay;
            }

        }

        private ViewQueryInfo qInfo = null;
        public ViewQueryInfo QInfo
        {
            get
            {
                if (qInfo == null)
                    qInfo = new ViewQueryInfo()
                    {
                        ShopId = GlobalCaches.Instance.CurUser.ShopId,
                        StartDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1),
                        EndDate = DateTime.Now
                    };
                return qInfo;
            }
            set
            {
                qInfo = value;
                if (qInfo != null)
                {
                    qInfo.ShopId = GlobalCaches.Instance.CurUser.ShopId;
                    RefreshView();
                }
            }
        }

        private void FmOrderView_Load(object sender, EventArgs e)
        {
            RefreshView();
        }

        private void gridViewOrderRecord_MouseDown(object sender, MouseEventArgs e)
        {
            // 判断是否为左键双击
            if (e.Button != MouseButtons.Left || e.Clicks != 2)
            {
                Object rowData = gridViewOrderRecord.GetRow(gridViewOrderRecord.GetSelectedRows()[0]);
                CustomerOrderRecordInfo info = rowData as CustomerOrderRecordInfo;
                //只有预付订金可以取消交易
                this.btnDelete.Enabled = info.OrderRecord.Status == (int)OrderStatus.PrePay;
                return;
            }

            GridHitInfo hInfo = gridViewOrderRecord.CalcHitInfo(new Point(e.X, e.Y));
            //判断光标是否在行范围内  
            if (!hInfo.InRow || !hInfo.InRowCell)
                return;

            btnUpdate_ItemClick(sender, null);
        }

        private void gridViewOrderRecord_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            if (e.RowHandle < 0) return;
            CustomerOrderRecordInfo info = gridViewOrderRecord.GetRow(e.RowHandle) as CustomerOrderRecordInfo;
            //1 预付订金; 2 订单完成 3 订单取消 
            if (info == null || !info.OrderRecord.Status.HasValue) return;

            switch (info.OrderRecord.Status)
            {
                case (int)OrderStatus.PrePay:
                    e.Appearance.ForeColor = Color.FromArgb(102, 168, 9);
                    break;
                case (int)OrderStatus.Finish:
                    e.Appearance.ForeColor = Color.FromArgb(206, 146, 30);
                    break;
                case (int)OrderStatus.Cancel:
                    e.Appearance.BackColor = Color.FromArgb(240, 240, 240);
                    e.Appearance.ForeColor = Color.FromArgb(127, 127, 127);
                    break;
            }
        }

        private void gridViewOrderRecord_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.Name == "clmStatus")
            {
                int cellValue = Convert.ToInt32(e.CellValue);
                if (cellValue == 1) e.DisplayText = "已下订金";
                else if (cellValue == 2) e.DisplayText = "完成";
                else if (cellValue == 3) e.DisplayText = "订单取消";
            }
        }
    }
}
