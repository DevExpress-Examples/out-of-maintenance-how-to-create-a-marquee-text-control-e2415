using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.ViewInfo;

namespace WindowsApplication1
{
    public class MyButtonEditPainter : ButtonEditPainter
    {

        public MyButtonEditPainter()
        {

        }

        public int GetScrollPosition(ControlGraphicsInfoArgs info)
        {
            object value = ((ButtonEditViewInfo)(info.ViewInfo)).EditValue;
            return Convert.ToInt32(value);
        }
        protected override void DrawContent(ControlGraphicsInfoArgs info)
        {
            DrawText(info);
        }

        protected override void DrawText(ControlGraphicsInfoArgs info)
        {
            int scrollPosition = GetScrollPosition(info);
            DevExpress.Utils.AppearanceObject appearance = info.ViewInfo.Appearance;
            Rectangle bounds = (info.ViewInfo as ButtonEditViewInfo).MaskBoxRect;
            string displayText = info.ViewInfo.DisplayText;
            bounds.Offset(0, scrollPosition);
            bounds.Height = info.Graphics.MeasureString(displayText, appearance.GetFont()).ToSize().Height;
            appearance.DrawString(info.Cache, displayText, bounds);
        }
    }
}
