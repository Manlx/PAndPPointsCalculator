using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAndPPointsCalculator
{
    class PlayerDisplay
    {
        public static int iGpbWidth = 200,iHeight = 350,iPicSize= 200,iTextWidth = 200;
        public static int Created = 0;
        public System.Windows.Forms.TextBox Name;
        public System.Windows.Forms.GroupBox Gpb;
        public System.Windows.Forms.ComboBox cbbAvatars;
        public System.Windows.Forms.PictureBox AvatarDisp;
        public static List<string> cbbItems;
        public static List<string> cbbUsed;
        public int SelectedString;
        public PlayerDisplay(System.Windows.Forms.Control Master,string NameDisp)
        {
            //Creates GroupBox
            Gpb = new System.Windows.Forms.GroupBox();
            Master.Controls.Add(Gpb);
            Gpb.Width = iGpbWidth;
            Gpb.Height = iHeight;
            Gpb.Text = NameDisp;
            Gpb.Left = iGpbWidth * Created;
            Gpb.Top = 0;

            //Create cbbAvatars
            AvatarDisp = new System.Windows.Forms.PictureBox();
            AvatarDisp.Width = iPicSize;
            AvatarDisp.Height = iPicSize;
            Gpb.Controls.Add(AvatarDisp);
            AvatarDisp.Left = 0;
            AvatarDisp.Top = Gpb.Height - AvatarDisp.Height;

            //Create Combox;
            cbbAvatars = new System.Windows.Forms.ComboBox();
            Gpb.Controls.Add(cbbAvatars);
            cbbAvatars.Width = iTextWidth;
            cbbAvatars.Left = 0;
            cbbAvatars.Top = AvatarDisp.Top - cbbAvatars.Height - 5;

            //Create Name text
            Name = new System.Windows.Forms.TextBox();
            Name.Width = iTextWidth;
            Name.Left = 0;
            Name.Top = cbbAvatars.Top - Name.Height - 5;
        }
    }
}
