using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Registrator;

namespace WindowsApplication1
{
    /// <summary>
    /// MyButtonEdit is a descendant from ButtonEdit.
    /// It displays a dialog form below the text box when the edit button is clicked.
    /// </summary>
    public class MyButtonEdit : ButtonEdit
    {
        static MyButtonEdit()
        {
            RepositoryItemMyButtonEdit.Register();
        }


        public override string EditorTypeName
        {
            get { return RepositoryItemMyButtonEdit.EditorName; }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemMyButtonEdit Properties
        {
            get { return base.Properties as RepositoryItemMyButtonEdit; }
        }


    }
}
