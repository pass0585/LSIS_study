using ClassLibrary1.CRUD;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDWinformApp
{
    public partial class Form1 : XtraForm
    {
        public CRUD crud = new CRUD();

        public Form1()
        {
            InitializeComponent();

            this.InitControls();
            this.InitData();
        }

        private void InitControls()
        {
            this.comboBox_Type.Properties.Items.AddRange(Enum.GetValues(typeof(ItemType)));
            this.comboBox_Type.SelectedIndex = 0;

            this.comboBox_Type.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
        }

        private void InitData()
        {
            crud.Add(new CRUDItem(ItemType.AType, "Item 1", "Item 1입니다."));
            crud.Add(new CRUDItem(ItemType.BType, "Item 2", "Item 2입니다."));
            crud.Add(new CRUDItem(ItemType.CType, "Item 3", "Item 3입니다."));

            gridControl1.DataSource = crud.List;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            CRUDItem item = new CRUDItem();
            item.Name = this.textEdit_Name.EditValue.ToString();
            item.Description = this.textEdit_Description.EditValue.ToString();

            string type = this.comboBox_Type.EditValue.ToString();
            item.ItemType = (ItemType)Enum.Parse(typeof(ItemType), type);

            crud.Add(item);

            this.Refresh();
        }

        //todo 2021.10 delete 기능 구현 필요

        private void deleteButton_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void Refresh()
        {
            gridControl1.RefreshDataSource();
        }
    }
}
