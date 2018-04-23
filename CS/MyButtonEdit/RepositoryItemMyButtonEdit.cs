using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Drawing;

namespace WindowsApplication1
{
    [UserRepositoryItem("Register")]
    public class RepositoryItemMyButtonEdit : RepositoryItemButtonEdit
    {

        static RepositoryItemMyButtonEdit()
        {
            Register();
        }
        public RepositoryItemMyButtonEdit() 
        {
            TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
        }

        public override void CreateDefaultButton()
        {
        }



        internal const string EditorName = "MYButtonEdit";

        public static void Register()
        {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(EditorName, typeof(MyButtonEdit),
                typeof(RepositoryItemMyButtonEdit), typeof(DevExpress.XtraEditors.ViewInfo.ButtonEditViewInfo),
                new MyButtonEditPainter(), true, null));
        }
        public override string EditorTypeName
        {
            get { return EditorName; }
        }

        public override void Assign(RepositoryItem item)
        {
            base.Assign(item);
            TextToScroll = ((RepositoryItemMyButtonEdit)item).TextToScroll;
        }

        private string _TextToScroll;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string TextToScroll
        {
            get { return _TextToScroll; }
            set { _TextToScroll = value; }
        }

        public override string GetDisplayText(object editValue)
        {
            return  TextToScroll;
        }

        public override string GetDisplayText(DevExpress.Utils.FormatInfo format, object editValue)
        {
            return TextToScroll;
        }

    }
}